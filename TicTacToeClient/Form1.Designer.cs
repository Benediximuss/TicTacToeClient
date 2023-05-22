namespace TicTacToeClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Name = new Label();
            label_IP = new Label();
            label_Port = new Label();
            label_Leaderboard = new Label();
            textBox_Name = new TextBox();
            textBox_IP = new TextBox();
            textBox_Port = new TextBox();
            richTextBox_Log = new RichTextBox();
            dataGridView_Leaderboard = new DataGridView();
            btn_Connect = new Button();
            btn_Join = new Button();
            btn_Queue = new Button();
            btn_Dissconnect = new Button();
            label_Notification = new Label();
            btn_00 = new Button();
            btn_01 = new Button();
            btn_02 = new Button();
            btn_10 = new Button();
            btn_11 = new Button();
            btn_12 = new Button();
            btn_20 = new Button();
            btn_21 = new Button();
            btn_22 = new Button();
            label_currentPlayer1 = new Label();
            label_currentPlayer2 = new Label();
            label_CurrentGame = new Label();
            btn_splitter = new Button();
            btn_Accept = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Leaderboard).BeginInit();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Enabled = false;
            label_Name.Location = new Point(4, 74);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(45, 15);
            label_Name.TabIndex = 0;
            label_Name.Text = "Name :";
            // 
            // label_IP
            // 
            label_IP.AutoSize = true;
            label_IP.Location = new Point(26, 8);
            label_IP.Name = "label_IP";
            label_IP.Size = new Size(23, 15);
            label_IP.TabIndex = 1;
            label_IP.Text = "IP :";
            // 
            // label_Port
            // 
            label_Port.AutoSize = true;
            label_Port.Location = new Point(14, 37);
            label_Port.Name = "label_Port";
            label_Port.Size = new Size(35, 15);
            label_Port.TabIndex = 2;
            label_Port.Text = "Port :";
            // 
            // label_Leaderboard
            // 
            label_Leaderboard.AutoSize = true;
            label_Leaderboard.Enabled = false;
            label_Leaderboard.Location = new Point(318, 6);
            label_Leaderboard.Name = "label_Leaderboard";
            label_Leaderboard.Size = new Size(73, 15);
            label_Leaderboard.TabIndex = 3;
            label_Leaderboard.Text = "Leaderboard";
            // 
            // textBox_Name
            // 
            textBox_Name.Enabled = false;
            textBox_Name.Location = new Point(55, 71);
            textBox_Name.Margin = new Padding(3, 2, 3, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(92, 23);
            textBox_Name.TabIndex = 4;
            // 
            // textBox_IP
            // 
            textBox_IP.Location = new Point(56, 8);
            textBox_IP.Margin = new Padding(3, 2, 3, 2);
            textBox_IP.Name = "textBox_IP";
            textBox_IP.Size = new Size(159, 23);
            textBox_IP.TabIndex = 5;
            // 
            // textBox_Port
            // 
            textBox_Port.Location = new Point(56, 34);
            textBox_Port.Margin = new Padding(3, 2, 3, 2);
            textBox_Port.Name = "textBox_Port";
            textBox_Port.Size = new Size(47, 23);
            textBox_Port.TabIndex = 6;
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.BackColor = SystemColors.ControlLightLight;
            richTextBox_Log.Location = new Point(10, 185);
            richTextBox_Log.Margin = new Padding(3, 2, 3, 2);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.ReadOnly = true;
            richTextBox_Log.Size = new Size(286, 207);
            richTextBox_Log.TabIndex = 7;
            richTextBox_Log.Text = "";
            // 
            // dataGridView_Leaderboard
            // 
            dataGridView_Leaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Leaderboard.Enabled = false;
            dataGridView_Leaderboard.Location = new Point(318, 23);
            dataGridView_Leaderboard.Margin = new Padding(3, 2, 3, 2);
            dataGridView_Leaderboard.Name = "dataGridView_Leaderboard";
            dataGridView_Leaderboard.RowHeadersWidth = 51;
            dataGridView_Leaderboard.RowTemplate.Height = 29;
            dataGridView_Leaderboard.Size = new Size(312, 60);
            dataGridView_Leaderboard.TabIndex = 8;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(109, 33);
            btn_Connect.Margin = new Padding(3, 2, 3, 2);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(108, 23);
            btn_Connect.TabIndex = 9;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Join
            // 
            btn_Join.Enabled = false;
            btn_Join.Location = new Point(153, 70);
            btn_Join.Name = "btn_Join";
            btn_Join.Size = new Size(64, 23);
            btn_Join.TabIndex = 10;
            btn_Join.Text = "Join";
            btn_Join.UseVisualStyleBackColor = true;
            btn_Join.Click += btn_Join_Click;
            // 
            // btn_Queue
            // 
            btn_Queue.Enabled = false;
            btn_Queue.Location = new Point(12, 109);
            btn_Queue.Name = "btn_Queue";
            btn_Queue.Size = new Size(58, 23);
            btn_Queue.TabIndex = 11;
            btn_Queue.Text = "Queue";
            btn_Queue.UseVisualStyleBackColor = true;
            // 
            // btn_Dissconnect
            // 
            btn_Dissconnect.Enabled = false;
            btn_Dissconnect.Location = new Point(137, 109);
            btn_Dissconnect.Name = "btn_Dissconnect";
            btn_Dissconnect.Size = new Size(80, 23);
            btn_Dissconnect.TabIndex = 12;
            btn_Dissconnect.Text = "Leave";
            btn_Dissconnect.UseVisualStyleBackColor = true;
            btn_Dissconnect.Click += btn_Dissconnect_Click;
            // 
            // label_Notification
            // 
            label_Notification.Location = new Point(10, 135);
            label_Notification.Name = "label_Notification";
            label_Notification.Size = new Size(207, 48);
            label_Notification.TabIndex = 13;
            label_Notification.Text = "PLEASE CONNECT TO THE SERVER";
            label_Notification.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_00
            // 
            btn_00.Enabled = false;
            btn_00.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_00.ForeColor = SystemColors.ControlText;
            btn_00.Location = new Point(318, 108);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(100, 92);
            btn_00.TabIndex = 14;
            btn_00.UseVisualStyleBackColor = false;
            btn_00.Click += btn_00_Click;
            // 
            // btn_01
            // 
            btn_01.Enabled = false;
            btn_01.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_01.ForeColor = SystemColors.ControlText;
            btn_01.Location = new Point(424, 108);
            btn_01.Name = "btn_01";
            btn_01.Size = new Size(100, 92);
            btn_01.TabIndex = 15;
            btn_01.UseVisualStyleBackColor = false;
            btn_01.Click += btn_01_Click;
            // 
            // btn_02
            // 
            btn_02.Enabled = false;
            btn_02.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_02.ForeColor = SystemColors.ControlText;
            btn_02.Location = new Point(530, 109);
            btn_02.Name = "btn_02";
            btn_02.Size = new Size(100, 92);
            btn_02.TabIndex = 16;
            btn_02.UseVisualStyleBackColor = false;
            btn_02.Click += btn_02_Click;
            // 
            // btn_10
            // 
            btn_10.Enabled = false;
            btn_10.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_10.ForeColor = SystemColors.ControlText;
            btn_10.Location = new Point(318, 204);
            btn_10.Name = "btn_10";
            btn_10.Size = new Size(100, 92);
            btn_10.TabIndex = 17;
            btn_10.UseVisualStyleBackColor = false;
            btn_10.Click += btn_10_Click;
            // 
            // btn_11
            // 
            btn_11.Enabled = false;
            btn_11.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_11.ForeColor = SystemColors.ControlText;
            btn_11.Location = new Point(424, 204);
            btn_11.Name = "btn_11";
            btn_11.Size = new Size(100, 92);
            btn_11.TabIndex = 18;
            btn_11.UseVisualStyleBackColor = false;
            btn_11.Click += btn_11_Click;
            // 
            // btn_12
            // 
            btn_12.Enabled = false;
            btn_12.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_12.ForeColor = SystemColors.ControlText;
            btn_12.Location = new Point(530, 204);
            btn_12.Name = "btn_12";
            btn_12.Size = new Size(100, 92);
            btn_12.TabIndex = 19;
            btn_12.UseVisualStyleBackColor = false;
            btn_12.Click += btn_12_Click;
            // 
            // btn_20
            // 
            btn_20.Enabled = false;
            btn_20.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_20.ForeColor = SystemColors.ControlText;
            btn_20.Location = new Point(318, 300);
            btn_20.Name = "btn_20";
            btn_20.Size = new Size(100, 92);
            btn_20.TabIndex = 20;
            btn_20.UseVisualStyleBackColor = false;
            btn_20.Click += btn_20_Click;
            // 
            // btn_21
            // 
            btn_21.Enabled = false;
            btn_21.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_21.ForeColor = SystemColors.ControlText;
            btn_21.Location = new Point(424, 300);
            btn_21.Name = "btn_21";
            btn_21.Size = new Size(100, 92);
            btn_21.TabIndex = 21;
            btn_21.UseVisualStyleBackColor = false;
            btn_21.Click += btn_21_Click;
            // 
            // btn_22
            // 
            btn_22.Enabled = false;
            btn_22.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_22.ForeColor = SystemColors.ControlText;
            btn_22.Location = new Point(530, 300);
            btn_22.Name = "btn_22";
            btn_22.Size = new Size(100, 92);
            btn_22.TabIndex = 22;
            btn_22.UseVisualStyleBackColor = false;
            btn_22.Click += btn_22_Click;
            // 
            // label_currentPlayer1
            // 
            label_currentPlayer1.Enabled = false;
            label_currentPlayer1.Location = new Point(318, 90);
            label_currentPlayer1.Name = "label_currentPlayer1";
            label_currentPlayer1.Size = new Size(100, 15);
            label_currentPlayer1.TabIndex = 23;
            label_currentPlayer1.Text = "Ugur";
            label_currentPlayer1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_currentPlayer2
            // 
            label_currentPlayer2.Enabled = false;
            label_currentPlayer2.Location = new Point(530, 90);
            label_currentPlayer2.Name = "label_currentPlayer2";
            label_currentPlayer2.RightToLeft = RightToLeft.No;
            label_currentPlayer2.Size = new Size(100, 16);
            label_currentPlayer2.TabIndex = 24;
            label_currentPlayer2.Text = "Meric";
            label_currentPlayer2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_CurrentGame
            // 
            label_CurrentGame.Enabled = false;
            label_CurrentGame.Location = new Point(424, 90);
            label_CurrentGame.Name = "label_CurrentGame";
            label_CurrentGame.Size = new Size(100, 15);
            label_CurrentGame.TabIndex = 25;
            label_CurrentGame.Text = "VS";
            label_CurrentGame.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_splitter
            // 
            btn_splitter.BackColor = SystemColors.ActiveBorder;
            btn_splitter.Enabled = false;
            btn_splitter.Location = new Point(302, 8);
            btn_splitter.Name = "btn_splitter";
            btn_splitter.Size = new Size(10, 384);
            btn_splitter.TabIndex = 26;
            btn_splitter.UseVisualStyleBackColor = false;
            // 
            // btn_Accept
            // 
            btn_Accept.Enabled = false;
            btn_Accept.Location = new Point(71, 109);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(58, 23);
            btn_Accept.TabIndex = 27;
            btn_Accept.Text = "Accept Game";
            btn_Accept.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 398);
            Controls.Add(btn_Accept);
            Controls.Add(btn_splitter);
            Controls.Add(label_CurrentGame);
            Controls.Add(label_currentPlayer2);
            Controls.Add(label_currentPlayer1);
            Controls.Add(btn_22);
            Controls.Add(btn_21);
            Controls.Add(btn_20);
            Controls.Add(btn_12);
            Controls.Add(btn_11);
            Controls.Add(btn_10);
            Controls.Add(btn_02);
            Controls.Add(btn_01);
            Controls.Add(btn_00);
            Controls.Add(label_Notification);
            Controls.Add(btn_Dissconnect);
            Controls.Add(btn_Queue);
            Controls.Add(btn_Join);
            Controls.Add(btn_Connect);
            Controls.Add(dataGridView_Leaderboard);
            Controls.Add(richTextBox_Log);
            Controls.Add(textBox_Port);
            Controls.Add(textBox_IP);
            Controls.Add(textBox_Name);
            Controls.Add(label_Leaderboard);
            Controls.Add(label_Port);
            Controls.Add(label_IP);
            Controls.Add(label_Name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "TicTacToe Client";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Leaderboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label_IP;
        private Label label_Port;
        private Label label_Leaderboard;
        private TextBox textBox_Name;
        private TextBox textBox_IP;
        private TextBox textBox_Port;
        private RichTextBox richTextBox_Log;
        private DataGridView dataGridView_Leaderboard;
        private Button btn_Connect;
        private Button btn_Join;
        private Button btn_Queue;
        private Button btn_Dissconnect;
        private Label label_Notification;
        private Button btn_00;
        private Button btn_01;
        private Button btn_02;
        private Button btn_10;
        private Button btn_11;
        private Button btn_12;
        private Button btn_20;
        private Button btn_21;
        private Button btn_22;
        private Label label_currentPlayer1;
        private Label label_currentPlayer2;
        private Label label_CurrentGame;
        private Button btn_splitter;
        private Button btn_Accept;
    }
}