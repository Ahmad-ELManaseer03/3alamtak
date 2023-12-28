using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form3 : Form
    {
        int num3;
        public Form3()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form1 aa = new Form1();


            if (checkBox1.Checked == true)
            {

                numericUpDown1.Visible = true;

                numericUpDown1.Enabled = true;
                num3 = Convert.ToInt32(numericUpDown1.Value);


            }
            else
            {
                numericUpDown1.Visible = false;

                numericUpDown1.Enabled = false;
                num3 = 4;

            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.num1 = num3;
            this.Close();

        }
    }
}


