using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230927_연결실습_두_번째
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection_user = "USER ID=C##5585006;PASSWORD=lee0103639; Data source = localhost:1521 / xepdb1; ";

            oracleConnection1.ConnectionString = connection_user;
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
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = oracleConnection1;
            cmd.CommandText = "SELECT * FROM STUDENTS";
            OracleDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                listBox1.Items.Add(rdr["이름"] + " " + rdr["학번"]);
            }
        }
    }
}
