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

        private void Confirm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.Owner = this;

            mainForm.ShowDialog();
        }

        /// <summary>
        /// When new player is selected in player selection dropbox
        /// </summary>
        private void PlayerSelectionSinglePlayer_VisibleChanged(object sender, EventArgs e)
        {
            List<FileManager.Player> playerList = FileManager.LoadPlayerData();

            FileManager.Player newPlayer = new FileManager.Player();

            foreach (FileManager.Player player in playerList)
            {
                PlayerSelect.Items.Add(player.name);
            }

            foreach (FileManager.Player player in playerList)
            {
                if(player.name == "New Player")
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
        int matchHistoryPos = 6;

        /// <summary>
        /// Loads player data to the player info display
        /// </summary>
        /// <param name="player"></param>
        private void LoadPlayerDataToPlayerInfo(FileManager.Player player)
        {
            ResetPlayerInfo();

            PlayerInfo.Items[namePos] += player.name;
            PlayerInfo.Items[playerTimePos] += player.playTime.TotalHours.ToString();
            PlayerInfo.Items[winToLoseRatioPos] += player.winToLoseRatio.ToString();
            PlayerInfo.Items[highScorePos] += player.highScore.ToString();
            PlayerInfo.Items[matchHistoryPos] += $"\n{player.matchHistory}";
        }

        /// <summary>
        /// Resets the player info display to default values
        /// </summary>
        private void ResetPlayerInfo()
        {
            PlayerInfo.ResetText();

            PlayerInfo.Items[namePos] = "Name:\t\t";
            PlayerInfo.Items[playerTimePos] = "Playtime:\t\t";
            PlayerInfo.Items[winToLoseRatioPos] = "W/L:\t\t";
            PlayerInfo.Items[highScorePos] = "High Score:\t";
            PlayerInfo.Items[matchHistoryPos] = "Match History:";
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

            if(string.IsNullOrEmpty(newPlayerName))
            {
                NameWarningText.Visible = true;
                NameWarningText.Text = "*Name cannot be empty";
                return;
            }

            FileManager.Player newPlayer = new FileManager.Player();

            newPlayer.name = newPlayerName;

            FileManager.SavePlayerData(newPlayer);

            PlayerSelect.Items.Add(newPlayer.name);
            PlayerSelect.SelectedItem = newPlayer.name;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            FileManager.DeletePlayerWithName(PlayerSelect.SelectedItem.ToString());

            PlayerSelect.Items.Remove(PlayerSelect.SelectedItem);

            PlayerSelect.SelectedIndex = 0;
        }
    }
}
