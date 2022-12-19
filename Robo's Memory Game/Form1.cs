using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robo_s_Memory_Game
{
    public partial class Form1 : Form
    {
        const int GRIDDEBUGSIZE = 128; //For debug, need to replace this with user input later

        public Form1()
        {
            InitializeComponent();
            GenerateGrid();
        }

        //List of all the "tiles"
        public List<Button> tiles;

        //List of all colors
        public List<Color> colors;

        /// <summary>
        /// Generates the tile grid
        /// </summary>
        private void GenerateGrid()
        {
            // Calculate the number of rows and columns needed to fill the desired area
            int numRows = (int)Math.Sqrt(GRIDDEBUGSIZE);
            int numColumns = (int)Math.Ceiling((double)GRIDDEBUGSIZE / numRows);

            // Calculate the size of each button based on the number of rows and columns
            int buttonWidth = 500 / numColumns;
            int buttonHeight = 500 / numRows;

            tiles = new List<Button>();

            for (int y = 0; y < numRows; y++)
            {
                for (int x = 0; x < numColumns; x++)
                {
                    Button button = new Button();
                    button.Text = "Button";
                    button.Location = new Point(x * buttonWidth, y * buttonHeight);
                    button.Size = new Size(buttonWidth + 1, buttonHeight + 1);
                    button.Padding = new Padding(0);
                    tiles.Add(button);
                    button.Click += Button_Click;
                    Controls.Add(button);
                    button.BringToFront();
                }
            }

            AssigneColor();
        }

        /// <summary>
        /// Assignes the colors to randombly paired tiles
        /// </summary>
        private void AssigneColor()
        {
            colors = new List<Color>();

            int colorAmount = GRIDDEBUGSIZE / 2;

            KnownColor[] colorsArray = (KnownColor[])Enum.GetValues(typeof(KnownColor));

            Random rand = new Random();

            for(int i = 0; i < colorAmount; i++)
            {
                Color color = Color.FromKnownColor(colorsArray[rand.Next(0, colorsArray.Length)]);
                colors.Add(color);
            }

            do
            {
                
                int index = rand.Next(0, tiles.Count);

                string colorName = colors.Last().Name;

                Button button1 = tiles[index];
                button1.Text = colorName;

                tiles.RemoveAt(index);

                index = rand.Next(0, tiles.Count);

                Button button2 = tiles[index];
                button2.Text = colorName;

                tiles.RemoveAt(index);

                colors.RemoveAt(colors.LastIndexOf(colors.Last()));
            } while (tiles.Count > 0 && colors.Count > 0);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.BackColor = Color.FromName(button.Text);
        }
    }
}
