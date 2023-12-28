using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private MessageBoxIcon iconType;
        private MessageBoxButtons buttonType;
        public Form1()
        {
            InitializeComponent();
        }
        public int num1;
        public int num;

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = 4;
            if (checkBox1.Checked)
            {
                num = Convert.ToInt16(numericUpDown1.Value);

                numericUpDown1.Enabled = true;
                num1 = num;
            }
            else
            {


                numericUpDown1.Enabled = false;
            }
            int value;
            string output = "Excellent,\t\t\t\t\t\t\t\t\t be persistent\r\n";
            value = Convert.ToInt16(textBox1.Text);
            if (value >= 48 && value <= 100)
            {

                int na = value;
                string a = String.Format("A  {0}\t\t\t\t\t\t\t\t\t", na);
                int nam = value - num1 * 1;
                string am = String.Format("A- {0}\t\t\t\t\t\t\t\t\t", nam);
                /////////////////////////////////////////////////////////
                int nbp = value - num1 * 2;
                string bp = String.Format("B+{0}\t\t\t\t\t\t\t\t\t", nbp);
                int nb = value - num1 * 3;
                string b = String.Format("B  {0}\t\t\t\t\t\t\t\t\t", nb);
                int nbm = value - num1 * 4;
                string bm = String.Format("B- {0}\t\t\t\t\t\t\t\t\t", nbm);
                /////////////////////////////////////////////////////////
                int ncp = value - num1 * 5;
                string cp = String.Format("C+{0}\t\t\t\t\t\t\t\t\t", ncp);
                int nc = value - num1 * 6;
                string c = String.Format("C   {0}\r\n", nc);
                int ncm = value - num1 * 7;
                string cm = String.Format("C- {0}\r\n", ncm);
                /////////////////////////////////////////////////////////
                int ndp = value - num1 * 8;
                string dp = String.Format("D+{0}\r\n", ndp);
                int nd = value - num1 * 9;
                string d = String.Format("D   {0}\r\n", nd);
                int ndm = value - num1 * 10;
                string dm = String.Format("D- {0}\r\n", ndm);
                /////////////////////////////////////////////////////////
                int nf = value - num1 * 11;
                string f = String.Format("F   {0}\r\n", nf);
                /////////////////////////////////////////////////////////
                output = output + a + c + am + cm + bp + dp + b + d + bm + dm + cp + f;

                displayTextBox.Text = output;

            }
            else
            {
                buttonType = MessageBoxButtons.RetryCancel;
                iconType = MessageBoxIcon.Warning;
                DialogResult result = MessageBox.Show("You have entered an incorrect value", "Incorrect Value", buttonType, iconType);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = 4;
            if (checkBox1.Checked)
            {
                num = Convert.ToInt16(numericUpDown1.Value);

                numericUpDown1.Enabled = true;
                num1 = num;
            }
            else
            {

                numericUpDown1.Enabled = false;
            }

            int value;
            string output = "Excellent,\t\t\t\t\t\t\t\t\t be persistent\r\n";
            value = Convert.ToInt16(textBox2.Text);
            if (value >= 8 && value <= 64)
            {

                int na = value + num1 * 9;
                string a = String.Format("A  {0}\t\t\t\t\t\t\t\t\t", na);
                int nam = value + num1 * 8;
                string am = String.Format("A- {0}\t\t\t\t\t\t\t\t\t", nam);
                /////////////////////////////////////////////////////////
                int nbp = value + num1 * 7;
                string bp = String.Format("B+{0}\t\t\t\t\t\t\t\t\t", nbp);
                int nb = value + num1 * 6;
                string b = String.Format("B  {0}\t\t\t\t\t\t\t\t\t", nb);
                int nbm = value + num1 * 5;
                string bm = String.Format("B- {0}\t\t\t\t\t\t\t\t\t", nbm);
                /////////////////////////////////////////////////////////
                int ncp = value + num1 * 4;
                string cp = String.Format("C+{0}\t\t\t\t\t\t\t\t\t", ncp);
                int nc = value + num1 * 3;
                string c = String.Format("C   {0}\r\n", nc);
                int ncm = value + num1 * 2;
                string cm = String.Format("C- {0}\r\n", ncm);
                /////////////////////////////////////////////////////////
                int ndp = value + num1 * 1;
                string dp = String.Format("D+{0}\r\n", ndp);
                int nd = value;
                string d = String.Format("D   {0}\r\n", nd);
                int ndm = value - num1 * 1;
                string dm = String.Format("D- {0}\r\n", ndm);
                /////////////////////////////////////////////////////////
                int nf = value - num1 * 2;
                string f = String.Format("F   {0}\r\n", nf);
                /////////////////////////////////////////////////////////
                output = output + a + c + am + cm + bp + dp + b + d + bm + dm + cp + f;

                displayTextBox.Text = output;

            }
            else
            {
                buttonType = MessageBoxButtons.RetryCancel;
                iconType = MessageBoxIcon.Warning;
                DialogResult result = MessageBox.Show("You have entered an incorrect value", "Incorrect Value", buttonType, iconType);

            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

            int value = 0;
            string output = "Excellent,\t\t\t\t\t\t\t\t\t be persistent\r\n";
            int na = value;
            string a = String.Format("A  {0}\t\t\t\t\t\t\t\t\t", na);
            int nam = value;
            string am = String.Format("A- {0}\t\t\t\t\t\t\t\t\t", nam);
            /////////////////////////////////////////////////////////
            int nbp = value;
            string bp = String.Format("B+{0}\t\t\t\t\t\t\t\t\t", nbp);
            int nb = value;
            string b = String.Format("B  {0}\t\t\t\t\t\t\t\t\t", nb);
            int nbm = value;
            string bm = String.Format("B- {0}\t\t\t\t\t\t\t\t\t", nbm);
            /////////////////////////////////////////////////////////
            int ncp = value;
            string cp = String.Format("C+{0}\t\t\t\t\t\t\t\t\t", ncp);
            int nc = value;
            string c = String.Format("C   {0}\r\n", nc);
            int ncm = value;
            string cm = String.Format("C- {0}\r\n", ncm);
            /////////////////////////////////////////////////////////
            int ndp = value;
            string dp = String.Format("D+{0}\r\n", ndp);
            int nd = value;
            string d = String.Format("D   {0}\r\n", nd);
            int ndm = value;
            string dm = String.Format("D- {0}\r\n", ndm);
            /////////////////////////////////////////////////////////
            int nf = value;
            string f = String.Format("F   {0}\r\n", nf);
            /////////////////////////////////////////////////////////
            output = output + a + c + am + cm + bp + dp + b + d + bm + dm + cp + f;

            displayTextBox.Text = output;
            textBox1.Text = null;
            textBox2.Text = null;


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int value;
                string output = "Excellent,\t\t\t\t\t\t\t\t\t be persistent\r\n";
                value = 0;
                int na = value;
                string a = String.Format("A  {0}\t\t\t\t\t\t\t\t\t", na);
                int nam = value;
                string am = String.Format("A- {0}\t\t\t\t\t\t\t\t\t", nam);
                /////////////////////////////////////////////////////////
                int nbp = value;
                string bp = String.Format("B+{0}\t\t\t\t\t\t\t\t\t", nbp);
                int nb = value;
                string b = String.Format("B  {0}\t\t\t\t\t\t\t\t\t", nb);
                int nbm = value;
                string bm = String.Format("B- {0}\t\t\t\t\t\t\t\t\t", nbm);
                /////////////////////////////////////////////////////////
                int ncp = value;
                string cp = String.Format("C+{0}\t\t\t\t\t\t\t\t\t", ncp);
                int nc = value;
                string c = String.Format("C   {0}\r\n", nc);
                int ncm = value;
                string cm = String.Format("C- {0}\r\n", ncm);
                /////////////////////////////////////////////////////////
                int ndp = value;
                string dp = String.Format("D+{0}\r\n", ndp);
                int nd = value;
                string d = String.Format("D   {0}\r\n", nd);
                int ndm = value;
                string dm = String.Format("D- {0}\r\n", ndm);
                /////////////////////////////////////////////////////////
                int nf = value;
                string f = String.Format("F   {0}\r\n", nf);
                /////////////////////////////////////////////////////////
                output = output + a + c + am + cm + bp + dp + b + d + bm + dm + cp + f;

                displayTextBox.Text = output;

                textBox1.Enabled = true;
                button1.Visible = true;

                button2.Visible = false;
                textBox2.Enabled = false;
                if (checkBox1.Checked)
                {
                    numericUpDown1.Enabled = true;


                }
                else
                {
                    numericUpDown1.Enabled = false;

                }



            }
            else
            {
                int value;
                string output = "Excellent,\t\t\t\t\t\t\t\t\t be persistent\r\n";
                value = 0;
                int na = value;
                string a = String.Format("A  {0}\t\t\t\t\t\t\t\t\t", na);
                int nam = value;
                string am = String.Format("A- {0}\t\t\t\t\t\t\t\t\t", nam);
                /////////////////////////////////////////////////////////
                int nbp = value;
                string bp = String.Format("B+{0}\t\t\t\t\t\t\t\t\t", nbp);
                int nb = value;
                string b = String.Format("B  {0}\t\t\t\t\t\t\t\t\t", nb);
                int nbm = value;
                string bm = String.Format("B- {0}\t\t\t\t\t\t\t\t\t", nbm);
                /////////////////////////////////////////////////////////
                int ncp = value;
                string cp = String.Format("C+{0}\t\t\t\t\t\t\t\t\t", ncp);
                int nc = value;
                string c = String.Format("C   {0}\r\n", nc);
                int ncm = value;
                string cm = String.Format("C- {0}\r\n", ncm);
                /////////////////////////////////////////////////////////
                int ndp = value;
                string dp = String.Format("D+{0}\r\n", ndp);
                int nd = value;
                string d = String.Format("D   {0}\r\n", nd);
                int ndm = value;
                string dm = String.Format("D- {0}\r\n", ndm);
                /////////////////////////////////////////////////////////
                int nf = value;
                string f = String.Format("F   {0}\r\n", nf);
                /////////////////////////////////////////////////////////
                output = output + a + c + am + cm + bp + dp + b + d + bm + dm + cp + f;

                displayTextBox.Text = output;

                button2.Visible = true;
                textBox2.Enabled = true;
                button1.Visible = false;
                textBox1.Enabled = false;
                if (checkBox1.Checked)
                {
                    numericUpDown1.Enabled = true;


                }
                else
                {
                    numericUpDown1.Enabled = false;

                }

            }
        }
        private void information_Click(object sender, EventArgs e)
        {
            Form2 mm = new Form2();
            mm.ShowDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Visible = true;

                numericUpDown1.Enabled = true;


            }
            else
            {
                numericUpDown1.Visible = false;

                numericUpDown1.Enabled = false;

            }


        }
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numericUpDown1.Value);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        int count = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            count++;

            if (count % 2 == 0)
            {

                checkBox1.Visible = true;
                if (checkBox1.Checked)
                {
                    numericUpDown1.Visible = true;
                }
                button5.Visible = true;
                button4.Visible = true;



            }
            else
            {
                numericUpDown1.Visible = false;
                checkBox1.Visible = false;
                button5.Visible = false;
                button4.Visible = false;

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
