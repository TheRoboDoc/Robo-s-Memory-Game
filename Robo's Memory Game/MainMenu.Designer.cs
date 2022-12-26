namespace Robo_s_Memory_Game
{
    partial class MainMenu
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
            this.Play = new System.Windows.Forms.Button();
            this.GameName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.EntryPointControls = new System.Windows.Forms.Panel();
            this.ModeSelection = new System.Windows.Forms.Panel();
            this.Single = new System.Windows.Forms.Button();
            this.Versus = new System.Windows.Forms.Button();
            this.PlayerSelectionSinglePlayer = new System.Windows.Forms.Panel();
            this.Confirm = new System.Windows.Forms.Button();
            this.PlayerSelect = new System.Windows.Forms.ComboBox();
            this.PlayerNameSelectionText = new System.Windows.Forms.Label();
            this.PlayerInfo = new System.Windows.Forms.ListBox();
            this.NewNameLable = new System.Windows.Forms.Label();
            this.NameEntryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EntryPointControls.SuspendLayout();
            this.ModeSelection.SuspendLayout();
            this.PlayerSelectionSinglePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Play.Location = new System.Drawing.Point(36, 93);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(200, 50);
            this.Play.TabIndex = 0;
            this.Play.TabStop = false;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.Location = new System.Drawing.Point(255, 9);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(282, 31);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Robo\'s Memory Game";
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Location = new System.Drawing.Point(36, 161);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 50);
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EntryPointControls
            // 
            this.EntryPointControls.Controls.Add(this.Exit);
            this.EntryPointControls.Controls.Add(this.Play);
            this.EntryPointControls.Location = new System.Drawing.Point(261, 43);
            this.EntryPointControls.Name = "EntryPointControls";
            this.EntryPointControls.Size = new System.Drawing.Size(266, 300);
            this.EntryPointControls.TabIndex = 4;
            // 
            // ModeSelection
            // 
            this.ModeSelection.Controls.Add(this.Versus);
            this.ModeSelection.Controls.Add(this.Single);
            this.ModeSelection.Location = new System.Drawing.Point(185, 136);
            this.ModeSelection.Name = "ModeSelection";
            this.ModeSelection.Size = new System.Drawing.Size(432, 118);
            this.ModeSelection.TabIndex = 3;
            this.ModeSelection.Visible = false;
            // 
            // Single
            // 
            this.Single.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Single.Location = new System.Drawing.Point(11, 2);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(200, 50);
            this.Single.TabIndex = 1;
            this.Single.TabStop = false;
            this.Single.Text = "Single";
            this.Single.UseVisualStyleBackColor = true;
            this.Single.Click += new System.EventHandler(this.Single_Click);
            // 
            // Versus
            // 
            this.Versus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Versus.Location = new System.Drawing.Point(217, 2);
            this.Versus.Name = "Versus";
            this.Versus.Size = new System.Drawing.Size(200, 50);
            this.Versus.TabIndex = 2;
            this.Versus.TabStop = false;
            this.Versus.Text = "Versus";
            this.Versus.UseVisualStyleBackColor = true;
            this.Versus.Click += new System.EventHandler(this.Versus_Click);
            // 
            // PlayerSelectionSinglePlayer
            // 
            this.PlayerSelectionSinglePlayer.Controls.Add(this.button2);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.button1);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.NameEntryTextBox);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.NewNameLable);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.PlayerInfo);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.PlayerNameSelectionText);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.PlayerSelect);
            this.PlayerSelectionSinglePlayer.Controls.Add(this.Confirm);
            this.PlayerSelectionSinglePlayer.Location = new System.Drawing.Point(12, 43);
            this.PlayerSelectionSinglePlayer.Name = "PlayerSelectionSinglePlayer";
            this.PlayerSelectionSinglePlayer.Size = new System.Drawing.Size(760, 306);
            this.PlayerSelectionSinglePlayer.TabIndex = 4;
            this.PlayerSelectionSinglePlayer.Visible = false;
            this.PlayerSelectionSinglePlayer.VisibleChanged += new System.EventHandler(this.PlayerSelectionSinglePlayer_VisibleChanged);
            // 
            // Confirm
            // 
            this.Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Confirm.Location = new System.Drawing.Point(557, 245);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(200, 50);
            this.Confirm.TabIndex = 2;
            this.Confirm.TabStop = false;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // PlayerSelect
            // 
            this.PlayerSelect.FormattingEnabled = true;
            this.PlayerSelect.Location = new System.Drawing.Point(3, 30);
            this.PlayerSelect.Name = "PlayerSelect";
            this.PlayerSelect.Size = new System.Drawing.Size(171, 21);
            this.PlayerSelect.TabIndex = 3;
            this.PlayerSelect.Text = "New Player";
            this.PlayerSelect.SelectedIndexChanged += new System.EventHandler(this.PlayerSelect_SelectedIndexChanged);
            // 
            // PlayerNameSelectionText
            // 
            this.PlayerNameSelectionText.AutoSize = true;
            this.PlayerNameSelectionText.Location = new System.Drawing.Point(0, 14);
            this.PlayerNameSelectionText.Name = "PlayerNameSelectionText";
            this.PlayerNameSelectionText.Size = new System.Drawing.Size(39, 13);
            this.PlayerNameSelectionText.TabIndex = 4;
            this.PlayerNameSelectionText.Text = "Player:";
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.FormattingEnabled = true;
            this.PlayerInfo.Items.AddRange(new object[] {
            "Name:\t\t",
            "Playertime:\t",
            "W/L:\t\t",
            "High Score:\t",
            "",
            "",
            "Match History:"});
            this.PlayerInfo.Location = new System.Drawing.Point(3, 57);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(548, 238);
            this.PlayerInfo.TabIndex = 5;
            // 
            // NewNameLable
            // 
            this.NewNameLable.AutoSize = true;
            this.NewNameLable.Location = new System.Drawing.Point(184, 14);
            this.NewNameLable.Name = "NewNameLable";
            this.NewNameLable.Size = new System.Drawing.Size(35, 13);
            this.NewNameLable.TabIndex = 6;
            this.NewNameLable.Text = "Name";
            // 
            // NameEntryTextBox
            // 
            this.NameEntryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEntryTextBox.Location = new System.Drawing.Point(187, 30);
            this.NameEntryTextBox.Name = "NameEntryTextBox";
            this.NameEntryTextBox.Size = new System.Drawing.Size(364, 21);
            this.NameEntryTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(557, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(557, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 9;
            this.button2.TabStop = false;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.PlayerSelectionSinglePlayer);
            this.Controls.Add(this.ModeSelection);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.EntryPointControls);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.EntryPointControls.ResumeLayout(false);
            this.ModeSelection.ResumeLayout(false);
            this.PlayerSelectionSinglePlayer.ResumeLayout(false);
            this.PlayerSelectionSinglePlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel EntryPointControls;
        private System.Windows.Forms.Panel ModeSelection;
        private System.Windows.Forms.Button Versus;
        private System.Windows.Forms.Button Single;
        private System.Windows.Forms.Panel PlayerSelectionSinglePlayer;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label PlayerNameSelectionText;
        private System.Windows.Forms.ComboBox PlayerSelect;
        private System.Windows.Forms.ListBox PlayerInfo;
        private System.Windows.Forms.TextBox NameEntryTextBox;
        private System.Windows.Forms.Label NewNameLable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}