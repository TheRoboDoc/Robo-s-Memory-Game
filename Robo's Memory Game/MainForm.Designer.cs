namespace Robo_s_Memory_Game
{
    partial class MainForm
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
            this.BackGroundImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGroundImage
            // 
            this.BackGroundImage.BackColor = System.Drawing.Color.Transparent;
            this.BackGroundImage.Image = global::Robo_s_Memory_Game.Properties.Resources.BackgroundImage1;
            this.BackGroundImage.Location = new System.Drawing.Point(0, 0);
            this.BackGroundImage.Name = "BackGroundImage";
            this.BackGroundImage.Size = new System.Drawing.Size(854, 480);
            this.BackGroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGroundImage.TabIndex = 0;
            this.BackGroundImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 484);
            this.Controls.Add(this.BackGroundImage);
            this.MaximumSize = new System.Drawing.Size(1200, 523);
            this.MinimumSize = new System.Drawing.Size(1200, 523);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BackGroundImage;
    }
}

