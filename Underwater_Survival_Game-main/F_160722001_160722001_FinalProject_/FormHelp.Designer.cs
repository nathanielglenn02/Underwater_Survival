namespace F_160722001_160722001_FinalProject_
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.MaximumSize = new System.Drawing.Size(814, 814);
            this.label1.MinimumSize = new System.Drawing.Size(814, 814);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 814);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Press Space Button to Jump.\r\n- Avoid the collision between your character and \r" +
    "\nthe ground and also the pipe.\r\n- You can click restart button to replay the gam" +
    "e.\r\n";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.Font = new System.Drawing.Font("ROG Fonts", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Bisque;
            this.buttonBack.Location = new System.Drawing.Point(282, 503);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 80);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(300, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 56);
            this.label2.TabIndex = 15;
            this.label2.Text = "HELP";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
    }
}