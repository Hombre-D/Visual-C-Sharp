using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualKeyboard
{
    public partial class Form1 : Form
    {
        private string textBoxString = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var keys = getDict();

            foreach(var item in keys)
            {
                if (item.Key == e.KeyCode)
                {
                    item.Value.BackColor = Color.Black;
                    textBoxString += item.Value.Text;
                }
            }
            textBox1.Text = textBoxString;
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            var keys = getDict();

            foreach (var item in keys)
            {
                if (item.Key == e.KeyCode)
                {
                    item.Value.UseVisualStyleBackColor = true;
                    item.Value.BackColor = default(Color);
                }
            } 
            
        }

        //This method prepares and returns a dictionary for use in KeyDown/KeyUp
        private IDictionary<Keys, Button> getDict()
        {
            IDictionary<Keys, Button> keys = new Dictionary<Keys, Button>()
                {{Keys.Q, buttonQ},{Keys.W, buttonW},{Keys.E, buttonE},{Keys.R, buttonR},
                {Keys.T, buttonT},{Keys.Y, buttonY},{Keys.U, buttonU},{Keys.I, buttonI},
                {Keys.O, buttonO},{Keys.P, buttonP},{Keys.A, buttonA},{Keys.S, buttonS},
                {Keys.D, buttonD},{Keys.F, buttonF},{Keys.G, buttonG},{Keys.H, buttonH},
                {Keys.J, buttonJ},{Keys.K, buttonK},{Keys.L, buttonL},{Keys.Z, buttonZ},
                {Keys.X, buttonX},{Keys.C, buttonC},{Keys.V, buttonV},{Keys.B, buttonB},
                {Keys.N, buttonN},{Keys.M, buttonM},
                { Keys.Space, buttonSpace}
                };
            return keys;
        }
    }
}
