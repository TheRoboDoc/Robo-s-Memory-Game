using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robo_s_Memory_Game
{
    /// <summary>
    /// Victory screen for the game
    /// </summary>
    public partial class VictoryScreen : Form
    {
        private FileManager.Player winnerPlayer;
        private FileManager.Player loserPlayer;
        private FileManager.Match match;

        private TimeSpan playTime;

        private int score;

        /// <summary>
        /// Victory screen for the game
        /// </summary>
        /// <param name="winnerPlayer">Player that won</param>
        /// <param name="score">Winning player's score</param>
        /// <param name="match">The match that was played</param>
        public VictoryScreen(FileManager.Player winnerPlayer,FileManager.Player loserPlayer, int score, 
            FileManager.Match match, TimeSpan playTime)
        {
            InitializeComponent();
            this.winnerPlayer = winnerPlayer;
            this.loserPlayer = loserPlayer;
            this.score = score;
            this.match = match;
            this.playTime = playTime;
        }

        /// <summary>
        /// When the exit button is clicked
        /// Saves the match and other player data to that said player entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            SavePlayerData();

            Application.Exit();
        }

        /// <summary>
        /// When the Vicotory popup loads
        /// Loads scores to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VictoryScreen_Load(object sender, EventArgs e)
        {
            Score.Text = score.ToString();

            BestScore.Text = winnerPlayer.highScore.ToString();

            WinnerName.Text = winnerPlayer.name;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Owner.Owner.Visible = true;

            Close();

            Owner.Close();
        }

        /// <summary>
        /// Save the player data
        /// </summary>
        private void SavePlayerData()
        {
            if (score > winnerPlayer.highScore)
            {
                winnerPlayer.highScore = score;
            }

            if (winnerPlayer.matchHistory == null)
            {
                winnerPlayer.matchHistory = new List<FileManager.Match>();
            }

            if(loserPlayer.matchHistory == null)
            {
                loserPlayer.matchHistory = new List<FileManager.Match>();
            }

            winnerPlayer.matchHistory.Add(match);
            loserPlayer.matchHistory.Add(match);

            List<FileManager.Match> wonMatchList = new List<FileManager.Match>();
            List<FileManager.Match> lostMatchList = new List<FileManager.Match>();

            foreach (FileManager.Match match in winnerPlayer.matchHistory)
            {
                if (match.matchType == "Versus")
                {
                    if (match.winnersName == winnerPlayer.name)
                    {
                        wonMatchList.Add(match);
                    }
                    else
                    {
                        lostMatchList.Add(match);
                    }
                }
            }

            winnerPlayer.playTime += playTime;

            float winloseRatio;

            try
            {
                winloseRatio = wonMatchList.Count / lostMatchList.Count;
            }
            catch
            {
                winloseRatio = wonMatchList.Count;
            }

            winnerPlayer.winToLoseRatio = winloseRatio;

            FileManager.SavePlayerData(winnerPlayer);

            if (match.matchType == "Single") return;

            wonMatchList.Clear();
            lostMatchList.Clear();

            foreach(FileManager.Match match in loserPlayer.matchHistory)
            {
                if(match.matchType == "Versus")
                {
                    if(match.winnersName == loserPlayer.name)
                    {
                        wonMatchList.Add(match);
                    }
                    else
                    {
                        lostMatchList.Add(match);
                    }
                }
            }

            loserPlayer.playTime += playTime;


            try
            {
                winloseRatio = wonMatchList.Count / lostMatchList.Count;
            }
            catch
            {
                winloseRatio = wonMatchList.Count;
            }

            loserPlayer.winToLoseRatio = winloseRatio;

            FileManager.SavePlayerData(loserPlayer);
        }

        private void VictoryScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason != CloseReason.ApplicationExitCall)
            {
                SavePlayerData();
            }
            
            Owner.Close();
        }
    }
}
