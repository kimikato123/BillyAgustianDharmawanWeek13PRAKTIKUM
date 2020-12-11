using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPWarna : Form
    {
        public FormPWarna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if(labelHasil.Text == "[EMPTY]")
            {
                labelHasil.Text = textBoxnama.Text;
            }
            else
            {
                if(textBoxnama.Text == "DELETE")
                {
                    labelHasil.Text = "[EMPTY]";
                    labelHasil.ForeColor = Color.Black;
                }
                else if (textBoxnama.Text == "HIDE")
                {
                    labelHasil.Visible = false;
                }
                else if (textBoxnama.Text == "SHOWN")
                {
                    labelHasil.Visible = true;
                }
                else if (textBoxnama.Text == "GREEN")
                {
                    labelHasil.ForeColor = Color.Green;
                }
                else if (textBoxnama.Text == "RED")
                {
                    labelHasil.ForeColor = Color.Red;
                }
                else if (textBoxnama.Text == "BLUE")
                {
                    labelHasil.ForeColor = Color.Blue;
                }
            }

        }
    }
}
