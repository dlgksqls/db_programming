using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230925_실습__first_win_
{
    public partial class Form1 : Form // form의 서브클래스 form1을 사용 중
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i, j, sum;
        private void button1_Click(object sender, EventArgs e)
        {
            this.i = int.Parse(textBox1.Text);
            this.j = int.Parse(textBox2.Text);

            this.sum = this.i + this.j;

            textBox3.Text = this.sum.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.i = int.Parse(textBox1.Text);
            this.j = int.Parse(textBox2.Text);

            this.sum = this.i - this.j;

            textBox3.Text = this.sum.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.i = int.Parse(textBox1.Text);
            this.j = int.Parse(textBox2.Text);

            this.sum = this.i * this.j;

            textBox3.Text = this.sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.i = int.Parse(textBox1.Text);
            this.j = int.Parse(textBox2.Text);

            this.sum = this.i / this.j;

            textBox3.Text = this.sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime dtTemp = DateTime.Today;

            switch (dtTemp.DayOfWeek) {
                case DayOfWeek.Sunday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;
                case DayOfWeek.Monday:
                    MessageBox.Show("Today is Monday\n" + DateTime.Today);
                    break;
                case DayOfWeek.Tuesday:
                    MessageBox.Show("Today is Tusday\n" + DateTime.Today);
                    break;
                case DayOfWeek.Wednesday:
                    MessageBox.Show("Today is Wednesday\n" + DateTime.Today);
                    break;
                case DayOfWeek.Thursday:
                    MessageBox.Show("Today is Thursday\n" + DateTime.Today);
                    break;
                case DayOfWeek.Friday:
                    MessageBox.Show("Today is Friday\n" + DateTime.Today);
                    break;
                case DayOfWeek.Saturday:
                    MessageBox.Show("Today is Saturday\n" + DateTime.Today);
                    break;
            }

        }
    }
}
