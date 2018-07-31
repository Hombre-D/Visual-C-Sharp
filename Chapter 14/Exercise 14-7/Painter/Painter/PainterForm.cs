using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        bool ShouldPaint { get; set; } = false; // whether to paint

        // default constructor
        public PainterForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                panel1.CreateGraphics().FillEllipse(new SolidBrush(BrushColor()),
                    e.X, e.Y, BrushSize(), BrushSize());
            }
        }

        private Color BrushColor()
        {
            if (radioButtonRed.Checked)
                return Color.Red;
            if (radioButtonGreen.Checked)
                return Color.Green;
            else return Color.Blue;
        }

        private int BrushSize()
        {
            if (radioButtonSmall.Checked)
                return 4;
            if (radioButtonMedium.Checked)
                return 8;
            else return 12;
        }

    }
}
