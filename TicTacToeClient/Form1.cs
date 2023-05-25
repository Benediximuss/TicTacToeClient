using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace TicTacToeClient
{
    public partial class Form1 : Form
    {
        // Form Components
        List<List<Button>> buttonsMatrix = new List<List<Button>>();

        // Game information
        string username;
        char side;

        // Game logic

        // Network components comoon
        Socket clientSocket;
        bool isJoined = false;
        bool isYourTurn = false;

        // Constructor
        public Form1()
        {
            /*To access UI elements in multi-thread level*/
            Control.CheckForIllegalCrossThreadCalls = false;

            // For closing window
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            InitializeComponent();

            // Other initializations
            setInfoText("init");
            initButtonsMatrix();
            DisableBlueHighlight();

            string ss = "meric";
            if (ss == "meric")
                textBox_IP.Text = "10.51.18.6";
            else
                textBox_IP.Text = "10.51.23.65";
                //textBox_IP.Text = "159.20.93.207";

            textBox_Port.Text = "3131";

            textBox_Name.Text = "zort";

        }



        // Buttons
        private void btn_Connect_Click(object sender, EventArgs e)
        {

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            int port;
            if (Int32.TryParse(textBox_Port.Text, out port)) // Checks port's validity
            {
                try
                {
                    clientSocket.Connect(textBox_IP.Text, port); // Tries to connect, if cannot throw exception

                    toggleComponentsEnabled(false, label_IP, label_Port, textBox_IP, textBox_Port, btn_Connect);
                    setInfoText("connected");

                    Thread recieveThread = new Thread(serverListener); // Start Recieve function to recieve message from server
                    recieveThread.Start();
                }
                catch (Exception exc)
                {
                    richTextBox_Log.AppendText("Couldn't connect to the server!\n");
                }
            }
            else
            {
                richTextBox_Log.AppendText("Invalid port number, try again!\n");
            }

        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            username = textBox_Name.Text;

            Byte[] buffer_send = Encoding.Default.GetBytes("join:" + username);
            try
            {
                clientSocket.Send(buffer_send); // Sending username for server to be checked

                toggleComponentsEnabled(false, label_Name, textBox_Name, btn_Join, btn_Disconnect);

                setInfoText("waiting");
            }
            catch
            {
                richTextBox_Log.AppendText("Couldn't send message to the server, try again!\n");
            }

        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (isJoined) // leave room
            {
                leaveRoom();
                toggleComponentsEnabled(true, btn_Join, textBox_Name, btn_Disconnect);
                toggleComponentsEnabled(false, btn_Queue, btn_Accept);
                btn_Disconnect.Text = "Disconnect";
                isJoined = false;
            }
            else // disconnect server
            {
                toggleComponentsEnabled(true, label_IP, label_Port, textBox_IP, textBox_Port, btn_Connect);
                toggleComponentsEnabled(false, textBox_Name, btn_Join, btn_Disconnect);

                textBox_Name.Clear();

                clientSocket.Close();
                clientSocket.Dispose();

            }
        }

        private void btn_Queue_Click(object sender, EventArgs e)
        {
            string msg = $"queue:{username}";
            Byte[] buffer_send = Encoding.Default.GetBytes(msg);

            try
            {
                clientSocket.Send(buffer_send);
                richTextBox_Log.AppendText("You've sent request!\n");
                toggleComponentsEnabled(false, btn_Queue);
                setInfoText("inqueue");
            }
            catch
            {
                richTextBox_Log.AppendText("Coouldn't send queue request, try again!\n");
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string msg = $"accept:{username}:{side}";
            Byte[] buffer_send = Encoding.Default.GetBytes(msg);

            try
            {
                clientSocket.Send(buffer_send);
                richTextBox_Log.AppendText("You've accept the game!\n");
                toggleComponentsEnabled(false, btn_Accept);
                setInfoText("accepted");
            }
            catch
            {
                richTextBox_Log.AppendText("Couldn't accept, try again!\n");
            }
        }

        private void btn_clearLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Clear();
            richTextBox_Log.AppendText(username + '\n');
        }

        // Connection
        private void leaveRoom()
        {
            string msg = $"leave:{username}";
            Byte[] buffer_send = Encoding.Default.GetBytes(msg);

            try
            {
                clientSocket.Send(buffer_send);
                richTextBox_Log.AppendText("You've left the room!\n");
                username = string.Empty;
                side = '\0';

            }
            catch
            {
                richTextBox_Log.AppendText("Coouldn't leave, try again!\n");
            }
        }

        private void serverListener()
        {
            while (clientSocket.Connected)
            {
                try
                {
                    string[] token = receiveResponse();

                    if (token[0] == "200") // Connected successfully
                    {
                        richTextBox_Log.AppendText("You have successfully connected to the server!\n");

                        toggleComponentsEnabled(true, label_Name, textBox_Name, btn_Join, btn_Disconnect);
                    }
                    else if (token[0] == "400") // Server full
                    {
                        richTextBox_Log.AppendText("Couldn't connect to the server, it is full now!\n");

                        toggleComponentsEnabled(true, label_IP, label_Port, textBox_IP, textBox_Port, btn_Connect);

                        clientSocket.Close();
                    }

                    else if (token[0] == "201") // Username approved, joined successfully
                    {
                        isJoined = true;
                        richTextBox_Log.AppendText(token[1]);

                        toggleComponentsEnabled(true, btn_Queue, btn_Disconnect);
                        setInfoText("joined");
                        btn_Disconnect.Text = "Leave";
                    }
                    else if (token[0] == "401") // Invalid username
                    {
                        richTextBox_Log.AppendText("Please try another username!\n");

                        toggleComponentsEnabled(true, label_Name, textBox_Name, btn_Join, btn_Disconnect);
                        setInfoText("connected");
                        username = "";
                    }

                    else if (token[0] == "startreq")
                    {
                        richTextBox_Log.AppendText(token[2]);
                        toggleComponentsEnabled(true, btn_Accept);
                        setInfoText("gamefound", token[1]);
                        side = token[1][0];
                    }
                    else if (token[0] == "startplay")
                    {
                        toggleComponentsEnabled(false, btn_Accept);
                        setInfoText("gamestarts", side.ToString());
                    }
                    else if (token[0] == "yourturn")
                    {
                        isYourTurn = side.ToString() == token[1] ? true : false;

                        if (isYourTurn)
                        {
                            updateUnplayedButtons();
                        }
                    }

                    else if (token[0] == "update")
                    {
                        if (token[1] == "vs")
                        {
                            setVersusLabels(token[2], token[3]);
                            toggleComponentsEnabled(true, label_currentPlayer1, label_currentPlayer2, label_CurrentGame);
                        }
                        else if (token[1] == "board")
                        {
                            updateGameBoard(token[2]);
                        }
                        else if (token[1] == "label")
                        {
                            setVersusLabels(token[2], token[3]);
                        }
                        else if (token[1] == "finish") { 
                            toggleButtonsEnabled(false);
                            toggleComponentsEnabled(true, btn_Queue);
                            isYourTurn = false;
                            //info win/lose = token[2] //username = token[3]
                        }
                    }

                    else if (token[0] == "info")
                    {
                        richTextBox_Log.AppendText(token[1]);
                    }
                }
                catch
                {
                    richTextBox_Log.AppendText("Lost connection with the server!\n");
                    resetAll();
                }
            }
        }

        private string[] receiveResponse()
        {
            Byte[] buffer = new Byte[128];
            clientSocket.Receive(buffer);
            string response = Encoding.Default.GetString(buffer);
            string[] token = response.Trim('\0').Split(':');
            return token;
        }


        // Game functions
        private void makeMove(Button clickedButton)
        {
            string coords = clickedButton.Name.Split('_')[1];
            string msg = $"move:{coords[0]}-{coords[1]}";
            richTextBox_Log.AppendText(msg + "\n");
            Byte[] buffer_send = Encoding.Default.GetBytes(msg);

            try
            {
                clientSocket.Send(buffer_send);
                isYourTurn = false;
                updateUnplayedButtons();
            }
            catch
            {
                richTextBox_Log.AppendText("Couldn't play, try again!\n");
            }

        }

        private void updateGameBoard(string boardSerial)
        {
            String[,] gameBoard = JsonConvert.DeserializeObject<String[,]>(boardSerial);

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    buttonsMatrix[x][y].Text = gameBoard[x, y];
                }
            }
        }

        private void updateUnplayedButtons()
        {
            foreach (List<Button> row in buttonsMatrix)
            {
                foreach (Button button in row)
                {
                    button.Enabled = (isYourTurn && button.Text == " ") ? true : false;
                }
            }
        }

        /*        private void changeButton(string[] buttonCoords, char side, bool isEnabled = false)
                {
                    buttonsMatrix[int.Parse(buttonCoords[0])][int.Parse(buttonCoords[1])].Enabled = isEnabled;
                    buttonsMatrix[int.Parse(buttonCoords[0])][int.Parse(buttonCoords[1])].Text = side.ToString();
                }*/


        // Component Functions 
        void toggleComponentsEnabled(bool state, params Control[] components)
        {
            foreach (Control component in components)
            {
                component.Enabled = state;
            }
        }

        private void toggleButtonsEnabled(bool state)
        {
            foreach (List<Button> row in buttonsMatrix)
            {
                foreach (Button button in row)
                {
                    button.Enabled = state;
                }
            }
        }

        private void setInfoText(params string[] components)
        {
            if (components[0] == "init")
                label_Notification.Text = "Enter an IP address and a Port Number to connect a server!";
            else if (components[0] == "connected")
                label_Notification.Text = "Enter a username to join the game room!";
            else if (components[0] == "joined")
                label_Notification.Text = "Join the game queue to play a game!";
            else if (components[0] == "waiting")
                label_Notification.Text = "Waiting for response...";
            else if (components[0] == "inqueue")
                label_Notification.Text = "You are in the game queue";
            else if (components[0] == "gamefound")
                label_Notification.Text = $"Found game!\nAccept for start playing as {components[1]}!";
            else if (components[0] == "accepted")
                label_Notification.Text = $"Wait for your opponent to accept!";
            else if (components[0] == "gamestarts")
                label_Notification.Text = $"You are playing as {components[1]}!";


        }

        private void setVersusLabels(string p1, string p2)
        {
            label_currentPlayer1.Text = p1;
            label_currentPlayer2.Text = p2;
        }

        private void resetAll()
        {
            toggleComponentsEnabled(true, label_IP, label_Port, textBox_IP, textBox_Port, btn_Connect);
            toggleComponentsEnabled(false, label_Name, textBox_Name, btn_Join, btn_Disconnect, btn_Queue, btn_Accept);
            setInfoText("init");
            isJoined = false;
            username = "";
        }

        // Initialization
        private void initButtonsMatrix()
        {
            List<Button> row;

            row = new List<Button>();
            row.Add(btn_00);
            row.Add(btn_01);
            row.Add(btn_02);
            buttonsMatrix.Add(row);

            row = new List<Button>();
            row.Add(btn_10);
            row.Add(btn_11);
            row.Add(btn_12);
            buttonsMatrix.Add(row);

            row = new List<Button>();
            row.Add(btn_20);
            row.Add(btn_21);
            row.Add(btn_22);
            buttonsMatrix.Add(row);
        }

        private void DisableBlueHighlight()
        {
            // Disables the blue focus highlight surrounding the buttons, for all buttons
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
            }
        }


        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (clientSocket != null && clientSocket.Connected)
            {
                clientSocket.Close();
                clientSocket.Dispose();
            }

            Environment.Exit(0);
        }




        // XOX Buttons
        private void btn_00_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            makeMove((Button)sender);
        }




        private void previewMove(Button clickedButton, bool isEnter)
        {
            if (isEnter)
            {
                clickedButton.Text = side.ToString();
                clickedButton.ForeColor = Color.Crimson;
            }
            else
            {
                if (isYourTurn)
                    clickedButton.Text = " ";
                clickedButton.ForeColor = SystemColors.ControlText;
            }
        }

        private void btn_00_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_00_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_01_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_01_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_02_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_02_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_10_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_10_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_11_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_11_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_12_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_12_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_20_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_20_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_21_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_21_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }

        private void btn_22_MouseEnter(object sender, EventArgs e)
        {
            previewMove((Button)sender, true);
        }

        private void btn_22_MouseLeave(object sender, EventArgs e)
        {
            previewMove((Button)sender, false);
        }
    
    }
}