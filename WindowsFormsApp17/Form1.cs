using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        int x; int y; int h; int w; Color a;
        public Form1()
        {
            InitializeComponent();
            List<string> figures = new List<string> { "rectangle", "triangle", "circle" };
            FigureComboBox.Items.AddRange(figures.ToArray());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;
            Graphics graphics = this.CreateGraphics();

            if (FigureComboBox.SelectedItem.ToString() == "rectangle")
            {
                if (fillbtn.Checked)
                {
                    graphics.FillRectangle(new SolidBrush(a), new Rectangle(x, y, h, w));
                }
                else
                {
                    graphics.DrawRectangle(new Pen(a,3.5f), new Rectangle(x, y, h, w));
                }
            }
            if (FigureComboBox.SelectedItem.ToString() == "circle")
            {
                if (fillbtn.Checked)
                {
                    graphics.FillEllipse(new SolidBrush(a), new Rectangle(x, y, h, w));
                }
                else
                {
                    graphics.DrawEllipse(new Pen(a, 3.5f), new Rectangle(x, y, h, w));
                }
            }
            if (FigureComboBox.SelectedItem.ToString() == "triangle")
            {
                if (fillbtn.Checked)
                {
                    graphics.FillEllipse(new SolidBrush(a), new Rectangle(x, y, h, w));
                }
                else
                {
                    graphics.DrawEllipse(new Pen(a, 3.5f), new Rectangle(x, y, h, w));
                }
            }
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                a = colorDialog1.Color;
            }
        }
    }
}
