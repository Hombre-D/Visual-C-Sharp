using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatesComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            listBox1.Items.Add(item);

            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Hide();
                MessageBox.Show("Combo Box is empty!");
                Application.Exit();
            }

        }
        

}
}
