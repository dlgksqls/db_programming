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

namespace _20231018_실습
{
    public partial class Form1 : Form
    {
        string data = "";
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

            oracleCommand1.CommandText = "SELECT object_name FROM user_objects WHERE object_type = 'TABLE'";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr[0]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string my_contents = "";

            string sql = "SELECT * FROM ";
            string tbl_name = listBox1.SelectedItem.ToString();
            oracleCommand1.CommandText = sql + tbl_name;
            OracleDataReader rdr = oracleCommand1.ExecuteReader();  

            listBox2.Items.Clear();
            int count = rdr.FieldCount;

            while (rdr.Read())
            {
                my_contents = "";
                for (int i = 0; i <= count - 1; i++)
                    my_contents = my_contents + rdr[i] + ";";
                listBox2.Items.Add(my_contents);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM COLS WHERE TABLE_NAME = '";
            string data = listBox1.SelectedItem.ToString();
            oracleCommand1.CommandText = sql + data + "'";

            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            listBox2.Items.Clear();
            while (rdr.Read())
            {
                listBox2.Items.Add(rdr[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
         {
            string my_contents = "";

            string sql = "SELECT * FROM ";
            string tbl_name = listBox1.SelectedItem.ToString();
            oracleCommand1.CommandText = sql + tbl_name;
            OracleDataReader rdr = oracleCommand1.ExecuteReader();  

            listBox2.Items.Clear();
            int count = rdr.FieldCount;

            while (rdr.Read())
            {
                my_contents = "";
                for (int i = 0; i <= count - 1; i++)
                my_contents = my_contents + rdr[i] + ";";
                listBox2.Items.Add(my_contents);
            }
        }
    }
}
