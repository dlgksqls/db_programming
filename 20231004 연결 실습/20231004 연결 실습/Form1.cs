using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20231004_연결_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = "USER ID=C##5585006;PASSWORD=lee0103639;Data source=localhost:1521/xepdb1";

            // 도구에서 생성도 가능// OracleConnection oracleConnection1 = new OracleConnection();

            oracleConnection1.ConnectionString = conString;
            oracleCommand1.Connection = oracleConnection1; //oracleCommand1 에 oracleConnection1 연결
            oracleConnection1.Open();
            MessageBox.Show(oracleConnection1.State.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SQL 끝에 세미콜론 없음
            string insert_txt =
                "INSERT INTO STUDENTS(학번,이름,주소,생년월일,지도교수,전화번호) VALUES('10002', '고길동', '한양','89/10/01','1001','01077777777')";

            oracleCommand1.CommandText = insert_txt;
            int ret_val = oracleCommand1.ExecuteNonQuery(); // 자동 커밋됨
            MessageBox.Show(ret_val.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Text = "";
            String check_list_all = "SELECT * FROM STUDENTS";
            oracleCommand1.CommandText = check_list_all;
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["학번"] + "" + rdr["이름"]);
            }
            rdr.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String std_number_to_students = "SELECT * FROM STUDENTS WHERE 학번=:PARAM";
            oracleCommand1.CommandText = std_number_to_students;
            oracleCommand1.Parameters["std_number"].Value = textBox1.Text; //Parameters[“std_number”]로도 사용 가능
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                textBox2.Text = rdr["이름"].ToString();
                textBox3.Text = rdr["주소"].ToString();
            }
            rdr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String sql_insert = "INSERT INTO STUDENTS (학번,이름,주소) VALUES(:std_number, :std_name, :std_add)";

            oracleCommand1.CommandText = sql_insert;
            oracleCommand1.Parameters["std_number"].Value = textBox1.Text;
            oracleCommand1.Parameters["std_name"].Value = textBox2.Text;
            oracleCommand1.Parameters["std_add"].Value = textBox3.Text;

            oracleCommand1.ExecuteNonQuery(); // 자동 커밋됨
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sql_delete = "DELETE FROM STUDENTS WHERE 학번 =:PARAM";
            oracleCommand1.CommandText = sql_delete;
            oracleCommand1.Parameters["std_number"].Value = textBox1.Text;
            oracleCommand1.ExecuteNonQuery ();
        }
    }
}
