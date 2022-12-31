using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robo_s_Memory_Game
{
    /// <summary>
    /// Main menu form
    /// </summary>
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            EntryPointControls.Visible = false;
            ModeSelection.Visible = true;
            ReturnToMain.Visible = true;
        }

        private void Single_Click(object sender, EventArgs e)
        {
            PlayerSelectionSinglePlayer.Visible = true;
            ModeSelection.Visible = false;
        }

        private void Versus_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FileManager.FileCheck();
        }

        FileManager.Player player;

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(PlayerSelect.Text == "New Player")
            {
                ConfirmWarning.Text = "*Please create a player or \n select other player than \"New Player\"";
                ConfirmWarning.Visible = true;
                return;
            }
            else
            {
                ConfirmWarning.Visible = false;
            }

            player = FileManager.FindPlayerWithName(PlayerSelect.SelectedItem.ToString());

            PlayerSelectionSinglePlayer.Visible = false;
            ImageSelectionPanel.Visible = true;
        }

        /// <summary>
        /// When the single player player selection screen is opened
        /// </summary>
        private void PlayerSelectionSinglePlayer_VisibleChanged(object sender, EventArgs e)
        {
            List<FileManager.Player> playerList = FileManager.LoadPlayerData();

            FileManager.Player newPlayer = new FileManager.Player();

            PlayerSelect.Items.Clear();

            foreach (FileManager.Player player in playerList)
            {
                PlayerSelect.Items.Add(player.name);
            }

            foreach (FileManager.Player player in playerList)
            {
                if (player.name == "New Player")
                {
                    newPlayer = player;
                    break;
                }
            }

            LoadPlayerDataToPlayerInfo(newPlayer);
        }

        //Indexes of player info entries
        int namePos = 0;
        int playerTimePos = 1;
        int winToLoseRatioPos = 2;
        int highScorePos = 3;

        /// <summary>
        /// Loads player data to the player info display
        /// </summary>
        /// <param name="player"></param>
        private void LoadPlayerDataToPlayerInfo(FileManager.Player player)
        {
            ResetPlayerInfo();

            PlayerInfo.Items[namePos] += player.name;
            PlayerInfo.Items[playerTimePos] += player.playTime.ToString();
            PlayerInfo.Items[winToLoseRatioPos] += player.winToLoseRatio.ToString();
            PlayerInfo.Items[highScorePos] += player.highScore.ToString();

            if (player.matchHistory == null) return;


            foreach (FileManager.Match match in player.matchHistory)
            {
                PlayerInfo.Items.Add("----------------------------------------------------");
                PlayerInfo.Items.Add($"Match Date:\t{match.mathDate.ToShortDateString()}");
                PlayerInfo.Items.Add($"Match Type:\t{match.matchType}");
                PlayerInfo.Items.Add($"Grid Size:\t\t{match.gridSize}");

                if (match.matchType == "Versus")
                {
                    PlayerInfo.Items.Add($"Players:\t\t{match.playerNames[0]} vs {match.playerNames[1]}");
                    PlayerInfo.Items.Add($"Winnder:\t\t{match.winnersName}");
                }
            }
        }

        /// <summary>
        /// Resets the player info display to default values
        /// </summary>
        private void ResetPlayerInfo()
        {
            PlayerInfo.Items.Clear();

            PlayerInfo.Items.Add("Name:\t\t");
            PlayerInfo.Items.Add("Playtime:\t\t");
            PlayerInfo.Items.Add("W/L:\t\t");
            PlayerInfo.Items.Add("High Score:\t");
            PlayerInfo.Items.Add("Match History:");
        }

        private void PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlayerName = PlayerSelect.SelectedItem.ToString();

            FileManager.Player selectedPlayer = FileManager.FindPlayerWithName(selectedPlayerName);

            LoadPlayerDataToPlayerInfo(selectedPlayer);
        }

        /// <summary>
        /// Save a new player with a entered name
        /// </summary>
        private void Save_Click(object sender, EventArgs e)
        {
            string newPlayerName = NameEntryTextBox.Text;

            if (string.IsNullOrEmpty(newPlayerName))
            {
                NameWarningText.Visible = true;
                NameWarningText.Text = "*Name cannot be empty";
                return;
            }
            else
            {
                NameWarningText.Visible = false;
            }

            FileManager.Player newPlayer = new FileManager.Player();

            newPlayer.name = newPlayerName;

            FileManager.SavePlayerData(newPlayer);

            PlayerSelect.Items.Add(newPlayer.name);
            PlayerSelect.SelectedItem = newPlayer.name;
        }

        /// <summary>
        /// Deletes the player entry currently selected
        /// </summary>
        private void Delete_Click(object sender, EventArgs e)
        {
            if(PlayerSelect.Text == "New Player")
            {
                DeleteWarning.Visible = true;
                DeleteWarning.Text = "*Cannot delete \n default \"New Player\" entry";
                return;
            }
            else
            {
                DeleteWarning.Visible = false;
            }

            FileManager.DeletePlayerWithName(PlayerSelect.SelectedItem.ToString());

            PlayerSelect.Items.Remove(PlayerSelect.SelectedItem);

            PlayerSelect.SelectedIndex = 0;
        }

        /// <summary>
        /// Resetting menus to starting position
        /// </summary>
        private void ReturnToMain_Click(object sender, EventArgs e)
        {
            PlayerSelectionSinglePlayer.Visible = false;
            ModeSelection.Visible = false;
            ReturnToMain.Visible = false;
            ImageSelectionPanel.Visible = false;
            EntryPointControls.Visible = true;
        }

        /// <summary>
        /// Loading of a custom background image
        /// </summary>
        private void LoadCustomImage_Click(object sender, EventArgs e)
        {
            string filePath;

            if(SelectCustomImageDialog.ShowDialog() == DialogResult.OK )
            {
                filePath = SelectCustomImageDialog.FileName;

                try
                {
                    SelectedImageShow.Image = Image.FromFile(filePath);
                    pictureBox16.Image = SelectedImageShow.Image;
                    SelectedImageWarningLable.Visible = false;
                }
                catch
                {
                    SelectedImageWarningLable.Visible = true;
                    SelectedImageWarningLable.Text = "*Failed to load the image";
                }
                
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox selectedImage = (PictureBox)sender;

            SelectedImageShow.Image = selectedImage.Image;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(SelectedImageShow.Image == null)
            {
                SelectedImageWarningLable.Visible = true;
                SelectedImageWarningLable.Text = "*Please select an image";

                return;
            }
            else
            {
                SelectedImageWarningLable.Visible = false;
            }

            int gridSize;

            if(!int.TryParse(GridSizeTextBox.Text, out gridSize))
            {
                GridSizeWarning.Visible = true;
                GridSizeWarning.Text =
                    "*Invalid size:\n" +
                    " Size must be between 4 and 30";
                return;
            }
            else if(gridSize < 4 || gridSize > 30)
            {
                GridSizeWarning.Visible = true;
                GridSizeWarning.Text =
                    "*Invalid size:\n" +
                    " Size must be between 4 and 30";
                return;
            }
            else if(gridSize % 2 != 0)
            {
                GridSizeWarning.Visible = true;
                GridSizeWarning.Text =
                    "*Invalid size:\n" +
                    " Grid size must be divisible by 2";
                return;
            }
            else
            {
                GridSizeWarning.Visible = false;
            }


            MainForm mainForm = new MainForm(MainForm.GameMode.Single, player, SelectedImageShow.Image, gridSize);

            this.Visible = false;

            mainForm.Owner = this;

            mainForm.ShowDialog();
        }
    }
}