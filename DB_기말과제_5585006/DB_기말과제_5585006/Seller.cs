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
    public partial class Seller : Form
    {
        DataTable member;
        DataTable product;
        DataTable buying_reqest;
        DataTable buying;
        DataTable refund;
        DataTable refund_request;
        DataTable bag;
        DataTable drive;
        public Seller(string seller_id)
        {
            InitializeComponent();
            label1.Text = seller_id;
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.BAG' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bAGTableAdapter.Fill(this.dataSet1.BAG);
            // TODO: 이 코드는 데이터를 'dataSet12.REFUND_REQUEST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEFUND_REQUESTTableAdapter.Fill(this.dataSet12.REFUND_REQUEST);
            // TODO: 이 코드는 데이터를 'dataSet1.BUYING_REQUEST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bUYING_REQUESTTableAdapter.Fill(this.dataSet1.BUYING_REQUEST);

            // TODO: 이 코드는 데이터를 'dataSet11.BUYING' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bUYINGTableAdapter.Fill(this.dataSet11.BUYING);

            productTableAdapter1.Fill(dataSet11.PRODUCT);
            memberTableAdapter1.Fill(dataSet11.MEMBER);
            refundTableAdapter1.Fill(dataSet11.REFUND);
            driveTableAdapter1.Fill(dataSet11.DRIVE);


            member = dataSet11.Tables["MEMBER"];
            product = dataSet11.Tables["PRODUCT"];
            buying_reqest = dataSet1.Tables["BUYING_REQUEST"];
            buying = dataSet11.Tables["BUYING"];
            refund = dataSet11.Tables["REFUND"];
            refund_request = dataSet12.Tables["REFUND_REQUEST"];
            bag = dataSet1.Tables["BAG"];
            drive = dataSet11.Tables["DRIVE"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int refund_number = 0;
            //int select_buy_id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            string select_member = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            //string select_product = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            int select_bag = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            DataRow new_drive = drive.NewRow();

            DataRow buy_member = member.Rows.Find(select_member);
            
            DataRow[] request = buying_reqest.Select("BEG_ID = " + select_bag);

            //DataRow buy_product = product.Rows.Find("BEG_ID = " + select_bag);
            
            DataRow bag_id = bag.Rows.Find(select_bag);

            if (MessageBox.Show(buy_member["MEMBER_ID"] + "님의 구매를 확정하겠습니까?", "구매 확정",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dateTimePicker2.Value < Convert.ToDateTime(bag_id["BAG_DATE"]))
                    MessageBox.Show("구매요청일자 이후에만 구매처리할 수 있습니다.");
                else
                {
                    //int sold_count = Convert.ToInt32(buy_product["SOLD"]);
                    foreach (DataRow request_product in request)
                    {
                        int lastBuyingId = buying.Rows.Count;
                        DataRow new_buying = buying.NewRow();
                        DataRow buying_product = product.Rows.Find(request_product["SOLO_PRODUCT"]);
                        int price = Convert.ToInt32(buying_product["PRICE"]);
                        if (buying.Rows.Count > 0)
                        {
                            
                            new_buying["BUYING_ID"] = lastBuyingId + 1;
                            new_buying["BUYDATE"] = dateTimePicker2.Value;
                            new_buying["TOTALPRICE"] = price;
                            new_buying["BUY_MEMBER"] = buy_member["MEMBER_ID"];
                            new_buying["BUY_PRODUCT"] = buying_product["PRODUCT_NAME"];
                            new_buying["TYPE"] = buying_product["TYPE"];
                            new_buying["SELLER"] = label1.Text;
                            //buy_product["SOLD"] = sold_count + 1;

                            if (buying_product["SALES_NUMBER"] == DBNull.Value)
                                buying_product["SALES_NUMBER"] = 1;
                            else
                            {
                                int sold_num = Convert.ToInt32(buying_product["SALES_NUMBER"]);
                                buying_product["SALES_NUMBER"] = sold_num + 1;
                            }
                            buying_product["SALES_DATE"] = bag_id["BAG_DATE"];
                            //buy_product["SOLD_MEMBER"] = buy_member["MEMBER_ID"];

                            /*if (buy_member["PURCHASE_AMOUNT"] == DBNull.Value)
                            {
                                int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                                buy_member["PURCHASE_AMOUNT"] = item_price;
                            }
                            else
                            {
                                int sold_member = Convert.ToInt32(buy_member["PURCHASE_AMOUNT"]);
                                int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                                buy_member["PURCHASE_AMOUNT"] = sold_member + item_price;
                            }*/

                            if (buy_member["BUYING_COUNT"] == DBNull.Value)
                                buy_member["BUYING_COUNT"] = 1;
                            else
                            {
                                int buy_count = Convert.ToInt32(buy_member["BUYING_COUNT"]);
                                buy_member["BUYING_COUNT"] = buy_count + 1;
                            }

                            //int product_amount = Convert.ToInt32(buy_product["AMOUNT"]);
                            //buy_product["AMOUNT"] = product_amount - 1;
                            //request.Delete();
                            //bag_id.Delete();
                            //new_buying["BAG_ID"] = select_bag;

                            buying.Rows.Add(new_buying);



                            productTableAdapter1.Update(dataSet11.PRODUCT);
                            bUYINGTableAdapter.Update(dataSet11.BUYING);
                            //bUYING_REQUESTTableAdapter.Update(dataSet1.BUYING_REQUEST);
                            //request_product.Delete();
                        }
                        else
                        {
                            new_buying["BUYING_ID"] = 1;
                            new_buying["BUYDATE"] = dateTimePicker2.Value;
                            new_buying["TOTALPRICE"] = price;
                            new_buying["BUY_MEMBER"] = buy_member["MEMBER_ID"];
                            new_buying["BUY_PRODUCT"] = buying_product["PRODUCT_NAME"];
                            new_buying["TYPE"] = buying_product["TYPE"];
                            new_buying["SELLER"] = label1.Text;
                            buying_product["SOLD"] = 1;

                            if (buying_product["SALES_NUMBER"] == DBNull.Value)
                                buying_product["SALES_NUMBER"] = 1;
                            else
                            {
                                int sold_num = Convert.ToInt32(buying_product["SALES_NUMBER"]);
                                buying_product["SALES_NUMBER"] = sold_num + 1;
                            }
                            buying_product["SALES_DATE"] = bag_id["BAG_DATE"];
                            //buy_product["SOLD_MEMBER"] = buy_member["MEMBER_ID"];

                            /*if (buy_member["PURCHASE_AMOUNT"] == DBNull.Value)
                            {
                                int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                                buy_member["PURCHASE_AMOUNT"] = item_price;
                            }
                            else
                            {
                                int sold_member = Convert.ToInt32(buy_member["PURCHASE_AMOUNT"]);
                                int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                                buy_member["PURCHASE_AMOUNT"] = sold_member + item_price;
                            }*/

                            if (buy_member["BUYING_COUNT"] == DBNull.Value)
                                buy_member["BUYING_COUNT"] = 1;
                            else
                            {
                                int buy_count = Convert.ToInt32(buy_member["BUYING_COUNT"]);
                                buy_member["BUYING_COUNT"] = buy_count + 1;
                            }
                            //int product_amount = Convert.ToInt32(buy_product["AMOUNT"]);
                            //buy_product["AMOUNT"] = product_amount - 1;

                            //request.Delete();
                            //bag_id.Delete();

                            //new_buying["BAG_ID"] = select_bag;
                            buying.Rows.Add(new_buying);


                            productTableAdapter1.Update(dataSet11.PRODUCT);
                            bUYINGTableAdapter.Update(dataSet11.BUYING);
                            //bUYING_REQUESTTableAdapter.Update(dataSet1.BUYING_REQUEST);
                            //request_product.Delete();
                        }
                    }

                    new_drive["MEMBER"] = buy_member["MEMBER_ID"];
                    new_drive["PRICE"] = bag_id["DRIVE"];
                    new_drive["REQUEST_DATE"] = dateTimePicker2.Value;

                    drive.Rows.Add(new_drive);


                    if (buy_member["PURCHASE_AMOUNT"] == DBNull.Value)
                    {
                        if (bag_id["DRIVE"] == DBNull.Value)
                        {
                            int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                            buy_member["PURCHASE_AMOUNT"] = item_price;
                        }
                        else
                        {
                            int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                            buy_member["PURCHASE_AMOUNT"] = item_price + Convert.ToInt32(bag_id["DRIVE"]);
                        }
                    }
                    else
                    {
                        if (bag_id["DRIVE"] == DBNull.Value)
                        {
                            int sold_member = Convert.ToInt32(buy_member["PURCHASE_AMOUNT"]);
                            int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                            buy_member["PURCHASE_AMOUNT"] = sold_member + item_price;
                        }
                        else{
                            int sold_member = Convert.ToInt32(buy_member["PURCHASE_AMOUNT"]);
                            int item_price = Convert.ToInt32(bag_id["AMOUNT"]);
                            buy_member["PURCHASE_AMOUNT"] = sold_member + item_price + Convert.ToInt32(bag_id["DRIVE"]);
                        }
                    }

                    if (buy_member["REFUND_COUNT"] == DBNull.Value)
                        refund_number = 0;
                    else
                        refund_number = Convert.ToInt32(buy_member["REFUND_COUNT"]);

                    int buying_number = Convert.ToInt32(buy_member["BUYING_COUNT"]);

                    buy_member["AMOUNT_REFUND"] = buying_number - refund_number;

                    MessageBox.Show("구매처리 완료");
                    bag_id.Delete();

                    DataRow[] delete_request = buying_reqest.Select("BEG_ID = " + select_bag);
                    foreach (DataRow delete in delete_request)
                    {
                        //DataRow delete_product_request = buying_reqest.Rows.Find(delete["BUYING_ID"]);
                        delete.Delete();
                    }



                    driveTableAdapter1.Update(dataSet11.DRIVE);
                    memberTableAdapter1.Update(dataSet11.MEMBER);
                    bUYING_REQUESTTableAdapter.Update(dataSet1.BUYING_REQUEST);
                    bAGTableAdapter.Update(dataSet1.BAG);
                    memberTableAdapter1.Fill(dataSet11.MEMBER);
                    productTableAdapter1.Fill(dataSet11.PRODUCT);
                    bUYINGTableAdapter.Fill(dataSet11.BUYING);
                    bUYING_REQUESTTableAdapter.Fill(dataSet1.BUYING_REQUEST);
                    bAGTableAdapter.Fill(dataSet1.BAG);
                }
            }
            else
                return; 
                //request.Delete();
                //bUYING_REQUESTTableAdapter.Update(dataSet1.BUYING_REQUEST);
            }
        private void button2_Click(object sender, EventArgs e)
        {
            int refund_number = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            string select_product = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            string select_member = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            int row_count = refund.Rows.Count;

            DataRow refund_product = product.Rows.Find(select_product);
            DataRow refund_member = member.Rows.Find(select_member);
            DataRow refund_list = refund.NewRow();
            DataRow request = refund_request.Rows.Find(refund_number);

            if (Convert.ToDateTime(request["REQUEST_DATE"]) > dateTimePicker1.Value)
                MessageBox.Show("환불 요청일자 이후에만 처리할 수 있습니다.");
            else
            {
                if (refund_member["REFUND_COUNT"] == DBNull.Value)
                    refund_member["REFUND_COUNT"] = 1;
                else
                {
                    int count = Convert.ToInt32(refund_member["REFUND_COUNT"]);
                    refund_member["REFUND_COUNT"] = count + 1;
                }

                if (refund_product["RETURN_NUMBER"] == DBNull.Value)
                    refund_product["RETURN_NUMBER"] = 1;
                else
                {
                    int count = Convert.ToInt32(refund_product["RETURN_NUMBER"]);
                    refund_product["RETURN_NUMBER"] = count + 1;
                }

                if (refund_product["AMOUNT"] == DBNull.Value)
                    refund_product["AMOUNT"] = 1;
                else
                {
                    int count = Convert.ToInt32(refund_product["AMOUNT"]);
                    refund_product["AMOUNT"] = count + 1;
                }

                if (row_count > 0)
                {
                    refund_list["REFUND_ID"] = row_count + 1;
                    refund_list["REFUND_DATE"] = dateTimePicker1.Value;
                    refund_list["REFUND_PRODUCT"] = select_product;
                    refund_list["REFUND_MEMBER"] = select_member;
                }
                else
                {
                    refund_list["REFUND_ID"] = 1;
                    refund_list["REFUND_DATE"] = dateTimePicker1.Value;
                    refund_list["REFUND_PRODUCT"] = select_product;
                    refund_list["REFUND_MEMBER"] = select_member;
                }

                request.Delete();
                refund.Rows.Add(refund_list);

                int refund_num = Convert.ToInt32(refund_member["REFUND_COUNT"]);
                int buying_number = Convert.ToInt32(refund_member["BUYING_COUNT"]);

                refund_member["AMOUNT_REFUND"] = buying_number - refund_num;

                rEFUND_REQUESTTableAdapter.Update(dataSet12.REFUND_REQUEST);
                refundTableAdapter1.Update(dataSet11.REFUND);
                productTableAdapter1.Update(dataSet11.PRODUCT);
                memberTableAdapter1.Update(dataSet11.MEMBER);

                MessageBox.Show("환불 처리 완료.");

                this.memberTableAdapter1.Fill(dataSet11.MEMBER);
                this.rEFUND_REQUESTTableAdapter.Fill(dataSet12.REFUND_REQUEST);
                this.productTableAdapter1.Fill(dataSet11.PRODUCT);
                this.refundTableAdapter1.Fill(dataSet11.REFUND);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm showForm = new LoginForm();
            this.Visible = false;
            showForm.FormClosed += (s, args) => Application.Exit();
            showForm.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MessageBox.Show("클릭!");
            int bag_id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            DataRow select_bag = bag.Rows.Find(bag_id);
            bUYINGREQUESTBindingSource.Filter = "BEG_ID =" + select_bag["ID"];*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("클릭!");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int bag_id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            DataRow select_bag = bag.Rows.Find(bag_id);
            bUYINGREQUESTBindingSource.Filter = "BEG_ID =" + select_bag["ID"];
        }
    }
}