using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robo_s_Memory_Game
{
    /// <summary>
    /// Main play form
    /// </summary>
    public partial class MainForm : Form
    {
        const int GRIDDEBUGSIZE = 48; //For debug, need to replace this with user input later

        public MainForm()
        {
            InitializeComponent();
            GenerateGrid();
        }

        /// <summary>
        /// List of all the colors used in the game
        /// </summary>
        List<Color> knownColors = new List<Color>()
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
            int numRows = (int)Math.Sqrt(GRIDDEBUGSIZE);
            int numColumns = (int)Math.Ceiling((double)GRIDDEBUGSIZE / numRows);

            // Calculate the size of each button based on the number of rows and columns, and size of the grid area
            int buttonWidth = (BackGroundImage.Width + 2) / numColumns;
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
                        FlatStyle = FlatStyle.Popup
                    };

                    unasignedtiles.Add(button);
                    button.Click += Button_Click;
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

        /// <summary>
        /// Assignes the colors to randombly paired tiles
        /// </summary>
        private void AssigneColor()
        {
            colors = new List<Color>();

            int colorAmount = GRIDDEBUGSIZE / 2;

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
                if(tile.Tag == "flipped")
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
                        tile.Dispose();
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
                }
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
    }
}
