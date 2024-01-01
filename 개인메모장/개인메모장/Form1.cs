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

namespace 개인메모장
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
            oracleConnection1.ConnectionString = conString;
            oracleConnection1.Open();
            MessageBox.Show(oracleConnection1.State.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql_insert = "INSERT INTO MEMO_TABLE(M_ID,M_KEYWORD,M_DATE,M_CONTENTS) VALUES(memo_seq.nextval, :aa, :bb, :cc)";

            DateTime current_time = Convert.ToDateTime(oracleCommand2.ExecuteScalar());

            oracleCommand1.CommandText = sql_insert;

            oracleCommand1.Parameters["aa"].Value = textBox1.Text;
            oracleCommand1.Parameters["bb"].Value = current_time.ToString();
            oracleCommand1.Parameters["cc"].Value = textBox2.Text;

            oracleCommand1.ExecuteNonQuery();

            MessageBox.Show("Memo successfully added!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleDataReader rdr = oracleCommand3.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["M_ID"]);
            }
            rdr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = listBox1.SelectedItem.ToString();
            string sql = "SELECT M_DATE,M_CONTENTS FROM MEMO_TABLE WHERE M_id=";
            oracleCommand4.CommandText = sql + num;
            OracleDataReader rdr = oracleCommand4.ExecuteReader();

            listBox2.Items.Clear();
            int count = rdr.FieldCount;

            while (rdr.Read())
            {
                listBox2.Items.Add(rdr["M_DATE"]);
                listBox2.Items.Add(rdr["M_CONTENTS"]);
            }
        }
    }
}
