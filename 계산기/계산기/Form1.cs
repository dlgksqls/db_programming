/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String number = "";
        String op;
        String cache;
        String cache_op;
        Boolean count = false;
        int op_count = 0;
        double sum = 0;
        double memory = 0;

        // 2
        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {   
                textBox1.Text = "";                
                this.number = "";
                count = false;                  
            }

            textBox1.Text += "2";
            this.number += "2";
        }
        // 3
        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "3";
            this.number += "3";
        }
        // 4
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "4";
            this.number += "4";
        }
        // 5
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "5";
            this.number += "5";
        }
        // 6
        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "6";
            this.number += "6";
        }
        // 7
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "7";
            this.number += "7";
        }
        // 8
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "8";
            this.number += "8";
        }
        // 9
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }

            textBox1.Text += "9";
            this.number += "9";
        }
        // +
        public void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (this.number.Length > 0)
            {
                if (op_count >= 1)
                {
                    if (number.IndexOf('+') != -1)
                    {
                        String[] plus_split = number.Split('+');
                        for (int i = 0; i < plus_split.Length; i++)
                            sum += double.Parse(plus_split[i]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('-') != -1 && number.IndexOf('+') == -1)
                    {
                        String[] minus_split = number.Split('-');
                        for (int i = 0; i < minus_split.Length - 1; i++)
                            sum = double.Parse(minus_split[i]) - double.Parse(minus_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('X') != -1)
                    {
                        String[] mul_split = number.Split('X');
                        for (int i = 0; i < mul_split.Length-1; i++)
                            sum = double.Parse(mul_split[i]) * double.Parse(mul_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('/') != -1)
                    {
                        String[] div_split = number.Split('/');
                        for (int i = 0; i < div_split.Length-1; i++)
                            sum = double.Parse(div_split[i]) / double.Parse(div_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                }
                op_count++;
                textBox1.Text += "+";
                this.number += "+";
                op = "+";
                count = false;
            }
        }
        // -
        public void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (this.number.Length == 0)
            {
                textBox1.Text += "-";
                this.number += "-";
            }
            else
            {
                if (op_count >= 1)
                {
                    if (number.IndexOf('+') != -1)
                    {
                        String[] plus_split = number.Split('+');
                        for (int i = 0; i < plus_split.Length; i++)
                            sum += double.Parse(plus_split[i]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('-') != -1)
                    {
                        if (number.IndexOf('X') != -1)
                        {
                            String[] mul = number.Split('X');
                            for (int i = 0; i < mul.Length-1; i++)
                            {
                                sum = double.Parse(mul[i]) * double.Parse(mul[i+1]);
                            }
                            textBox1.Text = sum.ToString();
                        }
                        else if(number.IndexOf('/') != -1)
                        {
                            String[] div = number.Split('/');
                            for (int i=0; i<div.Length-1; i++)
                            {
                                sum = double.Parse(div[i]) / double.Parse(div[i+1]);
                            }
                            textBox1.Text = sum.ToString();
                        }
                        else
                        {

                            String[] minus_split = number.Split('-');
                            if (minus_split.Length == 2)
                            {
                                for (int i = 0; i < minus_split.Length - 1; i++)
                                    sum = double.Parse(minus_split[i]) - double.Parse(minus_split[i + 1]);
                            }
                            else
                            {
                                for (int i = 1; i < minus_split.Length - 1; i++)
                                    sum = -(double.Parse(minus_split[i])) - double.Parse(minus_split[i + 1]);
                            }
                            textBox1.Text = sum.ToString();
                            this.number = sum.ToString();
                            sum = 0;
                            count = true;
                        }
                    }
                    else if (number.IndexOf('X') != -1)
                    {
                        String[] mul_split = number.Split('X');
                        for (int i = 0; i < mul_split.Length - 1; i++)
                            sum = double.Parse(mul_split[i]) * double.Parse(mul_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }}
                    else if (number.IndexOf('/') != -1)
                    {
                       String[] div_split = number.Split('/');
                        for (int i = 0; i < div_split.Length - 1; i++)
                            if (double.Parse(div_split[i + 1]) != 0)
                                sum = double.Parse(div_split[i]) / double.Parse(div_split[i + 1]);
                            else if (double.Parse(div_split[i + 1]) == 0)
                            {
                                MessageBox.Show("0으로 나눌 수 없습니다!!!!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sum = 0;
                                this.number = sum.ToString();
                            }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;}
                    }
                }
                op_count++;
                textBox1.Text += "-";
                this.number += "-";
                op = "-";
                count = false;
            }
        }
        // X
        public void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (this.number.Length > 0)
            {
                if (op_count >= 1)
                {
                    if (number.IndexOf('+') != -1)
                    {
                        String[] plus_split = number.Split('+');
                        for (int i = 0; i < plus_split.Length; i++)
                            sum += double.Parse(plus_split[i]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('-') != -1 && number.IndexOf('X') == -1)
                    {
                        String[] minus_split = number.Split('-');
                        if (minus_split.Length == 2)
                        {
                            for (int i = 0; i < minus_split.Length - 1; i++)
                                sum = double.Parse(minus_split[i]) - double.Parse(minus_split[i + 1]);
                        }
                        else
                        {
                            for (int i = 1; i < minus_split.Length - 1; i++)
                                sum = -(double.Parse(minus_split[i])) - double.Parse(minus_split[i + 1]);
                        }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('X') != -1)
                    {
                        String[] mul_split = number.Split('X');
                        for (int i = 0; i < mul_split.Length - 1; i++)
                            sum = double.Parse(mul_split[i]) * double.Parse(mul_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('/') != -1)
                    {
                        String[] div_split = number.Split('/');
                        for (int i = 0; i < div_split.Length - 1; i++)
                            if (double.Parse(div_split[i + 1]) != 0)
                                sum = double.Parse(div_split[i]) / double.Parse(div_split[i + 1]);
                            else if (double.Parse(div_split[i + 1]) == 0)
                            {
                                MessageBox.Show("0으로 나눌 수 없습니다!!!!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sum = 0;
                                this.number = sum.ToString();
                            }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                }
                op_count++;
                textBox1.Text += "X";
                this.number += "X";
                op = "X";
                count = false;
            }
        }
        // /
        public void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (this.number.Length > 0)
            {
                if (op_count >= 1)
                {
                    if (number.IndexOf('+') != -1)
                    {
                        String[] plus_split = number.Split('+');
                        for (int i = 0; i < plus_split.Length; i++)
                            sum += double.Parse(plus_split[i]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('-') != -1 && number.IndexOf('/') == -1)
                    {
                        String[] minus_split = number.Split('-');
                        if (minus_split.Length == 2)
                        {
                            for (int i = 0; i < minus_split.Length - 1; i++)
                                sum = double.Parse(minus_split[i]) - double.Parse(minus_split[i + 1]);
                        }
                        else
                        {
                            for (int i = 1; i < minus_split.Length - 1; i++)
                                sum = -(double.Parse(minus_split[i])) - double.Parse(minus_split[i + 1]);
                        }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('X') != -1)
                    {
                        String[] mul_split = number.Split('X');
                        for (int i = 0; i < mul_split.Length - 1; i++)
                            sum = double.Parse(mul_split[i]) * double.Parse(mul_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                    else if (number.IndexOf('/') != -1)
                    {
                        String[] div_split = number.Split('/');
                        for (int i = 0; i < div_split.Length - 1; i++)
                            if (double.Parse(div_split[i + 1]) != 0)
                                sum = double.Parse(div_split[i]) / double.Parse(div_split[i + 1]);
                            else if (double.Parse(div_split[i + 1]) == 0)
                            {
                                MessageBox.Show("0으로 나눌 수 없습니다!!!!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sum = 0;
                                this.number = sum.ToString();
                            }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                    }
                }
                op_count++;
                textBox1.Text += "/";
                this.number += "/";
                op = "/";
                count = false;
            }
        }
        // =
        public void button16_Click(object sender, EventArgs e)
        {
            // =
            op_count = 0;
            if (op != "")
            {
                switch (op)
                {
                    case "+":
                        String[] plus_split = number.Split('+');
                        for (int i = 0; i < plus_split.Length; i++)
                            sum += double.Parse(plus_split[i]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                        cache = plus_split[plus_split.Length - 1];
                        cache_op = "+";
                        op = "";
                        textBox2.Text = number + "+" + cache;
                        break;
                    case "-":
                        
                        String[] minus_split = number.Split('-');
                        if (minus_split.Length == 2)
                        {
                            for (int i = 0; i < minus_split.Length - 1; i++)
                                sum = double.Parse(minus_split[i]) - double.Parse(minus_split[i + 1]);
                        }
                        else
                        {
                            for (int i = 1; i < minus_split.Length - 1; i++)
                                sum = -(double.Parse(minus_split[i])) - double.Parse(minus_split[i + 1]);
                        }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                        cache_op = "-";
                        cache = minus_split[minus_split.Length - 1];
                        op = "";
                        textBox2.Text = number + "-" + cache;
                        break;
                    case "X":
                        
                        String[] mul_split = number.Split('X');
                        for (int i = 0; i < mul_split.Length - 1; i++)
                            sum = double.Parse(mul_split[i]) * double.Parse(mul_split[i + 1]);
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                        cache_op = "X";
                        cache = mul_split[mul_split.Length - 1];
                        op = "";
                        textBox2.Text = number+ "*" + cache;
                        break;
                    case "/":
                        
                        String[] div_split = number.Split('/');
                        for (int i = 0; i < div_split.Length - 1; i++)
                            if (double.Parse(div_split[i + 1]) != 0)
                                sum = double.Parse(div_split[i]) / double.Parse(div_split[i + 1]);
                            else if (double.Parse(div_split[i + 1]) == 0)
                            {
                                MessageBox.Show("0으로 나눌 수 없습니다!!!!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sum = 0;
                                this.number = sum.ToString();
                            }
                        textBox1.Text = sum.ToString();
                        this.number = sum.ToString();
                        sum = 0;
                        count = true;
                        cache_op = "/";
                        cache = div_split[div_split.Length - 1];
                        op = "";
                        textBox2.Text = number +"/" + cache;
                        break;
                }
            }
            else
            {
                sum = double.Parse(textBox1.Text);
                switch (cache_op)
                {
                    case "+":
                        textBox2.Text = sum + "+" + cache;
                        sum += double.Parse(cache);
                        textBox1.Text = sum.ToString();
                        
                        break;
                    case "-":
                        textBox2.Text = sum + "-" + cache;
                        sum -= double.Parse(cache);
                        textBox1.Text = sum.ToString();
                        
                        break;
                    case "X":
                        textBox2.Text = sum + "*" + cache;
                        sum *= double.Parse(cache);
                        textBox1.Text = sum.ToString();
                        
                        break;
                    case "/":
                        if (double.Parse(cache) != 0)
                        {
                            textBox2.Text = sum + "/" + cache;
                            sum /= double.Parse(cache);
                            textBox1.Text = sum.ToString();
                            
                            break;
                        }
                        else
                        {
                            MessageBox.Show("0으로 나눌 수 없습니다!!!!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sum = 0;
                            this.number = sum.ToString();
                            break;
                        }
                }
            }
        }
        // 0
        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }
            textBox1.Text += "0";
            this.number += "0";
        }
        // 1
        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count)
            {
                textBox1.Text = "";
                this.number = "";
                count = false;
            }
            textBox1.Text += "1";
            this.number += "1";
        }
        // .
        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text += "0.";
                this.number += "0.";
            }
            else
            {
                textBox1.Text += ".";
                this.number += ".";
                count = false;
            }
        }
        // backspace
        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text.Trim();
                this.number = textBox1.Text;
            }
        }
        // 제곱근
        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double result = Math.Sqrt(double.Parse(number));
            this.number = result.ToString();
            result = 0;
            textBox1.Text = this.number;
            count = true;
        }
        // 제곱
        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double result = double.Parse(number)*double.Parse(number);
            this.number = result.ToString();
            result = 0;
            textBox1.Text = this.number;
            count = true;
        }
        // 1/x
        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (double.Parse(number) == 0)
            {
                MessageBox.Show("0으로 나눌 수 없습니다!!!!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = this.number;
                count = true;
            }
            else
            {
                double result = 1 / double.Parse(number);
                this.number = result.ToString();
                result = 0;
                textBox1.Text = this.number;
                count = true;
            }
        }
        // CE
        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            String tmp = "";
            for (int i = 0; i< number.Length; i++)
            {
                if (number[i] == '+' || number[i] == '-' || number[i] == 'X' || number[i] == '/')
                {
                    tmp += number[i];
                    break;
                }
                tmp += number[i];
            }
            this.number = tmp;
            textBox1.Text = this.number;
        }
        // C
        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            sum = 0;
            this.number = "";
            textBox1.Text = this.number;
            count = false;
        }
        // %
        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double result = double.Parse(number) / 100;
            this.number = result.ToString();
            result = 0;
            textBox1.Text = this.number;
            count = true;
        }
        // MS
        private void button29_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            memory = double.Parse(textBox1.Text);
            count = true;
        }
        // MC
        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            memory = 0;
            count = true;
        }
        // MR
        private void button26_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = memory.ToString();
            count = true;
        }
        // M+
        private void button27_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            memory += double.Parse(textBox1.Text);
            count = true;
        }
        // M-
        private void button28_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            memory -= double.Parse(textBox1.Text);
            count = true;
        }
        // M
        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = memory.ToString();
            count = true;
        }
        // +/-
        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            this.number = (double.Parse(textBox1.Text) * -1).ToString();
            textBox1.Text = this.number;
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;

namespace 계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String tmp_1;
        String tmp_2;
        String number;
        String op;
        int count = 0;
        double sum = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.number != "")
            {
                this.number = "";
                textBox1.Text = this.number;
            }
            textBox1.Text += "2";
            this.number += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            this.number += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            this.number += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            this.number += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            this.number += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            this.number += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            this.number += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            this.number += "9";
        }

        public void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            this.number += "+";
            op = "+";
        }

        public void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            this.number += "-";
            op = "-";
        }

        public void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "X";
            this.number += "X";
            op = "X";
        }

        public void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            this.number += "/";
            op = "/";
        }

        public void button16_Click(object sender, EventArgs e)
        {
            // =
            switch (op)
            {
                case "+":
                    String[] plus_split = number.Split('+');
                    sum = double.Parse(plus_split[0]) + double.Parse(plus_split[1]);
                    textBox1.Text = sum.ToString();
                    this.number = sum.ToString();
                    sum = 0;
                    break;
                case "-":
                    String[] minus_split = number.Split('-');
                    sum = double.Parse(minus_split[0]) - double.Parse(minus_split[1]);
                    textBox1.Text = sum.ToString();
                    this.number = sum.ToString();
                    sum = 0;
                    break;
                case "X":
                    String[] mul_split = number.Split('X');
                    sum = double.Parse(mul_split[0]) * double.Parse(mul_split[1]);
                    textBox1.Text = sum.ToString();
                    this.number = sum.ToString();
                    sum = 0;
                    break;
                case "/":
                    String[] div_split = number.Split('/');
                    sum = double.Parse(div_split[0]) / double.Parse(div_split[1]);
                    textBox1.Text = sum.ToString();
                    this.number = sum.ToString();
                    sum = 0;
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            this.number += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            this.number += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            this.number += ".";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = textBox1.Text.Trim();
                this.number = textBox1.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double result = Math.Sqrt(double.Parse(number));
            this.number = result.ToString();
            result = 0;
            textBox1.Text = this.number;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double result = double.Parse(number) * double.Parse(number);
            this.number = result.ToString();
            result = 0;
            textBox1.Text = this.number;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double result = 1 / double.Parse(number);
            this.number = result.ToString();
            result = 0;
            textBox1.Text = this.number;
            this.number = "";
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            int tmp = int.Parse(this.number) * (-1);
            textBox1.Text = tmp.ToString();
        }
    }

}
