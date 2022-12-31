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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SinglePlayerInfoPanel = new System.Windows.Forms.Panel();
            this.PlayTimeDisplay = new System.Windows.Forms.Label();
            this.ExitPlay = new System.Windows.Forms.Button();
            this.BestScore = new System.Windows.Forms.Label();
            this.BestScoreLable = new System.Windows.Forms.Label();
            this.PlayerNameLable = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.VersusPlayerInfoPanel = new System.Windows.Forms.Panel();
            this.VersusTimeDisplay = new System.Windows.Forms.Label();
            this.MainMenuVersus = new System.Windows.Forms.Button();
            this.PlayerOneBestScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerOneName = new System.Windows.Forms.Label();
            this.PlayerOneCurrentScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerTwoBestScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlayerTwoName = new System.Windows.Forms.Label();
            this.PlayerTwoCurrentScore = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TurnLable = new System.Windows.Forms.Label();
            this.BackGroundImage = new System.Windows.Forms.PictureBox();
            this.SinglePlayerInfoPanel.SuspendLayout();
            this.VersusPlayerInfoPanel.SuspendLayout();
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
            // VersusPlayerInfoPanel
            // 
            this.VersusPlayerInfoPanel.Controls.Add(this.TurnLable);
            this.VersusPlayerInfoPanel.Controls.Add(this.PlayerTwoBestScore);
            this.VersusPlayerInfoPanel.Controls.Add(this.label8);
            this.VersusPlayerInfoPanel.Controls.Add(this.PlayerTwoName);
            this.VersusPlayerInfoPanel.Controls.Add(this.PlayerTwoCurrentScore);
            this.VersusPlayerInfoPanel.Controls.Add(this.label11);
            this.VersusPlayerInfoPanel.Controls.Add(this.VersusTimeDisplay);
            this.VersusPlayerInfoPanel.Controls.Add(this.MainMenuVersus);
            this.VersusPlayerInfoPanel.Controls.Add(this.PlayerOneBestScore);
            this.VersusPlayerInfoPanel.Controls.Add(this.label3);
            this.VersusPlayerInfoPanel.Controls.Add(this.PlayerOneName);
            this.VersusPlayerInfoPanel.Controls.Add(this.PlayerOneCurrentScore);
            this.VersusPlayerInfoPanel.Controls.Add(this.label6);
            this.VersusPlayerInfoPanel.Location = new System.Drawing.Point(857, 0);
            this.VersusPlayerInfoPanel.Name = "VersusPlayerInfoPanel";
            this.VersusPlayerInfoPanel.Size = new System.Drawing.Size(312, 472);
            this.VersusPlayerInfoPanel.TabIndex = 7;
            this.VersusPlayerInfoPanel.Visible = false;
            this.VersusPlayerInfoPanel.VisibleChanged += new System.EventHandler(this.VersusPlayerInfoPanel_VisibleChanged);
            // 
            // VersusTimeDisplay
            // 
            this.VersusTimeDisplay.AutoSize = true;
            this.VersusTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusTimeDisplay.Location = new System.Drawing.Point(238, 9);
            this.VersusTimeDisplay.Name = "VersusTimeDisplay";
            this.VersusTimeDisplay.Size = new System.Drawing.Size(71, 20);
            this.VersusTimeDisplay.TabIndex = 6;
            this.VersusTimeDisplay.Text = "00:00:00";
            // 
            // MainMenuVersus
            // 
            this.MainMenuVersus.Location = new System.Drawing.Point(159, 420);
            this.MainMenuVersus.Name = "MainMenuVersus";
            this.MainMenuVersus.Size = new System.Drawing.Size(150, 52);
            this.MainMenuVersus.TabIndex = 5;
            this.MainMenuVersus.Text = "Main Menu";
            this.MainMenuVersus.UseVisualStyleBackColor = true;
            this.MainMenuVersus.Click += new System.EventHandler(this.ExitPlay_Click);
            // 
            // PlayerOneBestScore
            // 
            this.PlayerOneBestScore.AutoSize = true;
            this.PlayerOneBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneBestScore.Location = new System.Drawing.Point(114, 49);
            this.PlayerOneBestScore.Name = "PlayerOneBestScore";
            this.PlayerOneBestScore.Size = new System.Drawing.Size(18, 20);
            this.PlayerOneBestScore.TabIndex = 4;
            this.PlayerOneBestScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Best Score     :";
            // 
            // PlayerOneName
            // 
            this.PlayerOneName.AutoSize = true;
            this.PlayerOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneName.Location = new System.Drawing.Point(3, 9);
            this.PlayerOneName.Name = "PlayerOneName";
            this.PlayerOneName.Size = new System.Drawing.Size(87, 20);
            this.PlayerOneName.TabIndex = 2;
            this.PlayerOneName.Text = "New Player";
            // 
            // PlayerOneCurrentScore
            // 
            this.PlayerOneCurrentScore.AutoSize = true;
            this.PlayerOneCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneCurrentScore.Location = new System.Drawing.Point(114, 29);
            this.PlayerOneCurrentScore.Name = "PlayerOneCurrentScore";
            this.PlayerOneCurrentScore.Size = new System.Drawing.Size(18, 20);
            this.PlayerOneCurrentScore.TabIndex = 1;
            this.PlayerOneCurrentScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Score: ";
            // 
            // PlayerTwoBestScore
            // 
            this.PlayerTwoBestScore.AutoSize = true;
            this.PlayerTwoBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoBestScore.Location = new System.Drawing.Point(117, 133);
            this.PlayerTwoBestScore.Name = "PlayerTwoBestScore";
            this.PlayerTwoBestScore.Size = new System.Drawing.Size(18, 20);
            this.PlayerTwoBestScore.TabIndex = 11;
            this.PlayerTwoBestScore.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Best Score     :";
            // 
            // PlayerTwoName
            // 
            this.PlayerTwoName.AutoSize = true;
            this.PlayerTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoName.Location = new System.Drawing.Point(6, 93);
            this.PlayerTwoName.Name = "PlayerTwoName";
            this.PlayerTwoName.Size = new System.Drawing.Size(87, 20);
            this.PlayerTwoName.TabIndex = 9;
            this.PlayerTwoName.Text = "New Player";
            // 
            // PlayerTwoCurrentScore
            // 
            this.PlayerTwoCurrentScore.AutoSize = true;
            this.PlayerTwoCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoCurrentScore.Location = new System.Drawing.Point(117, 113);
            this.PlayerTwoCurrentScore.Name = "PlayerTwoCurrentScore";
            this.PlayerTwoCurrentScore.Size = new System.Drawing.Size(18, 20);
            this.PlayerTwoCurrentScore.TabIndex = 8;
            this.PlayerTwoCurrentScore.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Current Score: ";
            // 
            // TurnLable
            // 
            this.TurnLable.AutoSize = true;
            this.TurnLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLable.Location = new System.Drawing.Point(6, 164);
            this.TurnLable.Name = "TurnLable";
            this.TurnLable.Size = new System.Drawing.Size(60, 24);
            this.TurnLable.TabIndex = 12;
            this.TurnLable.Text = "label1";
            this.TurnLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 484);
            this.Controls.Add(this.VersusPlayerInfoPanel);
            this.Controls.Add(this.SinglePlayerInfoPanel);
            this.Controls.Add(this.BackGroundImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 523);
            this.MinimumSize = new System.Drawing.Size(1200, 523);
            this.Name = "MainForm";
            this.Text = "Robo\'s Memory Gane | Play";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SinglePlayerInfoPanel.ResumeLayout(false);
            this.SinglePlayerInfoPanel.PerformLayout();
            this.VersusPlayerInfoPanel.ResumeLayout(false);
            this.VersusPlayerInfoPanel.PerformLayout();
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
        private System.Windows.Forms.Panel VersusPlayerInfoPanel;
        private System.Windows.Forms.Label VersusTimeDisplay;
        private System.Windows.Forms.Button MainMenuVersus;
        private System.Windows.Forms.Label PlayerOneBestScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlayerOneName;
        private System.Windows.Forms.Label PlayerOneCurrentScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PlayerTwoBestScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PlayerTwoName;
        private System.Windows.Forms.Label PlayerTwoCurrentScore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TurnLable;
    }
}

