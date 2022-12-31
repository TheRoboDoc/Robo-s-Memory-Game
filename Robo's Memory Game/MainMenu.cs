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
            PlayerSelectionVersus.Visible = true;
            ModeSelection.Visible = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FileManager.FileCheck();
        }

        FileManager.Player player;
        FileManager.Player playerTwo;

        MainForm.GameMode gameMode = new MainForm.GameMode();

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

            gameMode = MainForm.GameMode.Single;
        }

        private void ConfirmVersus_Click(object sender, EventArgs e)
        {
            if(PlayerOneSelection.Text == "New Player" || PlayerTwoSelection.Text == "New Player")
            {
                ConfirmVersusWarning.Text = "*Please create a player or \n select other player than \"New Player\"";
                ConfirmVersusWarning.Visible = true;
                return;
            }
            else if (PlayerOneSelection.Text == PlayerTwoSelection.Text)
            {
                ConfirmVersusWarning.Text = "*Player one and player two\n cannot be the same player";
                ConfirmVersusWarning.Visible = true;
                return;
            }
            else
            {
                ConfirmVersusWarning.Visible = false;
            }

            player = FileManager.FindPlayerWithName(PlayerOneSelection.Text);
            playerTwo = FileManager.FindPlayerWithName(PlayerTwoSelection.Text);

            PlayerSelectionVersus.Visible = false;
            ImageSelectionPanel.Visible = true;

            gameMode = MainForm.GameMode.Versus;
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

            LoadPlayerDataToPlayerInfo(newPlayer, PlayerInfo);
        }

        private void PlayerSelectionVersus_VisibleChanged(object sender, EventArgs e)
        {
            List<FileManager.Player> playerList = FileManager.LoadPlayerData();

            FileManager.Player newPlayer = new FileManager.Player();

            PlayerOneSelection.Items.Clear();
            PlayerTwoSelection.Items.Clear();

            foreach(FileManager.Player player in playerList)
            {
                PlayerOneSelection.Items.Add(player.name);
                PlayerTwoSelection.Items.Add(player.name);
            }

            foreach(FileManager.Player player in playerList)
            {
                if(player.name == "New Player")
                {
                    newPlayer = player;
                    break;
                }
            }

            LoadPlayerDataToPlayerInfo(newPlayer, PlayerOneInfoList);
            LoadPlayerDataToPlayerInfo(newPlayer, PlayerTwoInfoList);
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
        private void LoadPlayerDataToPlayerInfo(FileManager.Player player, ListBox listBox)
        {
            ResetPlayerInfo(listBox);

            listBox.Items[namePos] += player.name;
            listBox.Items[playerTimePos] += player.playTime.ToString();
            listBox.Items[winToLoseRatioPos] += player.winToLoseRatio.ToString();
            listBox.Items[highScorePos] += player.highScore.ToString();

            if (player.matchHistory == null) return;


            foreach (FileManager.Match match in player.matchHistory)
            {
                listBox.Items.Add("----------------------------------------------------");
                listBox.Items.Add($"Match Date:\t{match.mathDate.ToShortDateString()}");
                listBox.Items.Add($"Match Type:\t{match.matchType}");
                listBox.Items.Add($"Grid Size:\t\t{match.gridSize}");

                if (match.matchType == "Versus")
                {
                    listBox.Items.Add($"Players:\t\t{match.playerNames[0]} vs {match.playerNames[1]}");
                    listBox.Items.Add($"Winnder:\t\t{match.winnersName}");
                }
            }
        }

        /// <summary>
        /// Resets the player info display to default values
        /// </summary>
        private void ResetPlayerInfo(ListBox listBox)
        {
            listBox.Items.Clear();

            listBox.Items.Add("Name:\t\t");
            listBox.Items.Add("Playtime:\t\t");
            listBox.Items.Add("W/L:\t\t");
            listBox.Items.Add("High Score:\t");
            listBox.Items.Add("Match History:");
        }

        private void PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            ListBox listBox = new ListBox();

            string selectedPlayerName = "";

            switch (comboBox.Name)
            {
                case "PlayerSelect":
                    selectedPlayerName = PlayerSelect.SelectedItem.ToString();
                    listBox = PlayerInfo;
                    break;

                case "PlayerOneSelection":
                    selectedPlayerName = PlayerOneSelection.SelectedItem.ToString();
                    listBox = PlayerOneInfoList;
                    break;

                case "PlayerTwoSelection":
                    selectedPlayerName = PlayerTwoSelection.SelectedItem.ToString();
                    listBox = PlayerTwoInfoList;
                    break;

                default:
                    throw new Exception("Couldn't get the correct selection to use");
            }

            FileManager.Player selectedPlayer = FileManager.FindPlayerWithName(selectedPlayerName);

            LoadPlayerDataToPlayerInfo(selectedPlayer, listBox);
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

        private void SaveLeft_Click(object sender, EventArgs e)
        {
            string newPlayerName = PlayerOneNameEntry.Text;

            if (string.IsNullOrEmpty(newPlayerName))
            {
                NameWarningLeft.Visible = true;
                NameWarningLeft.Text = "*Name cannot be empty";
                return;
            }
            else
            {
                NameWarningLeft.Visible = false;
            }

            FileManager.Player newPlayer = new FileManager.Player();

            newPlayer.name = newPlayerName;

            FileManager.SavePlayerData(newPlayer);

            PlayerOneSelection.Items.Add(newPlayer.name);
            PlayerOneSelection.SelectedItem = newPlayer.name;

            PlayerTwoSelection.Items.Add(newPlayer.name);
        }

        private void SaveRight_Click(object sender, EventArgs e)
        {
            string newPlayerName = PlayerTwoNameEntry.Text;

            if (string.IsNullOrEmpty(newPlayerName))
            {
                NameWarningRight.Visible = true;
                NameWarningRight.Text = "*Name cannot be empty";
                return;
            }
            else
            {
                NameWarningRight.Visible = false;
            }

            FileManager.Player newPlayer = new FileManager.Player();

            newPlayer.name = newPlayerName;

            FileManager.SavePlayerData(newPlayer);

            PlayerTwoSelection.Items.Add(newPlayer.name);
            PlayerTwoSelection.SelectedItem = newPlayer.name;

            PlayerOneSelection.Items.Add(newPlayer.name);
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

        private void DeleteLeft_Click(object sender, EventArgs e)
        {
            if(PlayerOneSelection.Text == "New Player")
            {
                DeleteWarningLeft.Visible = true;
                DeleteWarningLeft.Text = "*Cannot delete \n default \"New Player\" entry";
                return;
            }
            else
            {
                DeleteWarningLeft.Visible = false;
            }

            FileManager.DeletePlayerWithName(PlayerOneSelection.SelectedItem.ToString());

            if(PlayerOneSelection.SelectedItem == PlayerTwoSelection.SelectedItem)
            {
                PlayerTwoSelection.SelectedIndex = 0;
            }

            PlayerOneSelection.Items.Remove(PlayerOneSelection.SelectedItem);
            PlayerTwoSelection.Items.Remove(PlayerTwoSelection.SelectedItem);

            PlayerOneSelection.SelectedIndex = 0;
        }

        private void DeleteRight_Click(object sender, EventArgs e)
        {
            if (PlayerTwoSelection.Text == "New Player")
            {
                DeleteWarningRight.Visible = true;
                DeleteWarningRight.Text = "*Cannot delete \n default \"New Player\" entry";
                return;
            }
            else
            {
                DeleteWarningRight.Visible = false;
            }

            FileManager.DeletePlayerWithName(PlayerOneSelection.SelectedItem.ToString());

            if (PlayerTwoSelection.SelectedItem == PlayerOneSelection.SelectedItem)
            {
                PlayerOneSelection.SelectedIndex = 0;
            }

            PlayerOneSelection.Items.Remove(PlayerOneSelection.SelectedItem);
            PlayerTwoSelection.Items.Remove(PlayerTwoSelection.SelectedItem);

            PlayerOneSelection.SelectedIndex = 0;
        }

        /// <summary>
        /// Resetting menus to starting position
        /// </summary>
        private void ReturnToMain_Click(object sender, EventArgs e)
        {
            PlayerSelectionSinglePlayer.Visible = false;
            PlayerSelectionVersus.Visible = false;
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


            MainForm mainForm = new MainForm(gameMode, player, SelectedImageShow.Image, gridSize, playerTwo);

            this.Visible = false;

            mainForm.Owner = this;

            mainForm.ShowDialog();
        }

        
    }
}