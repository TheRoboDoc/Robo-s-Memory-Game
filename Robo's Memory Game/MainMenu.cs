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

        int namePos = 0;
        int playerTimePos = 1;
        int winToLoseRatioPos = 2;
        int highScorePos = 3;
        int matchHistoryPos = 6;

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

            PlayerInfo.Items[namePos] += newPlayer.name;
            PlayerInfo.Items[playerTimePos] += newPlayer.playTime.TotalHours.ToString();
            PlayerInfo.Items[winToLoseRatioPos] += newPlayer.winToLoseRatio.ToString();
            PlayerInfo.Items[highScorePos] += newPlayer.highScore.ToString();
            PlayerInfo.Items[matchHistoryPos] += $"\n{newPlayer.matchHistory}";
        }

        private void PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
