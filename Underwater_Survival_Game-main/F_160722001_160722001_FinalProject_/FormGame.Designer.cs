namespace F_160722001_160722001_FinalProject_
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.labelScore = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBird = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelScoreGameOver = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Bisque;
            this.labelScore.Location = new System.Drawing.Point(12, 633);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(118, 39);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score : ";
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick_1);
            // 
            // pictureBoxBird
            // 
            this.pictureBoxBird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBird.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBird.Image")));
            this.pictureBoxBird.Location = new System.Drawing.Point(98, 236);
            this.pictureBoxBird.Name = "pictureBoxBird";
            this.pictureBoxBird.Size = new System.Drawing.Size(94, 90);
            this.pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird.TabIndex = 0;
            this.pictureBoxBird.TabStop = false;
            // 
            // pictureBoxPipeTop
            // 
            this.pictureBoxPipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipeTop.Image")));
            this.pictureBoxPipeTop.Location = new System.Drawing.Point(536, -5);
            this.pictureBoxPipeTop.Name = "pictureBoxPipeTop";
            this.pictureBoxPipeTop.Size = new System.Drawing.Size(160, 233);
            this.pictureBoxPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeTop.TabIndex = 3;
            this.pictureBoxPipeTop.TabStop = false;
            // 
            // pictureBoxPipeBottom
            // 
            this.pictureBoxPipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipeBottom.Image")));
            this.pictureBoxPipeBottom.Location = new System.Drawing.Point(317, 394);
            this.pictureBoxPipeBottom.Name = "pictureBoxPipeBottom";
            this.pictureBoxPipeBottom.Size = new System.Drawing.Size(189, 227);
            this.pictureBoxPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeBottom.TabIndex = 2;
            this.pictureBoxPipeBottom.TabStop = false;
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGround.Image")));
            this.pictureBoxGround.Location = new System.Drawing.Point(-5, 592);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(805, 144);
            this.pictureBoxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGround.TabIndex = 1;
            this.pictureBoxGround.TabStop = false;
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToMenu.BackgroundImage")));
            this.buttonBackToMenu.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenu.ForeColor = System.Drawing.Color.Bisque;
            this.buttonBackToMenu.Location = new System.Drawing.Point(44, 495);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(180, 80);
            this.buttonBackToMenu.TabIndex = 21;
            this.buttonBackToMenu.Text = "Back To Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Bisque;
            this.buttonExit.Location = new System.Drawing.Point(580, 495);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 80);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelScoreGameOver
            // 
            this.labelScoreGameOver.AutoSize = true;
            this.labelScoreGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreGameOver.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreGameOver.ForeColor = System.Drawing.Color.Bisque;
            this.labelScoreGameOver.Location = new System.Drawing.Point(208, 343);
            this.labelScoreGameOver.Name = "labelScoreGameOver";
            this.labelScoreGameOver.Size = new System.Drawing.Size(163, 34);
            this.labelScoreGameOver.TabIndex = 18;
            this.labelScoreGameOver.Text = "Score : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(589, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxGameOver
            // 
            this.pictureBoxGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGameOver.Image")));
            this.pictureBoxGameOver.Location = new System.Drawing.Point(84, 34);
            this.pictureBoxGameOver.Name = "pictureBoxGameOver";
            this.pictureBoxGameOver.Size = new System.Drawing.Size(631, 425);
            this.pictureBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameOver.TabIndex = 16;
            this.pictureBoxGameOver.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 681);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelScoreGameOver);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxGameOver);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxPipeBottom);
            this.Controls.Add(this.pictureBoxBird);
            this.Controls.Add(this.pictureBoxPipeTop);
            this.Controls.Add(this.pictureBoxGround);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBird;
        private System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.PictureBox pictureBoxPipeBottom;
        private System.Windows.Forms.PictureBox pictureBoxPipeTop;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelScoreGameOver;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxGameOver;
    }
}

