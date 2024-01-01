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

namespace _20230927_연결실습_세번째
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connect_user = "USER ID=C##5585006;PASSWORD=lee0103639;Data source=localhost:1521/xepdb1;";
            oracleConnection1.ConnectionString = connect_user;
            oracleConnection1.Open();
            MessageBox.Show(oracleConnection1.State.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oracleConnection1.Close();
            MessageBox.Show(oracleConnection1.State.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oracleCommand1.Connection = oracleConnection1;
            oracleCommand1.CommandText = "SELECT * FROM STUDENTS";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while(rdr.Read())
            {
                listBox1.Items.Add(rdr["이름"] + " " + rdr["학번"]);
            }
        }
    }
}
