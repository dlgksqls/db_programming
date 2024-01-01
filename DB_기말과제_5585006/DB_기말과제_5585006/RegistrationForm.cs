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
    public partial class RegistrationForm : Form
    {
        DataTable member;
        DataTable seller;
        DataTable manager;
        int password_check;
        public RegistrationForm()
        {
            InitializeComponent();

            memberTableAdapter1.Fill(dataSet11.MEMBER);
            sellerTableAdapter1.Fill(dataSet11.SELLER);
            managerTableAdapter1.Fill(dataSet11.MANAGER);

            member = dataSet11.Tables["MEMBER"];
            seller = dataSet11.Tables["SELLER"];
            manager = dataSet11.Tables["MANAGER"];
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            DataRow add_member = member.NewRow();
            DataRow common_id = member.Rows.Find(textBoxID.Text);
            DataRow common_id_seller = seller.Rows.Find(textBoxID.Text);
            DataRow common_id_manager = manager.Rows.Find(textBoxID.Text);

            if (textBoxID.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요");
            }
            else if (textBoxName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요");
            }
            else
            {
                if (password_check == 0)
                {
                    MessageBox.Show("비밀번호 확인을 해주세요.");
                    textBoxPasswordCheck.Text = "";
                }
                else
                {
                    if ((common_id != null && common_id["MEMBER_ID"] != null) || (common_id_seller != null && common_id_seller["SELLER_ID"] != null)
                        || (common_id_manager != null && common_id_manager["MANAGER_ID"] != null))
                    {
                        MessageBox.Show("중복되는 계정이 있습니다!!");
                        textBoxID.Text = "";
                    }
                    else
                    {
                        add_member["MEMBER_ID"] = textBoxID.Text;
                        add_member["PASSWORD"] = textBoxPassword.Text;
                        add_member["NAME"] = textBoxName.Text;
                        member.Rows.Add(add_member);
                        memberTableAdapter1.Update(dataSet11.MEMBER);
                        MessageBox.Show("가입 완료!");

                        LoginForm showForm = new LoginForm();
                        this.Visible = false;
                        showForm.FormClosed += (s, args) => Application.Exit();
                        showForm.Show();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password_check = 0;
            if (textBoxPassword.Text == textBoxPasswordCheck.Text)
            {
                password_check = 1;
                MessageBox.Show("비밀번호가 일치합니다.");
            }
            else
            {
                MessageBox.Show("비밀번호를 제대로 확인하세요.");
                textBoxPasswordCheck.Text = "";
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            password_check = 0;
        }
    }
}
