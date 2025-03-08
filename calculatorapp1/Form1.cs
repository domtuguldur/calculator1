using calculatorlibrary1;
namespace calculatorapp1

{
    public partial class Form1 : Form
    {
        int num, flag;
        Memory memory = new Memory();
        Calculator calculator = new Calculator();


        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txt.Text = txt.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "1";
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "2";
        }

        private void txt3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "3";
        }


        private void txt4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "4";
        }

        private void txt5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "6";
        }

        private void txt7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "7";
        }

        private void txt8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "8";
        }

        private void txt9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "9";
        }

        private void txt0_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            calculator.results = int.Parse(txt.Text);
            txt.Clear();
        }

        private void hasah_Click(object sender, EventArgs e)
        {
            flag = 2;
            calculator.results = int.Parse(txt.Text);
            txt.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                calculator.Sum(int.Parse(txt.Text));
                txt.Clear();
                txt.Text = calculator.results.ToString();
            }
            else if (flag == 2)
            {
                calculator.Sub(int.Parse(txt.Text));
                txt.Clear();
                txt.Text = calculator.results.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            memory.hadgalah(int.Parse(txt.Text));
            textBox2.Text = memory.harah();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            memory.tsewereh();
            textBox2.Text = memory.harah();
        }

        private void ustgah_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num = memory.toonuud[memory.toonuud.Count - 1];
            num++;
            memory.toonuud[memory.toonuud.Count - 1] = num;
            textBox2.Text = memory.harah();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num = memory.toonuud[memory.toonuud.Count - 1];
            num--;
            memory.toonuud[memory.toonuud.Count - 1] = num;
            textBox2.Text = memory.harah();
        }
    }
}
