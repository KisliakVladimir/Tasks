using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task3Library;
namespace WindowsFormsTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length<1 && textBox2.Text.Length<1)
            {
                MessageBox.Show("Введите числа a и b");
            }
            long timeGcd;
            long timeGcdBinary;
            long timeGcdMany;
            string[] data = richTextBox1.Text.Split(',').ToArray();

            long[] datalong = data.Select(x=>Int64.Parse(x)).ToArray();
            textBox3.Text = Evklid.Gcd(Convert.ToInt64(textBox2.Text), Convert.ToInt64(textBox1.Text), out timeGcd).ToString();
            textBox4.Text = Evklid.BinaryGcd(Convert.ToInt64(textBox2.Text), Convert.ToInt64(textBox1.Text), out timeGcdBinary).ToString();
            textBox5.Text = Evklid.GcdMany(out timeGcdMany, datalong).ToString();

            chart1.Series["Execution Time"].Points.AddXY("Gcd", timeGcd);
            chart1.Series["Execution Time"].Points.AddXY("GcdMany", timeGcdMany);
            chart1.Series["Execution Time"].Points.AddXY("GcdBinary", timeGcdBinary);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
