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

namespace _20231016_실습
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oracleCommand2.Connection = oracleConnection1;
            string sql_insert = "INSERT INTO EMP(EMPNO, ENAME, JOB, HIREDATE, SAL, EMP_DEP) VALUES(:EMPNO, :ENAME, :JOB, :HIREDATE, :SAL, :EMP_DEP)";
            oracleCommand2.CommandText = sql_insert;

            oracleCommand2.Parameters[0].Value = textBox1.Text;
            oracleCommand2.Parameters[1].Value = textBox2.Text;
            oracleCommand2.Parameters[2].Value = textBox3.Text;
            oracleCommand2.Parameters[3].Value = textBox7.Text;
            oracleCommand2.Parameters[4].Value = textBox8.Text;
            oracleCommand2.Parameters[5].Value = textBox9.Text;

            oracleCommand2.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oracleCommand3.Connection = oracleConnection1;
            string sql_dep_insert = "INSERT INTO DEPT(DEPTNO, DNAME, LOC) VALUES(:DEPTNO, :DNAME, :LOC)";
            oracleCommand3.CommandText = sql_dep_insert;

            oracleCommand3.Parameters[0].Value = textBox4.Text;
            oracleCommand3.Parameters[1].Value = textBox5.Text;
            oracleCommand3.Parameters[2].Value = textBox6.Text;

            oracleCommand3.ExecuteNonQuery();

            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql_delete = "DELETE FROM EMP WHERE EMPNO =:EMPNO";
            oracleCommand4.Connection = oracleConnection1;
            oracleCommand4.CommandText = sql_delete;

            oracleCommand4.Parameters[0].Value = textBox1.Text;

            oracleCommand4.ExecuteNonQuery();

            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql_trans_dep = "UPDATE EMP SET EMP_DEP = :EMP_DEP WHERE EMPNO = :EMPNO";
            oracleCommand5.Connection = oracleConnection1;

            oracleCommand5.CommandText = sql_trans_dep;
            oracleCommand5.Parameters[0].Value = textBox10.Text;
            oracleCommand5.Parameters[1].Value = textBox1.Text;

            oracleCommand5.ExecuteNonQuery();

            textBox1.Text = "";
            textBox10.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql_search_empno = "SELECT * FROM EMP WHERE EMPNO = :EMPNO";
            oracleCommand6.Connection = oracleConnection1;
            oracleCommand6.CommandText = sql_search_empno;

            oracleCommand6.Parameters[0].Value = textBox1.Text;

            OracleDataReader rdr = oracleCommand6.ExecuteReader();
            listBox1.Items.Clear();

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["EMPNO"] + " " + rdr["ENAME"] + " " + rdr["JOB"] + " " + "부서번호 : " + rdr["EMP_DEP"]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql_search_ename = "SELECT * FROM EMP WHERE ENAME LIKE :ENAME";

            oracleCommand6.Connection = oracleConnection1;
            oracleCommand6.CommandText = sql_search_ename;

            oracleCommand6.Parameters[0].Value = "%" + textBox2.Text + "%";

            OracleDataReader rdr = oracleCommand6.ExecuteReader();
            listBox1.Items.Clear();

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["EMPNO"] + " " + rdr["ENAME"] + " " + rdr["JOB"] + " " + "부서번호 : " + rdr["EMP_DEP"]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql_search_emp_dep = "SELECT * FROM EMP WHERE EMP_DEP = :EMP_DEP";

            oracleCommand6.Connection = oracleConnection1;
            oracleCommand6.CommandText = sql_search_emp_dep;

            oracleCommand6.Parameters[0].Value = textBox9.Text;

            OracleDataReader rdr = oracleCommand6.ExecuteReader();
            listBox1.Items.Clear();

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["EMPNO"] + " " + rdr["ENAME"] + " " + rdr["JOB"] + " " + "부서번호 : " + rdr["EMP_DEP"]);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql_view_all = "SELECT * FROM EMP";
            oracleCommand1.CommandText = sql_view_all;

            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            listBox1.Items.Clear();

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["EMPNO"] + " " + rdr["ENAME"] +" " + rdr["JOB"] + " " + "부서번호 : " + rdr["EMP_DEP"]);
            }

        }
    }
}
