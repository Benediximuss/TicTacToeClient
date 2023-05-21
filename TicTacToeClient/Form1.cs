namespace TicTacToeClient
{
    public partial class Form1 : Form
    {
        List<List<Button>> buttonsMatrix = new List<List<Button>>();

        char currentTurn;

        public Form1()
        {
            InitializeComponent();

            initButtonsMatrix();
            DisableBlueHighlight();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            richTextBox_Log.AppendText("Game starts.\nTurn for X\n");

            buttonsEnabled(true);

            currentTurn = 'X';
        }

        // Disables the blue focus highlight surrounding the buttons, for all buttons
        private void DisableBlueHighlight()
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
            }
        }


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

        private void buttonsEnabled(bool state)
        {
            foreach (List<Button> row in buttonsMatrix)
            {
                foreach (Button button in row)
                {
                    button.Enabled = state;
                }
            }
        }

        private void buttonClicked(Button clickedButton)
        {
            clickedButton.Enabled = false;
            clickedButton.Text = currentTurn.ToString();
            currentTurn = currentTurn == 'X' ? 'O' : 'X';
        }


        private void resetAll()
        {

        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            buttonClicked((Button)sender);
        }
    }
}