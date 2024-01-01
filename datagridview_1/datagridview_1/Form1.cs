using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.VIEW2' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW2TableAdapter.Fill(this.dataSet11.VIEW2);
            // TODO: 이 코드는 데이터를 'dataSet1.EMP' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.eMPTableAdapter.Fill(this.dataSet11.EMP);
            // TODO: 이 코드는 데이터를 'dataSet1.DEPT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dEPTTableAdapter.Fill(this.dataSet11.DEPT);
            // TODO: 이 코드는 데이터를 'dataSet11.DEPT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dEPTTableAdapter.Fill(this.dataSet11.DEPT);
            // TODO: 이 코드는 데이터를 'dataSet11.EMP' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.eMPTableAdapter.FillBy(this.dataSet12.EMP,label2.Text);
            eMPBindingSource1.Filter = "EMP_DEP = '" + label2.Text + "'";

        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(MessageBox.Show("삭제하시겠습니까?", "행 삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                 e.Cancel = true;
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "행 삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eMPBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eMPBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int item_found = eMPBindingSource.Find("EMPNO", textBox1.Text);
            eMPBindingSource.Position = item_found;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(eMPBindingSource.Filter != null)
            {
                eMPBindingSource.RemoveFilter();
                button4.Text = "필터";
                textBox1.Text = "";
            }
            else
            {
                eMPBindingSource.Filter = "EMP_DEP=" + textBox1.Text + "";
                button4.Text = "필터해제";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = this.eMPTableAdapter.Update(dataSet11.EMP);
            if (number != 0)
            {
                MessageBox.Show("저장 완료!");
            }
            else
                MessageBox.Show("저장할 것이 없음");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = this.eMPTableAdapter.Update(dataSet11.EMP);
            if (number != 0)
            {
                MessageBox.Show("변경 완료!");
            }
            else
                MessageBox.Show("저장할 것이 없음");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dEPTBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dEPTBindingSource.RemoveCurrent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int count = this.dEPTTableAdapter.Update(dataSet11.DEPT);

            if (count != 0)
                MessageBox.Show("저장 완료!");
            else
                MessageBox.Show("저장할 것이 없음");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int count = this.dEPTTableAdapter.Update(dataSet11.DEPT);

            if (count != 0)
                MessageBox.Show("저장 완료!");
            else
                MessageBox.Show("저장할 것이 없음");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int itemfound = dEPTBindingSource.Find("DNAME", textBox2.Text);
            dEPTBindingSource.Position = itemfound;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dEPTBindingSource.Filter != null)
            {
                dEPTBindingSource.RemoveFilter();
                button11.Text = "필터";
            }
            else
            {
                dEPTBindingSource.Filter = "DEPTNO=" + textBox2.Text + "";
                button11.Text = "필터해제";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            eMPTableAdapter.FillByDept(dataSet11.EMP, textBox3.Text);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
                this.eMPTableAdapter.FillBy(this.dataSet11.EMP,textBox3.Text);

        }


        private void button14_Click(object sender, EventArgs e)
        {
            int val = (int)eMPTableAdapter.GetSeqVal();
            textBox4.Text = val.ToString();
        }


        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void fillByDeptToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.eMPTableAdapter.FillByDept(this.dataSet1.EMP, aaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }
    }
}
