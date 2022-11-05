using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 64 * 8;
            this.Height = 64 * 8;
            this.StartPosition = FormStartPosition.CenterScreen;


            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Enabled  = false;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].FlatAppearance.MouseDownBackColor = Color.Transparent;
                    buttons[i, j].FlatAppearance.MouseOverBackColor = Color.Transparent;
                    buttons[i, j].Width = 64;
                    buttons[i, j].Height = 64;
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 64;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.BlanchedAlmond;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.BurlyWood;
                    }
                }
                top += 64;
                left = 0;

            }



        }
    }
}
