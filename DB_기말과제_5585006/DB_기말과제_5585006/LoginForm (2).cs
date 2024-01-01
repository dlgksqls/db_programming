using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_기말과제_5585006
{
    public partial class LoginForm : Form
    {
        DataTable member;
        DataTable manager;
        DataTable seller;
        
        public LoginForm()
        {
            InitializeComponent();

            memberTableAdapter1.Fill(dataSet11.MEMBER);
            managerTableAdapter1.Fill(dataSet11.MANAGER);
            sellerTableAdapter1.Fill(dataSet11.SELLER);

            member = dataSet11.Tables["MEMBER"];
            manager = dataSet11.Tables["MANAGER"];
            seller = dataSet11.Tables["SELLER"];
        }
        public void LoadData()
        {
            memberTableAdapter1.Fill(dataSet11.MEMBER);
            managerTableAdapter1.Fill(dataSet11.MANAGER);
            sellerTableAdapter1.Fill(dataSet11.SELLER);

            member = dataSet11.Tables["MEMBER"];
            manager = dataSet11.Tables["MANAGER"];
            seller = dataSet11.Tables["SELLER"];
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                DataRow login_member = member.Rows.Find(textBoxID.Text);
                DataRow login_seller = seller.Rows.Find(textBoxID.Text);
                DataRow login_manager = manager.Rows.Find(textBoxID.Text);

                if (textPassword.Text != "")
                {
                    if (login_member != null && string.Equals(login_member["PASSWORD"],textPassword.Text))
                    {
                        MessageBox.Show(login_member["NAME"] + "회원님" + " 반갑습니다.");
                        Member showForm = new Member(textBoxID.Text);
                        this.Visible = false;
                        showForm.FormClosed += (s, args) => Application.Exit();
                        showForm.Show();
                        
                    }
                    else if (login_member != null && !string.Equals(login_member["PASSWORD"], textPassword.Text))
                    {
                        MessageBox.Show("비밀번호를 옳게 입력하세요.");
                        textPassword.Text = "";
                    }
                    else if (login_seller != null && string.Equals(login_seller["PASSWORD"], textPassword.Text))
                    {
                        MessageBox.Show("판매자 로그인");
                        Seller showForm = new Seller(textBoxID.Text);
                        this.Visible = false;
                        showForm.FormClosed += (s, args) => Application.Exit();
                        showForm.Show();
                    }
                    else if (login_seller != null && !string.Equals(login_seller["PASSWORD"], textPassword.Text))
                    {
                        MessageBox.Show("비밀번호를 옳게 입력하세요.");
                        textPassword.Text = "";
                    }
                    else if (login_manager != null && string.Equals(login_manager["PASSWORD"], textPassword.Text))
                    {
                        MessageBox.Show("관리자 로그인");
                        Manager showForm = new Manager();
                        this.Visible = false;
                        showForm.FormClosed += (s, args) => Application.Exit();
                        showForm.Show();
                    }
                    else if (login_manager != null && !string.Equals(login_manager["PASSWORD"], textPassword.Text))
                    {
                        MessageBox.Show("비밀번호를 옳게 입력하세요.");
                        textPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("존재하지 않는 아이디입니다.");
                        textBoxID.Text = "";
                        textPassword.Text = "";
                    }
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm showForm = new RegistrationForm();
            this.Visible = false;
            showForm.FormClosed += (s, args) => Application.Exit();
            showForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void LoginForm_Activated_1(object sender, EventArgs e)
        {
            // 여기에서 데이터를 다시 로드하는 코드를 작성합니다.
            this.Refresh();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
