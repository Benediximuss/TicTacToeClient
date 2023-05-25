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
            btn_Disconnect = new Button();
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
            btn_clearLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Leaderboard).BeginInit();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Enabled = false;
            label_Name.Location = new Point(5, 99);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(56, 20);
            label_Name.TabIndex = 0;
            label_Name.Text = "Name :";
            // 
            // label_IP
            // 
            label_IP.AutoSize = true;
            label_IP.Location = new Point(30, 11);
            label_IP.Name = "label_IP";
            label_IP.Size = new Size(28, 20);
            label_IP.TabIndex = 1;
            label_IP.Text = "IP :";
            // 
            // label_Port
            // 
            label_Port.AutoSize = true;
            label_Port.Location = new Point(16, 49);
            label_Port.Name = "label_Port";
            label_Port.Size = new Size(42, 20);
            label_Port.TabIndex = 2;
            label_Port.Text = "Port :";
            // 
            // label_Leaderboard
            // 
            label_Leaderboard.AutoSize = true;
            label_Leaderboard.Enabled = false;
            label_Leaderboard.Location = new Point(363, 8);
            label_Leaderboard.Name = "label_Leaderboard";
            label_Leaderboard.Size = new Size(94, 20);
            label_Leaderboard.TabIndex = 3;
            label_Leaderboard.Text = "Leaderboard";
            // 
            // textBox_Name
            // 
            textBox_Name.Enabled = false;
            textBox_Name.Location = new Point(63, 95);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(105, 27);
            textBox_Name.TabIndex = 4;
            // 
            // textBox_IP
            // 
            textBox_IP.Location = new Point(64, 11);
            textBox_IP.Name = "textBox_IP";
            textBox_IP.Size = new Size(181, 27);
            textBox_IP.TabIndex = 5;
            // 
            // textBox_Port
            // 
            textBox_Port.Location = new Point(64, 45);
            textBox_Port.Name = "textBox_Port";
            textBox_Port.Size = new Size(53, 27);
            textBox_Port.TabIndex = 6;
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.BackColor = SystemColors.ControlLightLight;
            richTextBox_Log.Location = new Point(11, 247);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.ReadOnly = true;
            richTextBox_Log.Size = new Size(326, 275);
            richTextBox_Log.TabIndex = 7;
            richTextBox_Log.Text = "";
            // 
            // dataGridView_Leaderboard
            // 
            dataGridView_Leaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Leaderboard.Enabled = false;
            dataGridView_Leaderboard.Location = new Point(363, 31);
            dataGridView_Leaderboard.Name = "dataGridView_Leaderboard";
            dataGridView_Leaderboard.RowHeadersWidth = 51;
            dataGridView_Leaderboard.RowTemplate.Height = 29;
            dataGridView_Leaderboard.Size = new Size(357, 80);
            dataGridView_Leaderboard.TabIndex = 8;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(125, 44);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(123, 31);
            btn_Connect.TabIndex = 9;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Join
            // 
            btn_Join.Enabled = false;
            btn_Join.Location = new Point(175, 93);
            btn_Join.Margin = new Padding(3, 4, 3, 4);
            btn_Join.Name = "btn_Join";
            btn_Join.Size = new Size(73, 31);
            btn_Join.TabIndex = 10;
            btn_Join.Text = "Join";
            btn_Join.UseVisualStyleBackColor = true;
            btn_Join.Click += btn_Join_Click;
            // 
            // btn_Queue
            // 
            btn_Queue.Enabled = false;
            btn_Queue.Location = new Point(14, 145);
            btn_Queue.Margin = new Padding(3, 4, 3, 4);
            btn_Queue.Name = "btn_Queue";
            btn_Queue.Size = new Size(66, 31);
            btn_Queue.TabIndex = 11;
            btn_Queue.Text = "Queue";
            btn_Queue.UseVisualStyleBackColor = true;
            btn_Queue.Click += btn_Queue_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Enabled = false;
            btn_Disconnect.Location = new Point(157, 145);
            btn_Disconnect.Margin = new Padding(3, 4, 3, 4);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(91, 31);
            btn_Disconnect.TabIndex = 12;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // label_Notification
            // 
            label_Notification.Location = new Point(11, 180);
            label_Notification.Name = "label_Notification";
            label_Notification.Size = new Size(326, 64);
            label_Notification.TabIndex = 13;
            label_Notification.Text = "Notification Panel";
            label_Notification.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_00
            // 
            btn_00.Enabled = false;
            btn_00.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_00.ForeColor = SystemColors.ControlText;
            btn_00.Location = new Point(363, 153);
            btn_00.Margin = new Padding(3, 4, 3, 4);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(114, 123);
            btn_00.TabIndex = 14;
            btn_00.UseVisualStyleBackColor = false;
            btn_00.Click += btn_00_Click;
            // 
            // btn_01
            // 
            btn_01.Enabled = false;
            btn_01.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_01.ForeColor = SystemColors.ControlText;
            btn_01.Location = new Point(485, 153);
            btn_01.Margin = new Padding(3, 4, 3, 4);
            btn_01.Name = "btn_01";
            btn_01.Size = new Size(114, 123);
            btn_01.TabIndex = 15;
            btn_01.UseVisualStyleBackColor = false;
            btn_01.Click += btn_01_Click;
            // 
            // btn_02
            // 
            btn_02.Enabled = false;
            btn_02.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_02.ForeColor = SystemColors.ControlText;
            btn_02.Location = new Point(606, 154);
            btn_02.Margin = new Padding(3, 4, 3, 4);
            btn_02.Name = "btn_02";
            btn_02.Size = new Size(114, 123);
            btn_02.TabIndex = 16;
            btn_02.UseVisualStyleBackColor = false;
            btn_02.Click += btn_02_Click;
            // 
            // btn_10
            // 
            btn_10.Enabled = false;
            btn_10.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_10.ForeColor = SystemColors.ControlText;
            btn_10.Location = new Point(363, 281);
            btn_10.Margin = new Padding(3, 4, 3, 4);
            btn_10.Name = "btn_10";
            btn_10.Size = new Size(114, 123);
            btn_10.TabIndex = 17;
            btn_10.UseVisualStyleBackColor = false;
            btn_10.Click += btn_10_Click;
            // 
            // btn_11
            // 
            btn_11.Enabled = false;
            btn_11.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_11.ForeColor = SystemColors.ControlText;
            btn_11.Location = new Point(485, 281);
            btn_11.Margin = new Padding(3, 4, 3, 4);
            btn_11.Name = "btn_11";
            btn_11.Size = new Size(114, 123);
            btn_11.TabIndex = 18;
            btn_11.UseVisualStyleBackColor = false;
            btn_11.Click += btn_11_Click;
            // 
            // btn_12
            // 
            btn_12.Enabled = false;
            btn_12.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_12.ForeColor = SystemColors.ControlText;
            btn_12.Location = new Point(606, 281);
            btn_12.Margin = new Padding(3, 4, 3, 4);
            btn_12.Name = "btn_12";
            btn_12.Size = new Size(114, 123);
            btn_12.TabIndex = 19;
            btn_12.UseVisualStyleBackColor = false;
            btn_12.Click += btn_12_Click;
            // 
            // btn_20
            // 
            btn_20.Enabled = false;
            btn_20.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_20.ForeColor = SystemColors.ControlText;
            btn_20.Location = new Point(363, 409);
            btn_20.Margin = new Padding(3, 4, 3, 4);
            btn_20.Name = "btn_20";
            btn_20.Size = new Size(114, 123);
            btn_20.TabIndex = 20;
            btn_20.UseVisualStyleBackColor = false;
            btn_20.Click += btn_20_Click;
            // 
            // btn_21
            // 
            btn_21.Enabled = false;
            btn_21.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_21.ForeColor = SystemColors.ControlText;
            btn_21.Location = new Point(485, 409);
            btn_21.Margin = new Padding(3, 4, 3, 4);
            btn_21.Name = "btn_21";
            btn_21.Size = new Size(114, 123);
            btn_21.TabIndex = 21;
            btn_21.UseVisualStyleBackColor = false;
            btn_21.Click += btn_21_Click;
            // 
            // btn_22
            // 
            btn_22.Enabled = false;
            btn_22.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_22.ForeColor = SystemColors.ControlText;
            btn_22.Location = new Point(606, 409);
            btn_22.Margin = new Padding(3, 4, 3, 4);
            btn_22.Name = "btn_22";
            btn_22.Size = new Size(114, 123);
            btn_22.TabIndex = 22;
            btn_22.UseVisualStyleBackColor = false;
            btn_22.Click += btn_22_Click;
            // 
            // label_currentPlayer1
            // 
            label_currentPlayer1.Enabled = false;
            label_currentPlayer1.Location = new Point(363, 129);
            label_currentPlayer1.Name = "label_currentPlayer1";
            label_currentPlayer1.Size = new Size(114, 20);
            label_currentPlayer1.TabIndex = 23;
            label_currentPlayer1.Text = "Ugur";
            label_currentPlayer1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_currentPlayer2
            // 
            label_currentPlayer2.Enabled = false;
            label_currentPlayer2.Location = new Point(606, 129);
            label_currentPlayer2.Name = "label_currentPlayer2";
            label_currentPlayer2.RightToLeft = RightToLeft.No;
            label_currentPlayer2.Size = new Size(114, 21);
            label_currentPlayer2.TabIndex = 24;
            label_currentPlayer2.Text = "Meric";
            label_currentPlayer2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_CurrentGame
            // 
            label_CurrentGame.Enabled = false;
            label_CurrentGame.Location = new Point(485, 129);
            label_CurrentGame.Name = "label_CurrentGame";
            label_CurrentGame.Size = new Size(114, 20);
            label_CurrentGame.TabIndex = 25;
            label_CurrentGame.Text = "VS";
            label_CurrentGame.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_splitter
            // 
            btn_splitter.BackColor = SystemColors.ActiveBorder;
            btn_splitter.Enabled = false;
            btn_splitter.Location = new Point(345, 11);
            btn_splitter.Margin = new Padding(3, 4, 3, 4);
            btn_splitter.Name = "btn_splitter";
            btn_splitter.Size = new Size(12, 546);
            btn_splitter.TabIndex = 26;
            btn_splitter.UseVisualStyleBackColor = false;
            // 
            // btn_Accept
            // 
            btn_Accept.Enabled = false;
            btn_Accept.Location = new Point(81, 145);
            btn_Accept.Margin = new Padding(3, 4, 3, 4);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(66, 31);
            btn_Accept.TabIndex = 27;
            btn_Accept.Text = "Accept Game";
            btn_Accept.UseVisualStyleBackColor = true;
            btn_Accept.Click += btn_Accept_Click;
            // 
            // btn_clearLog
            // 
            btn_clearLog.Location = new Point(11, 528);
            btn_clearLog.Name = "btn_clearLog";
            btn_clearLog.Size = new Size(326, 29);
            btn_clearLog.TabIndex = 28;
            btn_clearLog.Text = "Clear log";
            btn_clearLog.UseVisualStyleBackColor = true;
            btn_clearLog.Click += btn_clearLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 567);
            Controls.Add(btn_clearLog);
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
            Controls.Add(btn_Disconnect);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private Button btn_Disconnect;
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
        private Button btn_clearLog;
    }
}