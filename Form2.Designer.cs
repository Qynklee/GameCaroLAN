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
            this.vánMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềCaroGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềDevTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coolDownBar = new System.Windows.Forms.ProgressBar();
            this.GuestICON = new System.Windows.Forms.PictureBox();
            this.MainICON = new System.Windows.Forms.PictureBox();
            this.label_NameGuest = new System.Windows.Forms.Label();
            this.label_NameMain = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Player1_score = new System.Windows.Forms.Label();
            this.Player2_score = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainICON)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(720, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vánMớiToolStripMenuItem,
            this.thoátGameToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // vánMớiToolStripMenuItem
            // 
            this.vánMớiToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.newgame;
            this.vánMớiToolStripMenuItem.Name = "vánMớiToolStripMenuItem";
            this.vánMớiToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.vánMớiToolStripMenuItem.Text = "Ván mới";
            this.vánMớiToolStripMenuItem.Click += new System.EventHandler(this.vánMớiToolStripMenuItem_Click);
            // 
            // thoátGameToolStripMenuItem
            // 
            this.thoátGameToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.exit;
            this.thoátGameToolStripMenuItem.Name = "thoátGameToolStripMenuItem";
            this.thoátGameToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.thoátGameToolStripMenuItem.Text = "Thoát Game";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềCaroGameToolStripMenuItem,
            this.vềDevTeamToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // vềCaroGameToolStripMenuItem
            // 
            this.vềCaroGameToolStripMenuItem.Name = "vềCaroGameToolStripMenuItem";
            this.vềCaroGameToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.vềCaroGameToolStripMenuItem.Text = "Luật chơi";
            // 
            // vềDevTeamToolStripMenuItem
            // 
            this.vềDevTeamToolStripMenuItem.Image = global::CaroLAN_v2.Resource1.about;
            this.vềDevTeamToolStripMenuItem.Name = "vềDevTeamToolStripMenuItem";
            this.vềDevTeamToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.vềDevTeamToolStripMenuItem.Text = "Về DevTeam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Player2_score);
            this.panel1.Controls.Add(this.Player1_score);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.coolDownBar);
            this.panel1.Controls.Add(this.GuestICON);
            this.panel1.Controls.Add(this.MainICON);
            this.panel1.Controls.Add(this.label_NameGuest);
            this.panel1.Controls.Add(this.label_NameMain);
            this.panel1.Location = new System.Drawing.Point(9, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 95);
            this.panel1.TabIndex = 3;
            // 
            // coolDownBar
            // 
            this.coolDownBar.Location = new System.Drawing.Point(241, 55);
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
            this.label_NameGuest.AutoSize = true;
            this.label_NameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameGuest.Location = new System.Drawing.Point(538, 41);
            this.label_NameGuest.Name = "label_NameGuest";
            this.label_NameGuest.Size = new System.Drawing.Size(60, 24);
            this.label_NameGuest.TabIndex = 4;
            this.label_NameGuest.Text = "label1";
            this.label_NameGuest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_NameMain
            // 
            this.label_NameMain.AutoSize = true;
            this.label_NameMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameMain.Location = new System.Drawing.Point(101, 41);
            this.label_NameMain.Name = "label_NameMain";
            this.label_NameMain.Size = new System.Drawing.Size(60, 24);
            this.label_NameMain.TabIndex = 3;
            this.label_NameMain.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Player1_score
            // 
            this.Player1_score.AutoSize = true;
            this.Player1_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_score.Location = new System.Drawing.Point(283, 11);
            this.Player1_score.Name = "Player1_score";
            this.Player1_score.Size = new System.Drawing.Size(32, 36);
            this.Player1_score.TabIndex = 9;
            this.Player1_score.Text = "0";
            this.Player1_score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Player2_score
            // 
            this.Player2_score.AutoSize = true;
            this.Player2_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_score.Location = new System.Drawing.Point(392, 11);
            this.Player2_score.Name = "Player2_score";
            this.Player2_score.Size = new System.Drawing.Size(32, 36);
            this.Player2_score.TabIndex = 10;
            this.Player2_score.Text = "1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_ChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Caro Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainICON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_ChessBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vánMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềCaroGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềDevTeamToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_NameGuest;
        public System.Windows.Forms.Label label_NameMain;
        public System.Windows.Forms.PictureBox GuestICON;
        public System.Windows.Forms.PictureBox MainICON;
        private System.Windows.Forms.ProgressBar coolDownBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Player2_score;
        private System.Windows.Forms.Label Player1_score;
        private System.Windows.Forms.Label label1;
    }
}