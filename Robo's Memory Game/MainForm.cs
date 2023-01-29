using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Robo_s_Memory_Game
{
    /// <summary>
    /// Main play form
    /// </summary>
    public partial class MainForm : Form
    {
        private int gridSize;

        private GameMode gameMode;

        private FileManager.Player playerOne;
        private FileManager.Player playerTwo;

        private bool playerOneTurn = true;
        private bool playerTwoTurn = false;

        /// <summary>
        /// Main play form
        /// </summary>
        /// <param name="gameMode">Game mode to be played</param>
        /// <param name="playerOne">The first player</param>
        /// <param name="backgroundImage">The background image to be used</param>
        /// <param name="gridSize">The size of the grid to use</param>
        /// <param name="playerTwo">The second player</param>
        public MainForm(GameMode gameMode, FileManager.Player playerOne, Image backgroundImage,
            int gridSize,FileManager.Player playerTwo = new FileManager.Player()) 
        {
            InitializeComponent();
            
            this.gameMode = gameMode;
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.gridSize = gridSize;

            GenerateGrid();

            BackGroundImage.Image = backgroundImage;

            switch(this.gameMode)
            {
                case GameMode.Single:
                    SinglePlayerInfoPanel.Visible = true;
                    break;
                case GameMode.Versus:
                    VersusPlayerInfoPanel.Visible = true;
                    break;
                default:
                    throw new Exception("Failed to set a game mode");
            }

            PlayTimer.Enabled = true;
            PlayTimer.Start();

            TurnLable.Text = $"{playerOne.name}'s turn";
        }

        /// <summary>
        /// Available game modes
        /// </summary>
        public enum GameMode
        {
            /// <summary>
            /// Singleplayer game mode
            /// </summary>
            Single,

            /// <summary>
            /// Versus mode where two players play against each other
            /// </summary>
            Versus
        }

        /// <summary>
        /// List of all the colors used in the game
        /// </summary>
        private List<Color> knownColors = new List<Color>()
        {
            Color.Aqua,
            Color.Blue,
            Color.BlueViolet,
            Color.Brown,
            Color.Crimson,
            Color.Cyan,
            Color.DeepPink,
            Color.Gold,
            Color.Green,
            Color.HotPink,
            Color.Lime,
            Color.Magenta,
            Color.Navy,
            Color.Olive,
            Color.Orange,
            Color.OrangeRed,
            Color.Pink,
            Color.Purple,
            Color.Red,
            Color.Salmon,
            Color.Tomato,
            Color.Turquoise,
            Color.Violet,
            Color.Yellow,
            Color.YellowGreen,
            Color.Orchid
        };

        /// <summary>
        /// List of all of the unassigned "tiles"
        /// </summary>
        public List<Button> unasignedtiles;

        /// <summary>
        /// List of colors
        /// </summary>
        public List<Color> colors;

        /// <summary>
        /// Generates the tile grid
        /// </summary>
        private void GenerateGrid()
        {
            // Calculate the number of rows and columns needed to fill the desired area
            int numRows = (int)Math.Sqrt(gridSize);
            int numColumns = (int)Math.Ceiling((double)gridSize / numRows);

            // Calculate the size of each button based on the number of rows and columns, and size of the grid area
            int buttonWidth = (BackGroundImage.Width + 4) / numColumns;
            int buttonHeight = BackGroundImage.Height / numRows;

            unasignedtiles = new List<Button>();

            //Creates the needed amount of tiles
            for (int y = 0; y < numRows; y++)
            {
                for (int x = 0; x < numColumns; x++)
                {
                    Button button = new Button()
                    {
                        Text = "Button",
                        Location = new Point(x * buttonWidth - 2, y * buttonHeight),
                        Size = new Size(buttonWidth, buttonHeight),
                        Padding = new Padding(0),
                        BackColor = Color.White,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Popup
                    };

                    unasignedtiles.Add(button);
                    button.Click += Button_Click;
                    button.Disposed += Button_Disposed;
                    Controls.Add(button);
                    button.BringToFront();
                }
            }

            AssigneColor();
        }

        /// <summary>
        /// List of all assigned "tiles"
        /// </summary>
        List<Button> assignedTiles = new List<Button>();

        private void Button_Disposed(object sender, EventArgs e)
        {
            if (assignedTiles.Count > 0) return;

            PlayTimer.Stop();

            FileManager.Player winner = new FileManager.Player();
            FileManager.Player loser = new FileManager.Player();

            float fScore = 0;

            if(gameMode == GameMode.Single)
            {
                fScore = float.Parse(CurrentScore.Text);
                winner = playerOne;
            }
            else if(gameMode == GameMode.Versus)
            {
                int scoreOne = int.Parse(PlayerOneCurrentScore.Text);
                int scoreTwo = int.Parse(PlayerTwoCurrentScore.Text);

                if(scoreOne > scoreTwo)
                {
                    winner = playerOne;
                    loser = playerTwo;
                }
                else if(scoreOne < scoreTwo)
                {
                    winner = playerTwo;
                    loser = playerOne;
                }
                else
                {
                    GenerateGrid();
                }

                PlayerOneCurrentScore.Text = scoreOne.ToString();
                PlayerTwoCurrentScore.Text = scoreTwo.ToString();
            }

            int score = (int)Math.Round(fScore);

            CurrentScore.Text = score.ToString();

            string[] playerNames = {playerOne.name, playerTwo.name};

            string matchType = "";

            if(gameMode == GameMode.Single)
            {
                matchType = "Single";
            }
            else if(gameMode == GameMode.Versus)
            {
                matchType = "Versus";
            }

            FileManager.Match currentMatch = new FileManager.Match()
            {
                matchType = matchType,
                mathDate = DateTime.Now,
                playerNames = playerNames,
                winnersName = winner.name,
                gridSize = gridSize
            };

            VictoryScreen victoryScreen = new VictoryScreen(winner, loser, score, currentMatch, timeSpan);

            victoryScreen.Owner = this;

            victoryScreen.ShowDialog();
        }

        /// <summary>
        /// Assignes the colors to randombly paired tiles
        /// </summary>
        private void AssigneColor()
        {
            colors = new List<Color>();

            int colorAmount = gridSize / 2;

            Random rand = new Random();

            for(int i = 0; i < colorAmount; i++)
            {
                Color color = knownColors.ElementAt(rand.Next(knownColors.Count));
                colors.Add(color);
                knownColors.Remove(color);
            }

            do
            {
                int index = rand.Next(unasignedtiles.Count);

                string colorName = colors.Last().Name;

                Button button1 = unasignedtiles[index];
                button1.Text = colorName;

                unasignedtiles.RemoveAt(index);

                index = rand.Next(unasignedtiles.Count);

                Button button2 = unasignedtiles[index];
                button2.Text = colorName;

                unasignedtiles.RemoveAt(index);

                assignedTiles.Add(button1);
                assignedTiles.Add(button2);

                colors.RemoveAt(colors.LastIndexOf(colors.Last()));
            } while (unasignedtiles.Count > 0 && colors.Count > 0);
        }

        /// <summary>
        /// When tile is clicked
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            List<Button> flippedTiles = new List<Button>();

            FlipAnimation(button);

            //Adds every Button with a tag "flipped" to a list of flipped tiles
            foreach (Button tile in assignedTiles)
            {
                if((string)tile.Tag == "flipped")
                {
                    flippedTiles.Add(tile);
                }
            }

            if (flippedTiles.Count > 1)
            {
                //Compares if the buttons are the same color
                //If they are deletes them
                if(flippedTiles.First().BackColor == flippedTiles.Last().BackColor)
                {
                    foreach(Button tile in flippedTiles)
                    {
                        assignedTiles.Remove(tile);
                        tile.Dispose();
                    }

                    if (playerOneTurn)
                    {
                        playerOneTurn = true;
                        playerTwoTurn = false;
                        GiveScoreToPlayer(playerOne);
                    }
                    else if (playerTwoTurn)
                    {
                        playerTwoTurn = true;
                        playerOneTurn = false;
                        GiveScoreToPlayer(playerTwo);
                    }
                }
                //If they are not returns them to default state
                else
                {
                    foreach(Button tile in flippedTiles)
                    {
                        tile.Tag = string.Empty;
                        tile.BackColor = Color.White;
                    }

                    if (playerOneTurn)
                    {
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (playerTwoTurn)
                    {
                        playerTwoTurn = false;
                        playerOneTurn = true;
                    }
                }
            }

            if (playerOneTurn)
            {
                TurnLable.Text = $"{playerOne.name}'s turn";
            }
            else if (playerTwoTurn)
            {
                TurnLable.Text = $"{playerTwo.name}'s turn";
            }
        }

        /// <summary>
        /// Tile to play the animation on
        /// </summary>
        /// <param name="button">Tile to animate</param>
        public void FlipAnimation(Button button)
        {
            button.Tag = "flipped";

            button.BackColor = Color.FromName(button.Text);
        }

        /// <summary>
        /// Gives the given player a score
        /// </summary>
        /// <param name="player"></param>
        private void GiveScoreToPlayer(FileManager.Player player)
        {
            float currentScore;

            if (gameMode == GameMode.Single)
            {
                currentScore = float.Parse(CurrentScore.Text);
                currentScore += 1;

                CurrentScore.Text = currentScore.ToString();
            }

            if (gameMode != GameMode.Versus) return;

            if(playerOneTurn)
            {
                currentScore = float.Parse(PlayerOneCurrentScore.Text);
                currentScore += 1;

                PlayerOneCurrentScore.Text = currentScore.ToString();
            }
            else if(playerTwoTurn)
            {
                currentScore = float.Parse(PlayerTwoCurrentScore.Text);
                currentScore += 1;

                PlayerTwoCurrentScore.Text = currentScore.ToString();
            }
        }

        private void SinglePlayerInfoPanel_VisibleChanged(object sender, EventArgs e)
        {
            PlayerNameLable.Text = playerOne.name;
            BestScore.Text = playerOne.highScore.ToString();
        }

        private void VersusPlayerInfoPanel_VisibleChanged(object sender, EventArgs e)
        {
            PlayerOneName.Text = playerOne.name;
            PlayerTwoName.Text = playerTwo.name;

            PlayerOneBestScore.Text = playerOne.highScore.ToString();
            PlayerTwoBestScore.Text = playerTwo.highScore.ToString();
        }

        private void ExitPlay_Click(object sender, EventArgs e)
        {
            Close();

            Owner.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }

        TimeSpan timeSpan = TimeSpan.FromSeconds(0);

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            timeSpan += TimeSpan.FromSeconds(1);

            PlayTimeDisplay.Text = timeSpan.ToString();
            VersusTimeDisplay.Text = timeSpan.ToString();
        }

        
    }
}
