namespace F_160722001_160722001_FinalProject_
{
    partial class FormHighestScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHighestScore));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHighestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.Font = new System.Drawing.Font("ROG Fonts", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Bisque;
            this.buttonBack.Location = new System.Drawing.Point(146, 358);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 80);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHighestScore
            // 
            this.labelHighestScore.AutoSize = true;
            this.labelHighestScore.BackColor = System.Drawing.Color.Transparent;
            this.labelHighestScore.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighestScore.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelHighestScore.Location = new System.Drawing.Point(53, 109);
            this.labelHighestScore.Name = "labelHighestScore";
            this.labelHighestScore.Size = new System.Drawing.Size(322, 36);
            this.labelHighestScore.TabIndex = 20;
            this.labelHighestScore.Text = "Highest score";
            // 
            // FormHighestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.labelHighestScore);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormHighestScore";
            this.Text = "Form Highest Score";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHighestScore;
    }
}