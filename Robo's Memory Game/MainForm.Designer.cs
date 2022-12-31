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
            this.components = new System.ComponentModel.Container();
            this.SinglePlayerInfoPanel = new System.Windows.Forms.Panel();
            this.PlayTimeDisplay = new System.Windows.Forms.Label();
            this.ExitPlay = new System.Windows.Forms.Button();
            this.BestScore = new System.Windows.Forms.Label();
            this.BestScoreLable = new System.Windows.Forms.Label();
            this.PlayerNameLable = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.BackGroundImage = new System.Windows.Forms.PictureBox();
            this.SinglePlayerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SinglePlayerInfoPanel
            // 
            this.SinglePlayerInfoPanel.Controls.Add(this.PlayTimeDisplay);
            this.SinglePlayerInfoPanel.Controls.Add(this.ExitPlay);
            this.SinglePlayerInfoPanel.Controls.Add(this.BestScore);
            this.SinglePlayerInfoPanel.Controls.Add(this.BestScoreLable);
            this.SinglePlayerInfoPanel.Controls.Add(this.PlayerNameLable);
            this.SinglePlayerInfoPanel.Controls.Add(this.CurrentScore);
            this.SinglePlayerInfoPanel.Controls.Add(this.ScoreLable);
            this.SinglePlayerInfoPanel.Location = new System.Drawing.Point(860, 0);
            this.SinglePlayerInfoPanel.Name = "SinglePlayerInfoPanel";
            this.SinglePlayerInfoPanel.Size = new System.Drawing.Size(312, 472);
            this.SinglePlayerInfoPanel.TabIndex = 1;
            this.SinglePlayerInfoPanel.Visible = false;
            this.SinglePlayerInfoPanel.VisibleChanged += new System.EventHandler(this.SinglePlayerInfoPanel_VisibleChanged);
            // 
            // PlayTimeDisplay
            // 
            this.PlayTimeDisplay.AutoSize = true;
            this.PlayTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayTimeDisplay.Location = new System.Drawing.Point(238, 9);
            this.PlayTimeDisplay.Name = "PlayTimeDisplay";
            this.PlayTimeDisplay.Size = new System.Drawing.Size(71, 20);
            this.PlayTimeDisplay.TabIndex = 6;
            this.PlayTimeDisplay.Text = "00:00:00";
            // 
            // ExitPlay
            // 
            this.ExitPlay.Location = new System.Drawing.Point(159, 420);
            this.ExitPlay.Name = "ExitPlay";
            this.ExitPlay.Size = new System.Drawing.Size(150, 52);
            this.ExitPlay.TabIndex = 5;
            this.ExitPlay.Text = "Main Menu";
            this.ExitPlay.UseVisualStyleBackColor = true;
            this.ExitPlay.Click += new System.EventHandler(this.ExitPlay_Click);
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScore.Location = new System.Drawing.Point(114, 49);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(18, 20);
            this.BestScore.TabIndex = 4;
            this.BestScore.Text = "0";
            // 
            // BestScoreLable
            // 
            this.BestScoreLable.AutoSize = true;
            this.BestScoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScoreLable.Location = new System.Drawing.Point(3, 49);
            this.BestScoreLable.Name = "BestScoreLable";
            this.BestScoreLable.Size = new System.Drawing.Size(112, 20);
            this.BestScoreLable.TabIndex = 3;
            this.BestScoreLable.Text = "Best Score     :";
            // 
            // PlayerNameLable
            // 
            this.PlayerNameLable.AutoSize = true;
            this.PlayerNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLable.Location = new System.Drawing.Point(3, 9);
            this.PlayerNameLable.Name = "PlayerNameLable";
            this.PlayerNameLable.Size = new System.Drawing.Size(87, 20);
            this.PlayerNameLable.TabIndex = 2;
            this.PlayerNameLable.Text = "New Player";
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentScore.Location = new System.Drawing.Point(114, 29);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(18, 20);
            this.CurrentScore.TabIndex = 1;
            this.CurrentScore.Text = "0";
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLable.Location = new System.Drawing.Point(3, 29);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(116, 20);
            this.ScoreLable.TabIndex = 0;
            this.ScoreLable.Text = "Current Score: ";
            // 
            // PlayTimer
            // 
            this.PlayTimer.Interval = 1000;
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
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
            this.Controls.Add(this.SinglePlayerInfoPanel);
            this.Controls.Add(this.BackGroundImage);
            this.MaximumSize = new System.Drawing.Size(1200, 523);
            this.MinimumSize = new System.Drawing.Size(1200, 523);
            this.Name = "MainForm";
            this.Text = "Robo\'s Memory Gane | Play";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SinglePlayerInfoPanel.ResumeLayout(false);
            this.SinglePlayerInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BackGroundImage;
        private System.Windows.Forms.Panel SinglePlayerInfoPanel;
        private System.Windows.Forms.Label PlayerNameLable;
        private System.Windows.Forms.Label CurrentScore;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Label BestScore;
        private System.Windows.Forms.Label BestScoreLable;
        private System.Windows.Forms.Button ExitPlay;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.Label PlayTimeDisplay;
    }
}

