namespace CaroLAN_v2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Panel_ChessBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCaroGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutDevTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_TurnFor = new System.Windows.Forms.Label();
            this.pictureBox_GuestTurn = new System.Windows.Forms.PictureBox();
            this.pictureBox_MainTurn = new System.Windows.Forms.PictureBox();
            this.label_player2_score = new System.Windows.Forms.Label();
            this.label_player1_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coolDownBar = new System.Windows.Forms.ProgressBar();
            this.GuestICON = new System.Windows.Forms.PictureBox();
            this.MainICON = new System.Windows.Forms.PictureBox();
            this.label_NameGuest = new System.Windows.Forms.Label();
            this.label_NameMain = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_expand = new System.Windows.Forms.Button();
            this.timer_Message = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GuestTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainICON)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_ChessBoard
            // 
            this.Panel_ChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_ChessBoard.Location = new System.Drawing.Point(9, 29);
            this.Panel_ChessBoard.Name = "Panel_ChessBoard";
            this.Panel_ChessBoard.Size = new System.Drawing.Size(699, 626);
            this.Panel_ChessBoard.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMatchToolStripMenuItem,
            this.QuitGameToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // NewMatchToolStripMenuItem
            // 
            this.NewMatchToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.newgame;
            this.NewMatchToolStripMenuItem.Name = "NewMatchToolStripMenuItem";
            this.NewMatchToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.NewMatchToolStripMenuItem.Text = "New match";
            this.NewMatchToolStripMenuItem.Click += new System.EventHandler(this.NewMatchToolStripMenuItem_Click);
            // 
            // QuitGameToolStripMenuItem
            // 
            this.QuitGameToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.exit;
            this.QuitGameToolStripMenuItem.Name = "QuitGameToolStripMenuItem";
            this.QuitGameToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.QuitGameToolStripMenuItem.Text = "Quit";
            this.QuitGameToolStripMenuItem.Click += new System.EventHandler(this.QuitGameToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutCaroGameToolStripMenuItem,
            this.AboutDevTeamToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // AboutCaroGameToolStripMenuItem
            // 
            this.AboutCaroGameToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.gamerules;
            this.AboutCaroGameToolStripMenuItem.Name = "AboutCaroGameToolStripMenuItem";
            this.AboutCaroGameToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.AboutCaroGameToolStripMenuItem.Text = "Game Rules";
            this.AboutCaroGameToolStripMenuItem.Click += new System.EventHandler(this.AboutCaroGameToolStripMenuItem_Click);
            // 
            // AboutDevTeamToolStripMenuItem
            // 
            this.AboutDevTeamToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.about;
            this.AboutDevTeamToolStripMenuItem.Name = "AboutDevTeamToolStripMenuItem";
            this.AboutDevTeamToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.AboutDevTeamToolStripMenuItem.Text = "About DevTeam";
            this.AboutDevTeamToolStripMenuItem.Click += new System.EventHandler(this.AboutDevTeamToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label_TurnFor);
            this.panel1.Controls.Add(this.pictureBox_GuestTurn);
            this.panel1.Controls.Add(this.pictureBox_MainTurn);
            this.panel1.Controls.Add(this.label_player2_score);
            this.panel1.Controls.Add(this.label_player1_score);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.coolDownBar);
            this.panel1.Controls.Add(this.GuestICON);
            this.panel1.Controls.Add(this.MainICON);
            this.panel1.Controls.Add(this.label_NameGuest);
            this.panel1.Controls.Add(this.label_NameMain);
            this.panel1.Location = new System.Drawing.Point(9, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 104);
            this.panel1.TabIndex = 3;
            // 
            // label_TurnFor
            // 
            this.label_TurnFor.Location = new System.Drawing.Point(281, 78);
            this.label_TurnFor.Name = "label_TurnFor";
            this.label_TurnFor.Size = new System.Drawing.Size(143, 20);
            this.label_TurnFor.TabIndex = 13;
            this.label_TurnFor.Text = "Opponent turn!";
            this.label_TurnFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TurnFor.UseCompatibleTextRendering = true;
            // 
            // pictureBox_GuestTurn
            // 
            this.pictureBox_GuestTurn.Location = new System.Drawing.Point(564, 1);
            this.pictureBox_GuestTurn.Name = "pictureBox_GuestTurn";
            this.pictureBox_GuestTurn.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_GuestTurn.TabIndex = 12;
            this.pictureBox_GuestTurn.TabStop = false;
            // 
            // pictureBox_MainTurn
            // 
            this.pictureBox_MainTurn.Location = new System.Drawing.Point(110, 0);
            this.pictureBox_MainTurn.Name = "pictureBox_MainTurn";
            this.pictureBox_MainTurn.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_MainTurn.TabIndex = 11;
            this.pictureBox_MainTurn.TabStop = false;
            // 
            // label_player2_score
            // 
            this.label_player2_score.AutoSize = true;
            this.label_player2_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_player2_score.Location = new System.Drawing.Point(392, 11);
            this.label_player2_score.Name = "label_player2_score";
            this.label_player2_score.Size = new System.Drawing.Size(32, 36);
            this.label_player2_score.TabIndex = 10;
            this.label_player2_score.Text = "1";
            // 
            // label_player1_score
            // 
            this.label_player1_score.AutoSize = true;
            this.label_player1_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_player1_score.Location = new System.Drawing.Point(283, 11);
            this.label_player1_score.Name = "label_player1_score";
            this.label_player1_score.Size = new System.Drawing.Size(32, 36);
            this.label_player1_score.TabIndex = 9;
            this.label_player1_score.Text = "0";
            this.label_player1_score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // coolDownBar
            // 
            this.coolDownBar.Location = new System.Drawing.Point(242, 50);
            this.coolDownBar.Maximum = 1500;
            this.coolDownBar.Name = "coolDownBar";
            this.coolDownBar.Size = new System.Drawing.Size(217, 23);
            this.coolDownBar.TabIndex = 7;
            // 
            // GuestICON
            // 
            this.GuestICON.BackColor = System.Drawing.SystemColors.Control;
            this.GuestICON.Location = new System.Drawing.Point(604, 0);
            this.GuestICON.Name = "GuestICON";
            this.GuestICON.Size = new System.Drawing.Size(95, 95);
            this.GuestICON.TabIndex = 6;
            this.GuestICON.TabStop = false;
            // 
            // MainICON
            // 
            this.MainICON.BackColor = System.Drawing.SystemColors.Control;
            this.MainICON.Location = new System.Drawing.Point(0, 0);
            this.MainICON.Name = "MainICON";
            this.MainICON.Size = new System.Drawing.Size(95, 95);
            this.MainICON.TabIndex = 5;
            this.MainICON.TabStop = false;
            // 
            // label_NameGuest
            // 
            this.label_NameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameGuest.Location = new System.Drawing.Point(465, 38);
            this.label_NameGuest.Name = "label_NameGuest";
            this.label_NameGuest.Size = new System.Drawing.Size(130, 50);
            this.label_NameGuest.TabIndex = 4;
            this.label_NameGuest.Text = "label1";
            this.label_NameGuest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_NameMain
            // 
            this.label_NameMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameMain.Location = new System.Drawing.Point(106, 38);
            this.label_NameMain.Name = "label_NameMain";
            this.label_NameMain.Size = new System.Drawing.Size(130, 50);
            this.label_NameMain.TabIndex = 3;
            this.label_NameMain.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_expand
            // 
            this.button_expand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_expand.Location = new System.Drawing.Point(712, 291);
            this.button_expand.Name = "button_expand";
            this.button_expand.Size = new System.Drawing.Size(15, 140);
            this.button_expand.TabIndex = 4;
            this.button_expand.Tag = "Open";
            this.button_expand.UseVisualStyleBackColor = true;
            this.button_expand.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // timer_Message
            // 
            this.timer_Message.Interval = 1;
            this.timer_Message.Tick += new System.EventHandler(this.timer_Message_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox_message);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_Type);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(670, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 727);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.Location = new System.Drawing.Point(11, 26);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_message.Size = new System.Drawing.Size(326, 600);
            this.richTextBox_message.TabIndex = 3;
            this.richTextBox_message.Text = "";
            this.richTextBox_message.TextChanged += new System.EventHandler(this.richTextBox_message_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(277, 643);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(61, 72);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(11, 643);
            this.textBox_Type.Multiline = true;
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(260, 72);
            this.textBox_Type.TabIndex = 0;
            this.textBox_Type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Type_KeyDown);
            // 
            // panel_cover
            // 
            this.panel_cover.Location = new System.Drawing.Point(704, 29);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(28, 736);
            this.panel_cover.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_ChessBoard);
            this.Controls.Add(this.button_expand);
            this.Controls.Add(this.panel_cover);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Caro Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GuestTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainICON)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_ChessBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutCaroGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutDevTeamToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_NameGuest;
        public System.Windows.Forms.Label label_NameMain;
        public System.Windows.Forms.PictureBox GuestICON;
        public System.Windows.Forms.PictureBox MainICON;
        private System.Windows.Forms.ProgressBar coolDownBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_player2_score;
        private System.Windows.Forms.Label label_player1_score;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox_GuestTurn;
        public System.Windows.Forms.PictureBox pictureBox_MainTurn;
        public System.Windows.Forms.Label label_TurnFor;
        private System.Windows.Forms.Button button_expand;
        private System.Windows.Forms.Timer timer_Message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.RichTextBox richTextBox_message;
    }
}