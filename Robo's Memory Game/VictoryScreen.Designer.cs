namespace Robo_s_Memory_Game
{
    partial class VictoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictoryScreen));
            this.VictoryText = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BestScoreLable = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.BestScore = new System.Windows.Forms.Label();
            this.WinnerLable = new System.Windows.Forms.Label();
            this.WinnerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VictoryText
            // 
            this.VictoryText.AutoSize = true;
            this.VictoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictoryText.Location = new System.Drawing.Point(12, 9);
            this.VictoryText.Name = "VictoryText";
            this.VictoryText.Size = new System.Drawing.Size(79, 26);
            this.VictoryText.TabIndex = 0;
            this.VictoryText.Text = "Victory";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(189, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(161, 52);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(189, 70);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(161, 52);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BestScoreLable
            // 
            this.BestScoreLable.AutoSize = true;
            this.BestScoreLable.Location = new System.Drawing.Point(14, 51);
            this.BestScoreLable.Name = "BestScoreLable";
            this.BestScoreLable.Size = new System.Drawing.Size(59, 13);
            this.BestScoreLable.TabIndex = 3;
            this.BestScoreLable.Text = "BestScore:";
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.Location = new System.Drawing.Point(14, 35);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(59, 13);
            this.ScoreLable.TabIndex = 4;
            this.ScoreLable.Text = "Score       :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(79, 35);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(13, 13);
            this.Score.TabIndex = 5;
            this.Score.Text = "0";
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.Location = new System.Drawing.Point(79, 51);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(13, 13);
            this.BestScore.TabIndex = 6;
            this.BestScore.Text = "0";
            // 
            // WinnerLable
            // 
            this.WinnerLable.AutoSize = true;
            this.WinnerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLable.Location = new System.Drawing.Point(14, 79);
            this.WinnerLable.Name = "WinnerLable";
            this.WinnerLable.Size = new System.Drawing.Size(59, 18);
            this.WinnerLable.TabIndex = 7;
            this.WinnerLable.Text = "Winner:";
            // 
            // WinnerName
            // 
            this.WinnerName.AutoSize = true;
            this.WinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerName.Location = new System.Drawing.Point(14, 97);
            this.WinnerName.Name = "WinnerName";
            this.WinnerName.Size = new System.Drawing.Size(17, 18);
            this.WinnerName.TabIndex = 8;
            this.WinnerName.Text = "0";
            // 
            // VictoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 133);
            this.Controls.Add(this.WinnerName);
            this.Controls.Add(this.WinnerLable);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ScoreLable);
            this.Controls.Add(this.BestScoreLable);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.VictoryText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VictoryScreen";
            this.Text = "Robo\'s Memory Gane | VictoryScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VictoryScreen_FormClosing);
            this.Load += new System.EventHandler(this.VictoryScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VictoryText;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label BestScoreLable;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label BestScore;
        private System.Windows.Forms.Label WinnerLable;
        private System.Windows.Forms.Label WinnerName;
    }
}