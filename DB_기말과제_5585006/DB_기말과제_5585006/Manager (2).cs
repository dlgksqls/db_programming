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
    public partial class Manager : Form
    {
        DataTable product;
        DataTable add_product;
        DataTable member;
        DataTable change_price;
        DataTable save_price_change;
        DataTable save_add_product;
        DataTable type;
        DataTable date_price;
        DataTable refund_stats;
        DataTable refund_type;
        DataTable buy_stats;
        DataTable drive_date;
        public Manager()
        {
            InitializeComponent();
            pRODUCTTableAdapter.Fill(dataSet11.PRODUCT);
            product = dataSet11.Tables["PRODUCT"];
            producT_ADDTableAdapter1.Fill(dataSet11.PRODUCT_ADD);
            add_product = dataSet11.Tables["PRODUCT_ADD"];
            mEMBERTableAdapter.Fill(dataSet11.MEMBER);
            member = dataSet11.Tables["MEMBER"];
            changE_PRICETableAdapter1.Fill(dataSet11.CHANGE_PRICE);
            change_price = dataSet11.Tables["CHANGE_PRICE"];
            savE_PRICE_CHANGETableAdapter1.Fill(dataSet11.SAVE_PRICE_CHANGE);
            save_price_change = dataSet11.Tables["SAVE_PRICE_CHANGE"];
            adD_PRODUCT_SAVETableAdapter1.Fill(dataSet11.ADD_PRODUCT_SAVE);
            save_add_product = dataSet11.Tables["ADD_PRODUCT_SAVE"];
            typeTableAdapter1.Fill(dataSet1.TYPE);
            type = dataSet1.Tables["TYPE"];
            dATE_PRICETableAdapter.Fill(this.dataSet11.DATE_PRICE);
            date_price = dataSet11.Tables["DATE_PRICE"];
            rEFUND_STATSTableAdapter.Fill(dataSet12.REFUND_STATS);
            refund_stats = dataSet12.Tables["REFUND_STATS"];
            rEFUND_TYPETableAdapter.Fill(dataSet12.REFUND_TYPE);
            refund_type = dataSet12.Tables["REFUND_TYPE"];
            bUYING_STATSTableAdapter.Fill(dataSet13.BUYING_STATS);
            buy_stats = dataSet13.Tables["BUYING_STATS"];
            dATE_DRIVETableAdapter.Fill(dataSet13.DATE_DRIVE);
            drive_date = dataSet13.Tables["DATE_DRIVE"];


            pRODUCTBindingSource1.Filter = "";

            List<string> add_item = new List<string>();

            foreach (DataRow i in type.Rows)
                add_item.Add(i["NAME"].ToString());

            comboBox1.DataSource = add_item;
        }

        public void read_data()
        {
            // TODO: 이 코드는 데이터를 'dataSet12.ADD_PRODUCT_SAVE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.adD_PRODUCT_SAVETableAdapter1.Fill(this.dataSet12.ADD_PRODUCT_SAVE);
            // TODO: 이 코드는 데이터를 'dataSet12.SAVE_PRICE_CHANGE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.savE_PRICE_CHANGETableAdapter1.Fill(this.dataSet12.SAVE_PRICE_CHANGE);
            // TODO: 이 코드는 데이터를 'dataSet11.MEMBER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.mEMBERTableAdapter.Fill(this.dataSet11.MEMBER);
            // TODO: 이 코드는 데이터를 'dataSet11.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet11.PRODUCT);
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet14.REFUND_STATS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEFUND_STATSTableAdapter.Fill(this.dataSet14.REFUND_STATS);
            // TODO: 이 코드는 데이터를 'dataSet11.DATE_DRIVE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dATE_DRIVETableAdapter.Fill(this.dataSet11.DATE_DRIVE);
            // TODO: 이 코드는 데이터를 'dataSet11.DRIVE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dRIVETableAdapter.Fill(this.dataSet11.DRIVE);
            // TODO: 이 코드는 데이터를 'dataSet13.BUYING_STATS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bUYING_STATSTableAdapter.Fill(this.dataSet13.BUYING_STATS);
            // TODO: 이 코드는 데이터를 'dataSet11.REFUND_TYPE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEFUND_TYPETableAdapter.Fill(this.dataSet11.REFUND_TYPE);
            // TODO: 이 코드는 데이터를 'dataSet11.REFUND_STATS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEFUND_STATSTableAdapter.Fill(this.dataSet11.REFUND_STATS);
            // TODO: 이 코드는 데이터를 'dataSet11.BUYING' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bUYINGTableAdapter.Fill(this.dataSet11.BUYING);
            // TODO: 이 코드는 데이터를 'dataSet11.WEEK_TOTAL_PRICE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.wEEK_TOTAL_PRICETableAdapter.Fill(this.dataSet11.WEEK_TOTAL_PRICE);
            // TODO: 이 코드는 데이터를 'dataSet11.DATE_PRICE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.dATE_PRICETableAdapter.Fill(this.dataSet11.DATE_PRICE);
            //date_price = dataSet11.Tables["DATE_PRICE"];
            // TODO: 이 코드는 데이터를 'dataSet11.DAY_PRICE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dAY_PRICETableAdapter.Fill(this.dataSet11.DAY_PRICE);
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart3.ChartAreas[0].AxisX.Interval = 1;
            
            // TODO: 이 코드는 데이터를 'dataSet11.TYPE_PRICE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tYPE_PRICETableAdapter.Fill(this.dataSet11.TYPE_PRICE);
            // TODO: 이 코드는 데이터를 'dataSet12.ADD_PRODUCT_SAVE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.adD_PRODUCT_SAVETableAdapter1.Fill(this.dataSet12.ADD_PRODUCT_SAVE);
            // TODO: 이 코드는 데이터를 'dataSet12.SAVE_PRICE_CHANGE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.savE_PRICE_CHANGETableAdapter1.Fill(this.dataSet12.SAVE_PRICE_CHANGE);
            // TODO: 이 코드는 데이터를 'dataSet11.MEMBER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.mEMBERTableAdapter.Fill(this.dataSet11.MEMBER);
            // TODO: 이 코드는 데이터를 'dataSet11.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet11.PRODUCT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                pRODUCTBindingSource.Sort = "";
                pRODUCTBindingSource.Filter = "AMOUNT <> 0 OR AMOUNT IS NULL";
                Console.WriteLine(pRODUCTBindingSource.Filter);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                pRODUCTBindingSource.Filter = "RETURN_NUMBER IS NOT NULL";
                pRODUCTBindingSource.Sort = "RETURN_NUMBER DESC";
                Console.WriteLine(pRODUCTBindingSource.Filter);   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow add_new_product = product.NewRow();
            DataRow add_amount_product = product.Rows.Find(textBox1.Text);
            DataRow add_history = add_product.NewRow();
            DataRow save_product = save_add_product.NewRow();
            int amount = Convert.ToInt32(textBox7.Text);

            if (add_amount_product != null)
            {
                if (MessageBox.Show("기존에 있던 " + textBox1.Text + "상품의 재고를 " + textBox7.Text + "개 추가합니다.", "재고 추가",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int current_amount = Convert.ToInt32(add_amount_product["AMOUNT"]);
                    add_amount_product["AMOUNT"] = current_amount + amount;

                    add_history["NAME"] = textBox1.Text;
                    save_product["NAME"] = textBox1.Text;

                    //save_product["PRICE"] = textBox3.Text;

                    save_product["ADD_DATE"] = dateTimePicker1.Value;
                    add_history["ADD_DATE"] = dateTimePicker1.Value;

                    save_product["AMOUNT"] = amount;
                    add_history["AMOUNT"] = amount;

                    save_add_product.Rows.Add(save_product);
                    add_product.Rows.Add(add_history);

                    adD_PRODUCT_SAVETableAdapter1.Update(dataSet11.ADD_PRODUCT_SAVE);
                    pRODUCTTableAdapter.Update(dataSet11.PRODUCT);
                    producT_ADDTableAdapter1.Update(dataSet11.PRODUCT_ADD);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox7.Text = "";
                    textBox3.Text = "";

                    MessageBox.Show("추가 완료");
                }
            }
            else
                if (MessageBox.Show(textBox3.Text + "원의 " + textBox1.Text + "상품을 추가합니다!", "상품 추가",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                save_product["NAME"] = textBox1.Text;
                add_new_product["PRODUCT_NAME"] = textBox1.Text;
                add_history["NAME"] = textBox1.Text;

                save_product["TYPE"] = comboBox1.SelectedItem;
                add_new_product["TYPE"] = comboBox1.SelectedItem;
                add_history["TYPE"] = comboBox1.SelectedItem;

                add_new_product["AMOUNT"] = amount;
                save_product["PRICE"] = textBox3.Text;
                add_new_product["PRICE"] = textBox3.Text;
                add_history["PRICE"] = textBox3.Text;

                save_product["AMOUNT"] = amount;
                add_history["AMOUNT"] = amount;

                save_product["ADD_DATE"] = dateTimePicker1.Value;
                add_history["ADD_DATE"] = dateTimePicker1.Value;

                save_product["AMOUNT"] = amount;

                save_add_product.Rows.Add(save_product);
                product.Rows.Add(add_new_product);
                add_product.Rows.Add(add_history);

                adD_PRODUCT_SAVETableAdapter1.Update(dataSet11.ADD_PRODUCT_SAVE);
                pRODUCTTableAdapter.Update(dataSet11.PRODUCT);
                producT_ADDTableAdapter1.Update(dataSet11.PRODUCT_ADD);

                MessageBox.Show("추가 완료");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                dataGridView1.Refresh();
                dataGridView6.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mEMBERBindingSource.Filter != null)
            {
                mEMBERBindingSource.RemoveFilter();
                button4.Text = "우수 고객";
            }
            else
            {
                mEMBERBindingSource.Filter = "GRADE = 1";
                Console.WriteLine(mEMBERBindingSource.Filter);
                button4.Text = "모든 고객";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mEMBERBindingSource.Filter != null)
            {
                mEMBERBindingSource.RemoveFilter();
                button5.Text = "불량 고객";
            }
            else
            {
                mEMBERBindingSource.Filter = "GRADE = 2";
                Console.WriteLine(mEMBERBindingSource.Filter);
                button5.Text = "모든 고객";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mEMBERBindingSource.Filter != null)
            {
                mEMBERBindingSource.RemoveFilter();
                button9.Text = "일반 고객";
            }
            else
            {
                mEMBERBindingSource.Filter = "GRADE IS NULL OR GRADE = 0" ;
                Console.WriteLine(mEMBERBindingSource.Filter);
                button9.Text = "모든 고객";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string good_member_id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            DataRow good_member = member.Rows.Find(good_member_id);

            if (MessageBox.Show(good_member_id + "님을 우수고객으로 설정하시겠습니까?", "우수 고객",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                good_member["GRADE"] = 1;
                mEMBERTableAdapter.Update(dataSet11.MEMBER);

                MessageBox.Show(good_member_id + "님을 우수 고객으로 설정했습니다!");
            }
            dataGridView2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string bad_member_id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            DataRow good_member = member.Rows.Find(bad_member_id);

            if (MessageBox.Show(bad_member_id + "님을 불량고객으로 설정하시겠습니까?", "불량 고객",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                good_member["GRADE"] = 2;
                mEMBERTableAdapter.Update(dataSet11.MEMBER);

                MessageBox.Show(bad_member_id + "님을 불량 고객으로 설정했습니다!");
            }
            dataGridView2.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string select_product = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            string before_price = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            DataRow change_price_product = product.Rows.Find(select_product);
            DataRow add_change_price = change_price.NewRow();
            DataRow save_change_price = save_price_change.NewRow();

            if (MessageBox.Show(select_product + "의 가격을 " + before_price + "원에서 " + textBox6.Text + "원으로 변경하시겠습니까?", "가격 변동",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (change_price.Rows.Count == 0)
                {
                    add_change_price["CHANGE_ID"] = 1;
                }
                else
                {
                    int len = change_price.Rows.Count;
                    add_change_price["CHANGE_ID"] = len + 1;
                }

                if (save_price_change.Rows.Count == 0)
                {
                    save_change_price["CHANGE_ID"] = 1;
                }
                else
                {
                    int len = save_price_change.Rows.Count;
                    save_change_price["CHANGE_ID"] = len + 1;
                }
                add_change_price["BEFORE_PRICE"] = before_price;
                add_change_price["AFTER_PRICE"] = textBox6.Text;
                add_change_price["PRODUCT"] = select_product;

                save_change_price["BEFORE_PRICE"] = before_price;
                save_change_price["AFTER_PRICE"] = textBox6.Text;
                save_change_price["PRODUCT"] = select_product;

                change_price_product["PRICE"] = textBox6.Text;

                change_price.Rows.Add(add_change_price);
                save_price_change.Rows.Add(save_change_price);

                changE_PRICETableAdapter1.Update(dataSet11.CHANGE_PRICE);
                savE_PRICE_CHANGETableAdapter1.Update(dataSet11.SAVE_PRICE_CHANGE);
                pRODUCTTableAdapter.Update(dataSet11.PRODUCT);

                MessageBox.Show("가격 변동 완료!!");
                textBox5.Text = "";
                textBox6.Text = "";

                //read_data();
                dataGridView1.Refresh();
                dataGridView5.Refresh();
            }
        }
        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox5.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            read_data();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataRow search_member = member.Rows.Find(textBox4.Text);

            if (search_member != null)
                mEMBERBindingSource.Filter = "MEMBER_ID = '" + search_member["MEMBER_ID"] + "'";
            else
            {
                textBox4.Text = "";
                MessageBox.Show("찾고자 하는 회원이 없습니다.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

                pRODUCTBindingSource.Filter = "SALES_NUMBER IS NOT NULL";
                pRODUCTBindingSource.Sort = "SALES_NUMBER DESC";
                Console.WriteLine(pRODUCTBindingSource.Filter);         
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Sort = "";
            pRODUCTBindingSource.Filter = "";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LoginForm showForm = new LoginForm();
            this.Visible = false;
            showForm.FormClosed += (s, args) => Application.Exit();
            showForm.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int sum_date = 0;
            int sum_drive = 0;
            DataRow[] sum_price = date_price.Select("BUY_DATE >= #" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "# AND BUY_DATE <= #" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "#");
            DataRow[] drive_price = drive_date.Select("BUY_DATE >= #" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "# AND BUY_DATE <= #" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "#");
            dATEPRICEBindingSource.Filter = "BUY_DATE >= #" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "# AND BUY_DATE <= #" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "#";
            dATEDRIVEBindingSource.Filter = "BUY_DATE >= #" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "# AND BUY_DATE <= #" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "#";

            foreach (DataRow price in sum_price)
            {
                sum_date += Convert.ToInt32(price["DAILY_TOTAL"]);
            }
            foreach (DataRow drive in drive_price)
            {
                if (drive["DAILY_TOTAL"] == DBNull.Value)
                    sum_drive += 0;
                else
                    sum_drive += Convert.ToInt32(drive["DAILY_TOTAL"]);
            }
            int sum = sum_date + sum_drive;

            label9.Text = "총 " + sum.ToString() + "원";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // DateTimePicker에서 시작일과 종료일을 가져옵니다.
            DateTime startDate = dateTimePicker5.Value.Date;
            DateTime endDate = dateTimePicker4.Value.Date.AddDays(1);

            /*DataRow[] refund_stats_chart = refund_stats.Select("REFUND_DATE >= #" + startDate.ToString("yyyy-MM-dd") + "# AND REFUND_DATE <= #" + endDate.ToString("yyyy-MM-dd") + "#");
            DataRow[] refund_type_chart = refund_type.Select("REFUND_DATE >= #" + startDate.ToString("yyyy-MM-dd") + "# AND REFUND_DATE <= #" + endDate.ToString("yyyy-MM-dd") + "#");

            chart5.Series.Clear();
            chart6.Series.Clear();

            var series_1 = chart5.Series.Add("환불 횟수");
            var series_2 = chart6.Series.Add("환불 횟수");

            foreach (DataRow refund in refund_stats_chart)
            {
                series_1.Points.AddXY(refund.Field<string>("PRODUCT_NAME"), refund.Field<decimal>("RETURN_NUMBER"));
            }
            foreach (DataRow refund in refund_type_chart)
            {
                series_2.Points.AddXY(refund.Field<string>("TYPE"), refund.Field<decimal>("COUNT"));
            }*/

            // 필요한 날짜 범위에 해당하는 데이터를 선택합니다.
            IEnumerable<DataRow> selectedRows_1 = refund_stats.Select("REFUND_DATE >= #" + startDate.ToString("yyyy-MM-dd") + "# AND REFUND_DATE < #" + endDate.ToString("yyyy-MM-dd") + "#");
            IEnumerable<DataRow> selectedRows_2 = refund_type.Select("REFUND_DATE >= #" + startDate.ToString("yyyy-MM-dd") + "# AND REFUND_DATE < #" + endDate.ToString("yyyy-MM-dd") + "#");

            // 선택된 데이터를 상품 이름으로 그룹화하고 각 그룹의 구매 수를 합산합니다.
            var groupedData_1 = selectedRows_1
                .AsEnumerable()
                .GroupBy(row => row.Field<string>("PRODUCT_NAME"))
                .Select(group => new
                {
                    ProductName = group.Key,
                    TotalBuyNumber = group.Sum(row => row.Field<decimal>("COUNT"))
                });

            var groupedData_2 = selectedRows_2
                .AsEnumerable()
                .GroupBy(row => row.Field<string>("TYPE"))
                .Select(group => new
                {
                    Type = group.Key,
                    TotalBuyNumber = group.Sum(row => row.Field<decimal>("COUNT"))
                });

            chart5.Series.Clear();
            chart6.Series.Clear();

            var series_1 = chart5.Series.Add("환불횟수");
            var series_2 = chart6.Series.Add("환불횟수");

            // 그룹화하고 합산한 데이터를 차트에 추가합니다.
            foreach (var data in groupedData_1)
            {
                series_1.Points.AddXY(data.ProductName, (double)data.TotalBuyNumber);
            }
            foreach (var data in groupedData_2)
            {
                series_2.Points.AddXY(data.Type, (double)data.TotalBuyNumber);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            chart7.ChartAreas[0].AxisX.Interval = 1;
            // DateTimePicker에서 시작일과 종료일을 가져옵니다.
            DateTime startDate = dateTimePicker7.Value.Date;
            DateTime endDate = dateTimePicker6.Value.Date.AddDays(1);

            // 필요한 날짜 범위에 해당하는 데이터를 선택합니다.
            IEnumerable<DataRow> selectedRows = buy_stats.Select("BUYDATE >= #" + startDate.ToString("yyyy-MM-dd") + "# AND BUYDATE < #" + endDate.ToString("yyyy-MM-dd") + "#");

            // 선택된 데이터를 상품 이름으로 그룹화하고 각 그룹의 구매 수를 합산합니다.
            var groupedData = selectedRows
                .AsEnumerable()
                .GroupBy(row => row.Field<string>("PRODUCT_NAME"))
                .Select(group => new
                {
                    ProductName = group.Key,
                    TotalBuyNumber = group.Sum(row => row.Field<decimal>("COUNT"))
                });

            chart7.Series.Clear();
            var series = chart7.Series.Add("구매횟수");

            // 그룹화하고 합산한 데이터를 차트에 추가합니다.
            foreach (var data in groupedData)
            {
                series.Points.AddXY(data.ProductName, (double)data.TotalBuyNumber);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Sort = "AMOUNT DESC";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 5 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 10 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 15 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 20 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 25 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 30 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 35 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox5.Text);
            int sale_price = Convert.ToInt32(price - price * 40 / 100);
            textBox6.Text = Convert.ToString(sale_price);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DataRow find_product = product.Rows.Find(Convert.ToString(textBox1.Text));

            if (find_product != null)
            {
                textBox3.Text = Convert.ToString(find_product["PRICE"]);
                textBox2.Text = Convert.ToString(find_product["AMOUNT"]);
                comboBox1.Text = Convert.ToString(find_product["TYPE"]);
            }
            else
            {
                textBox3.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("새로운 물품을 추가해보세요.");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '악기'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '과자'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '껌'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '애견용품'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '인테리어'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '건강식품" +"'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '차'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '담배'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '과일'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '요가'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '주류'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '음료수'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '스포츠용품'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '야채'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '욕실'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '차량용'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '빵'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '소스/양념'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '문구류'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
            pRODUCTBindingSource.Filter = "TYPE = '도서'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }
    }
}
