﻿namespace _20231016_실습
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter27 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter28 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter29 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter30 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter31 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter32 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter33 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter34 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter35 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter36 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter37 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter38 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter39 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oracleCommand2 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand4 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand5 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand6 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.oracleConnection2 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ChunkMigrationConnectionTimeout = "120";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "변경할 부서";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox10.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox10.Location = new System.Drawing.Point(116, 264);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(152, 31);
            this.textBox10.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Pink;
            this.button5.Location = new System.Drawing.Point(621, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "부서 이동";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox9.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox9.Location = new System.Drawing.Point(100, 219);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 31);
            this.textBox9.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "월급";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox8.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8.Location = new System.Drawing.Point(100, 173);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(168, 31);
            this.textBox8.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "채용날짜";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox7.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.Location = new System.Drawing.Point(100, 131);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(168, 31);
            this.textBox7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "업무";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(294, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(480, 172);
            this.listBox1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Location = new System.Drawing.Point(462, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "사원 삭제";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(294, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "사원 번호로 검색";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(294, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "사원 추가";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(100, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 31);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(100, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(100, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "근무 부서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "사원 이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원 번호";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox6.Location = new System.Drawing.Point(433, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 31);
            this.textBox6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "부서 위치";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(247, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "부서 추가";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox5.Location = new System.Drawing.Point(433, 154);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 31);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox4.Location = new System.Drawing.Point(433, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 31);
            this.textBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "부서 이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "부서 번호";
            // 
            // oracleCommand2
            // 
            oracleParameter27.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter27.ParameterName = "EMPNO";
            oracleParameter28.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter28.ParameterName = "ENAME";
            oracleParameter29.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter29.ParameterName = "JOB";
            oracleParameter30.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter30.ParameterName = "HIREDATE";
            oracleParameter31.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter31.ParameterName = "SAL";
            oracleParameter32.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter32.ParameterName = "DEPNO";
            this.oracleCommand2.Parameters.Add(oracleParameter27);
            this.oracleCommand2.Parameters.Add(oracleParameter28);
            this.oracleCommand2.Parameters.Add(oracleParameter29);
            this.oracleCommand2.Parameters.Add(oracleParameter30);
            this.oracleCommand2.Parameters.Add(oracleParameter31);
            this.oracleCommand2.Parameters.Add(oracleParameter32);
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            oracleParameter33.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter33.ParameterName = "DEPTNO";
            oracleParameter34.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter34.ParameterName = "DEPTNAME";
            oracleParameter35.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter35.ParameterName = "LOC";
            this.oracleCommand3.Parameters.Add(oracleParameter33);
            this.oracleCommand3.Parameters.Add(oracleParameter34);
            this.oracleCommand3.Parameters.Add(oracleParameter35);
            this.oracleCommand3.Transaction = null;
            // 
            // oracleCommand4
            // 
            oracleParameter36.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter36.ParameterName = "EMPNO";
            this.oracleCommand4.Parameters.Add(oracleParameter36);
            this.oracleCommand4.Transaction = null;
            // 
            // oracleCommand5
            // 
            oracleParameter37.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter37.ParameterName = "EMPNO";
            oracleParameter38.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter38.ParameterName = "DEPTNO";
            this.oracleCommand5.Parameters.Add(oracleParameter37);
            this.oracleCommand5.Parameters.Add(oracleParameter38);
            this.oracleCommand5.Transaction = null;
            // 
            // oracleCommand6
            // 
            oracleParameter39.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter39.ParameterName = "NAME";
            this.oracleCommand6.Parameters.Add(oracleParameter39);
            this.oracleCommand6.Transaction = null;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Pink;
            this.button6.Location = new System.Drawing.Point(294, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 37);
            this.button6.TabIndex = 18;
            this.button6.Text = "사원 이름으로 검색";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Pink;
            this.button7.Location = new System.Drawing.Point(294, 134);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button7.Size = new System.Drawing.Size(224, 37);
            this.button7.TabIndex = 19;
            this.button7.Text = "근무 부서로 검색";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "부서 추가 페이지";
            // 
            // oracleConnection2
            // 
            this.oracleConnection2.ChunkMigrationConnectionTimeout = "120";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Pink;
            this.button8.Location = new System.Drawing.Point(524, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 127);
            this.button8.TabIndex = 20;
            this.button8.Text = "전체 인원 조회";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button5;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand5;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection2;
    }
}

