using Microsoft.VisualBasic.Logging;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;

namespace TicTacToeClient
{
    public partial class Form1 : Form
    {
        // Form Components
        List<List<Button>> buttonsMatrix = new List<List<Button>>();

        // Game components
        string username;

        // Network components comoon
        Socket clientSocket;
        bool isJoined = false;

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
                disconnectServer();
                toggleComponentsEnabled(true, btn_Join, textBox_Name, btn_Disconnect);
                toggleComponentsEnabled(false, btn_Queue);
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
            }
            catch
            {
                richTextBox_Log.AppendText("Coouldn't send queue request, try again!\n");
            }
        }

        private void btn_clearLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Clear();
        }

        // Connection
        private void disconnectServer()
        {
            string msg = $"leave:{username}";
            Byte[] buffer_send = Encoding.Default.GetBytes(msg);

            try
            {
                clientSocket.Send(buffer_send);
                richTextBox_Log.AppendText("You've left the game!\n");
            }
            catch
            {
                richTextBox_Log.AppendText("Coouldn't dissconnect, try again!\n");
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

                    else if (token[0] == "info")
                    {
                        richTextBox_Log.AppendText(token[1]);
                    }
                }
                catch { }
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

        private void setInfoText(string state)
        {
            if (state == "init")
                label_Notification.Text = "Enter an IP address and a Port Number to connect a server!";
            else if (state == "connected")
                label_Notification.Text = "Enter a username to join the game room!";
            else if (state == "joined")
                label_Notification.Text = "Join the game queue to play a game!";
            else if (state == "waiting")
                label_Notification.Text = "Waiting for response...";
        }


        // XOX Buttons
        private void btn_00_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            buttonPlayed((Button)sender);
        }

        private void buttonPlayed(Button clickedButton)
        {

        }
        private void resetAll()
        {

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

        // Disables the blue focus highlight surrounding the buttons, for all buttons
        private void DisableBlueHighlight()
        {
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

  
    }
}