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
        private FileManager.Player player;

        private int score;

        private FileManager.Match match;

        /// <summary>
        /// Victory screen for the game
        /// </summary>
        /// <param name="player">Player that won</param>
        /// <param name="score">Winning player's score</param>
        /// <param name="match">The match that was played</param>
        public VictoryScreen(FileManager.Player player, int score, FileManager.Match match)
        {
            InitializeComponent();
            this.player = player;
            this.score = score;
            this.match = match;
        }

        /// <summary>
        /// When the exit button is clicked
        /// Saves the match and other player data to that said player entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            if(score > player.highScore)
            {
                player.highScore = score;
            }

            if(player.matchHistory == null)
            {
                player.matchHistory = new List<FileManager.Match>();
            }

            player.matchHistory.Add(match);

            FileManager.SavePlayerData(player);

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

            BestScore.Text = player.highScore.ToString();
        }
    }
}
