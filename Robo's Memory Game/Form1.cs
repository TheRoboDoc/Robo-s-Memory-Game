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
        public Form1()
        {
            InitializeComponent();
            GenerateGrid();
        }

        private void GenerateGrid()
        {
            const int GRIDDEBUGSIZE = 16;

            // Calculate the number of rows and columns needed to fill the desired area
            int numRows = (int)Math.Sqrt(GRIDDEBUGSIZE);
            int numColumns = (int)Math.Ceiling((double)GRIDDEBUGSIZE / numRows);

            // Calculate the size of each button based on the number of rows and columns
            int buttonWidth = 500 / numColumns;
            int buttonHeight = 500 / numRows;

            for (int y = 0; y < numRows; y++)
            {
                for (int x = 0; x < numColumns; x++)
                {
                    Button button = new Button();
                    button.Text = "Button";
                    button.Location = new Point(x * buttonWidth, y * buttonHeight);
                    button.Size = new Size(buttonWidth + 1, buttonHeight + 1);
                    button.Padding = new Padding(0);
                    Controls.Add(button);
                    button.BringToFront();
                }
            }
        }
    }
}
