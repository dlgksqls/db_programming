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
    public partial class Member : Form
    {
        public Member(string user_name)
        { 
            InitializeComponent();
            label1.Text = user_name;
        }
        DataTable user;
        DataTable product;
        DataTable buying;
        DataTable review;
        DataTable add_new;
        DataTable change_price;
        DataTable buying_request;
        DataTable refund_request;
        DataTable bag;
        DataTable refund;
        int total_price = 0;

        private void Member_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet12.BUYING_REQUEST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // this.buyinG_REQUESTTableAdapter1.Fill(this.dataSet12.BUYING_REQUEST);
            // TODO: 이 코드는 데이터를 'dataSet11.REFUND_REQUEST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.refunD_REQUESTTableAdapter1.Fill(this.dataSet11.REFUND_REQUEST);
            // TODO: 이 코드는 데이터를 'dataSet11.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet11.PRODUCT);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.pRODUCTTableAdapter.FillBy(this.dataSet1.PRODUCT,label1.Text);

            memberTableAdapter1.Fill(dataSet1.MEMBER);
            pRODUCTTableAdapter.Fill(dataSet1.PRODUCT);
            buyingTableAdapter1.Fill(dataSet1.BUYING);
            reviewTableAdapter1.Fill(dataSet1.REVIEW);
            producT_ADDTableAdapter1.Fill(dataSet1.PRODUCT_ADD);
            changE_PRICETableAdapter1.Fill(dataSet1.CHANGE_PRICE);
            buyinG_REQUESTTableAdapter1.Fill(dataSet12.BUYING_REQUEST);
            refunD_REQUESTTableAdapter1.Fill(dataSet1.REFUND_REQUEST);
            refundTableAdapter1.Fill(dataSet1.REFUND);
            bagTableAdapter1.Fill(dataSet1.BAG);
            
            user = dataSet1.Tables["MEMBER"];
            product = dataSet1.Tables["PRODUCT"];
            buying = dataSet1.Tables["BUYING"];
            review = dataSet1.Tables["REVIEW"];
            add_new = dataSet1.Tables["PRODUCT_ADD"];
            change_price = dataSet1.Tables["CHANGE_PRICE"];
            buying_request = dataSet12.Tables["BUYING_REQUEST"];
            refund_request = dataSet1.Tables["REFUND_REQUEST"];
            refund = dataSet1.Tables["REFUND"];
            bag = dataSet1.Tables["BAG"];

            bUYINGBindingSource.Filter = "BUY_MEMBER = '" + label1.Text + "'";
            bUYINGBindingSource1.Filter = "REFUND IS NULL AND BUY_MEMBER = '" + label1.Text + "'";
            bUYINGREQUESTBindingSource.Filter = "BUY_MEMBER = '" + label1.Text + "' AND BEG_ID IS NULL";

            List<string> myItems = new List<string>();
            DataRow[] myitem = buying.Select("BUY_MEMBER ='" + label1.Text + "'");

            foreach (DataRow i in myitem)
                myItems.Add(i["BUY_PRODUCT"].ToString());

            HashSet<string> set_Items = new HashSet<string>(myItems);

            myItems.Clear();
            myItems.AddRange(set_Items);

            comboBox1.DataSource = myItems;

            List<string> addItems = new List<string>();
            DataTable addItem = dataSet1.Tables["PRODUCT"];

            foreach (DataRow i in addItem.Rows)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;


            //DataRow new_product = add_new.Rows.;
            //DataRow new_product = add_new.Columns();

            foreach (DataRow new_product in add_new.Rows)
            {
                MessageBox.Show(new_product["NAME"] + " " + new_product["PRICE"] + " " + new_product["AMOUNT"] +"개가 " + new_product["ADD_DATE"] + "에 입고되었습니다.");
            }

            foreach (DataRow row in add_new.Rows)
            {
                DataRow del = add_new.Rows.Find(row["NAME"]);
                del.Delete();
            }
            producT_ADDTableAdapter1.Update(dataSet1.PRODUCT_ADD);

            bUYINGBindingSource.Filter = "BUY_MEMBER = '" + label1.Text + "'";

            rEFUNDREQUESTBindingSource.Filter = "MEMBER = '" + label1.Text + "'";

            foreach (DataRow changed_price in change_price.Rows)
            {
                MessageBox.Show(changed_price["PRODUCT"] + "의 가격이 " + changed_price["BEFORE_PRICE"] + "원에서 " + changed_price["AFTER_PRICE"] + "원으로 변경되었습니다.");
            }
            foreach (DataRow row in change_price.Rows)
            {
                DataRow del = change_price.Rows.Find(row["CHANGE_ID"]);
                del.Delete();
            }
            changE_PRICETableAdapter1.Update(dataSet1.CHANGE_PRICE);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pRODUCTBindingSource.Filter != null)
            {
                pRODUCTBindingSource.RemoveFilter();
                button1.Text = "구매 가능 품목";
            }
            else
            {
                pRODUCTBindingSource.Filter = "AMOUNT <> 0";
                Console.WriteLine(pRODUCTBindingSource.Filter);
                button1.Text = "모든 상품 보기";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow buy_request = buying_request.NewRow();
            string select_product = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DataRow select_item = product.Rows.Find(select_product);


            if (select_item["AMOUNT"] != DBNull.Value && Convert.ToInt32(select_item["AMOUNT"]) == 0)
                MessageBox.Show("재고가 없는 상품은 구매가 불가능합니다.");
            else
            {
                buy_request["BUY_MEMBER"] = label1.Text;
                buy_request["SOLO_PRODUCT"] = select_product;
                buy_request["BUY_DATE"] = dateTimePicker3.Value;

                if (buying_request.Rows.Count > 0)
                {
                    int maxId = Convert.ToInt32(buying_request.Compute("MAX(BUYING_ID)", string.Empty));
                    int count = buying_request.Rows.Count;
                    buy_request["BUYING_ID"] = maxId + 1;
                }
                else
                {
                    buy_request["BUYING_ID"] = 1;
                }
                int product_amount = Convert.ToInt32(select_item["AMOUNT"]);
                select_item["AMOUNT"] = product_amount - 1;

                productTableAdapter1.Update(dataSet1.PRODUCT);
                buying_request.Rows.Add(buy_request);
                buyinG_REQUESTTableAdapter1.Update(dataSet1.BUYING_REQUEST);

                MessageBox.Show("구매요청 완료");
            }
            
            /*DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataRow userid = user.Rows.Find(label1.Text);
            DataRow select_item = product.Rows.Find(row.Cells[0].Value.ToString());
            DataRow new_buying = buying.NewRow();
            int lastBuyingId = buying.Rows.Count;*/

            /*DataRow review_add = review.NewRow();
            int review_key_max = review.Rows.Count;

            if (review_add["REVIEW_ID"] == DBNull.Value)
            {
                if (review_key_max == 0)
                    review_add["REVIEW_ID"] = 1;
                else
                    review_add["REVIEW_ID"] = review_key_max + 1;*/

            /*if (select_item["SOLD"] != DBNull.Value && Convert.ToInt32(select_item["SOLD"]) == 1)
                MessageBox.Show("재고가 없는 상품은 구매가 불가능합니다.");
            else
            {
                if (buying.Rows.Count > 0)
                {
                    new_buying["BUYING_ID"] = lastBuyingId + 1;
                    new_buying["BUYDATE"] = dateTimePicker1.Value;
                    new_buying["TOTALPRICE"] = select_item["PRICE"];
                    new_buying["BUY_MEMBER"] = userid["MEMBER_ID"];
                    new_buying["BUY_PRODUCT"] = select_item["PRODUCT_NAME"];
                    select_item["SOLD"] = 1;

                    if (select_item["SALES_NUMBER"] == DBNull.Value)
                        select_item["SALES_NUMBER"] = 1;
                    else
                    {
                        int sold_num = Convert.ToInt32(select_item["SALES_NUMBER"]);
                        select_item["SALES_NUMBER"] = sold_num + 1;
                    }
                    select_item["SALES_DATE"] = dateTimePicker1.Value;
                    select_item["SOLD_MEMBER"] = userid["MEMBER_ID"];

                    if (userid["PURCHASE_AMOUNT"] == DBNull.Value)
                    {
                        int item_price = Convert.ToInt32(select_item["PRICE"]);
                        userid["PURCHASE_AMOUNT"] = item_price;
                    }
                    else
                    {
                        int sold_member = Convert.ToInt32(userid["PURCHASE_AMOUNT"]);
                        int item_price = Convert.ToInt32(select_item["PRICE"]);
                        userid["PURCHASE_AMOUNT"] = sold_member + item_price;
                    }

                    if (userid["BUYING_COUNT"] == DBNull.Value)
                        userid["BUYING_COUNT"] = 1;
                    else
                    {
                        int buy_count = Convert.ToInt32(userid["BUYING_COUNT"]);
                        userid["BUYING_COUNT"] = buy_count + 1;
                    }

                    buying.Rows.Add(new_buying);
                    memberTableAdapter1.Update(dataSet1.MEMBER);
                    pRODUCTTableAdapter.Update(dataSet1.PRODUCT);
                    buyingTableAdapter1.Update(dataSet1.BUYING);
                    MessageBox.Show("구매 완료");
                }
                else
                {
                    new_buying["BUYING_ID"] = 1;
                    new_buying["BUYDATE"] = dateTimePicker1.Value;
                    new_buying["TOTALPRICE"] = select_item["PRICE"];
                    new_buying["BUY_MEMBER"] = userid["MEMBER_ID"];
                    new_buying["BUY_PRODUCT"] = select_item["PRODUCT_NAME"];
                    select_item["SOLD"] = 1;

                    if (select_item["SALES_NUMBER"] == DBNull.Value)
                        select_item["SALES_NUMBER"] = 1;
                    else
                    {
                        int sold_num = Convert.ToInt32(select_item["SALES_NUMBER"]);
                        select_item["SALES_NUMBER"] = sold_num + 1;
                    }
                    select_item["SALES_DATE"] = dateTimePicker1.Value;
                    select_item["SOLD_MEMBER"] = userid["MEMBER_ID"];

                    if (userid["PURCHASE_AMOUNT"] == DBNull.Value)
                    {
                        int item_price = Convert.ToInt32(select_item["PRICE"]);
                        userid["PURCHASE_AMOUNT"] = item_price;
                    }
                    else
                    {
                        int sold_member = Convert.ToInt32(userid["PURCHASE_AMOUNT"]);
                        int item_price = Convert.ToInt32(select_item["PRICE"]);
                        userid["PURCHASE_AMOUNT"] = sold_member + item_price;
                    }

                    if (userid["BUYING_COUNT"] == DBNull.Value)
                        userid["BUYING_COUNT"] = 1;
                    else
                    {
                        int buy_count = Convert.ToInt32(userid["BUYING_COUNT"]);
                        userid["BUYING_COUNT"] = buy_count + 1;
                    }

                    buying.Rows.Add(new_buying);
                    memberTableAdapter1.Update(dataSet1.MEMBER);
                    pRODUCTTableAdapter.Update(dataSet1.PRODUCT);
                    buyingTableAdapter1.Update(dataSet1.BUYING);
                    MessageBox.Show("구매 요청 완료.");
                }
            } */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow delete_user = user.Rows.Find(label1.Text);
            DataRow[] delete_row_buying = buying.Select("BUY_MEMBER ='" + label1.Text + "'");
            //DataRow[] delete_row_product = product.Select("SOLD_MEMBER ='" + label1.Text + "'");
                
            if (MessageBox.Show("계정 탈퇴를 하시겠습니까?", "계정 탈퇴",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoginForm showForm = new LoginForm();
                foreach(DataRow del_buying in delete_row_buying)
                {
                    del_buying["BUY_MEMBER"] = null;
                }

                /*foreach(DataRow del_product in delete_row_product)
                {
                    del_product["SOLD_MEMBER"] = null;
                }*/
                delete_user.Delete();

                buyingTableAdapter1.Update(dataSet1.BUYING);
                pRODUCTTableAdapter.Update(dataSet1.PRODUCT);
                memberTableAdapter1.Update(dataSet1.MEMBER);

                MessageBox.Show("지금까지 사용해주셔서 감사했습니다.");
                this.Visible = false;
                showForm.Show();
            }

            else
                return;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { 
            DataRow[] review_view = review.Select("PRODUCT='" + comboBox2.SelectedItem + "'");

            listBox1.Items.Clear();
            foreach(DataRow review_check in review_view)
            {
                listBox1.Items.Add(review_check["PRODUCT"] + " '" + review_check["CONTENT"] + "' '" + review_check["MEMBER"] + "'님이 작성한 리뷰");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DataRow review_add = review.NewRow();
            int review_key_max = review.Rows.Count;

            if (review_add["REVIEW_ID"] == DBNull.Value)
            {
                if (review_key_max == 0)
                    review_add["REVIEW_ID"] = 1;
                else
                    review_add["REVIEW_ID"] = review_key_max + 1;
            }
            review_add["PRODUCT"] = comboBox1.SelectedItem;
            review_add["MEMBER"] = label1.Text;
            review_add["CONTENT"] = textBox2.Text;

            review.Rows.Add(review_add);
            reviewTableAdapter1.Update(dataSet1.REVIEW);
            MessageBox.Show("리뷰 작성 완료");
            textBox2.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        { 
            pRODUCTBindingSource.Filter = "TYPE = '악기'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '과자'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '껌'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '애견용품'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '인테리어'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '건강식품'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '차'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '주류'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '음료수'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '스포츠용품'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '야채'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '욕실'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '차량용'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '빵'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '담배'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '소스/양념'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '과일'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '문구류'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '요가'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "TYPE = '도서'";
            Console.WriteLine(pRODUCTBindingSource.Filter);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*List<string> myItems = new List<string>();
            DataRow[] my_item = buying.Select("BUY_MEMBER ='" + label1.Text + "'");

            foreach (DataRow i in my_item)
                myItems.Add(i["BUY_PRODUCT"].ToString());

            comboBox1.DataSource = myItems;

            List<string> addItems = new List<string>();
            DataTable addItem = dataSet1.Tables["PRODUCT"];

            foreach (DataRow i in addItem.Rows)
                addItems.Add(i["PRODUCT_NAME"].ToString());
            comboBox2.DataSource = addItems;*/
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = "";
        }

        /*private void button4_Click(object sender, EventArgs e)
        {
            string select_item = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            DataRow refund_item = buying.Rows.Find(select_item);
            DataRow login_id = user.Rows.Find(label1.Text);
            DataRow select_refund_request = refund_request.NewRow();

            if (MessageBox.Show("환불을 요청하시겠습니까?", "물품 환불",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = refund_request.Rows.Count;

                if (!Convert.IsDBNull(refund_item["BUYDATE"]))
                {
                    // Safe to convert because the value is not DBNull.
                    string value = Convert.ToString(refund_item["BUYDATE"]);
                    MessageBox.Show(value);
                }
                else
                {
                    MessageBox.Show("NULL");
                }*/

                /*if (Convert.ToDateTime(refund_item["BUYDATE"]) > dateTimePicker2.Value)
                    MessageBox.Show("구매날짜 이후의 것만 환불할 수 있습니다.");
                else
                {
                    if (count > 0)
                    {
                        int maxId = Convert.ToInt32(refund_request.Compute("MAX(REFUND_ID)", string.Empty));
                        select_refund_request["REFUND_ID"] = maxId + 1;
                        select_refund_request["MEMBER"] = login_id["MEMBER_ID"];
                        select_refund_request["PRODUCT"] = refund_item["BUY_PRODUCT"];
                        select_refund_request["REQUEST_DATE"] = dateTimePicker2.Value;
                    }
                    else
                    {
                        select_refund_request["REFUND_ID"] = 1;
                        select_refund_request["MEMBER"] = login_id["MEMBER_ID"];
                        select_refund_request["PRODUCT"] = refund_item["BUY_PRODUCT"];
                        select_refund_request["REQUEST_DATE"] = dateTimePicker2.Value;
                    }

                    refund_item["REFUND"] = 1;

                    refund_request.Rows.Add(select_refund_request);
                    refunD_REQUESTTableAdapter1.Update(dataSet1.REFUND_REQUEST);
                    buyingTableAdapter1.Update(dataSet1.BUYING);



                    this.refunD_REQUESTTableAdapter1.Fill(this.dataSet11.REFUND_REQUEST);
                    bUYINGBindingSource.Filter = "REFUND IS NULL";

                    dataGridView2.Refresh();
                    dataGridView3.Refresh();
                }
            }
            else
                return;
        }*/

        private void button28_Click(object sender, EventArgs e)
        {
            string select_item = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
            DataRow refund_item = buying.Rows.Find(select_item);
            DataRow login_id = user.Rows.Find(label1.Text);
            DataRow select_refund_request = refund_request.NewRow();

            if (MessageBox.Show("환불을 요청하시겠습니까?", "물품 환불",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = refund_request.Rows.Count;

                /*if (!Convert.IsDBNull(refund_item["BUYDATE"]))
                {
                    // Safe to convert because the value is not DBNull.
                    string value = Convert.ToString(refund_item["BUYDATE"]);
                    MessageBox.Show(value);
                }
                else
                {
                    MessageBox.Show("NULL");
                }*/

                if (Convert.ToDateTime(refund_item["BUYDATE"]) > dateTimePicker3.Value)
                    MessageBox.Show("구매날짜 이후의 것만 환불할 수 있습니다.");
                else
                {
                    if (count > 0)
                    {
                        int maxId = Convert.ToInt32(refund_request.Compute("MAX(REFUND_ID)", string.Empty));
                        select_refund_request["REFUND_ID"] = maxId + 1;
                        select_refund_request["MEMBER"] = login_id["MEMBER_ID"];
                        select_refund_request["PRODUCT"] = refund_item["BUY_PRODUCT"];
                        select_refund_request["REQUEST_DATE"] = dateTimePicker3.Value;
                    }
                    else
                    {
                        select_refund_request["REFUND_ID"] = 1;
                        select_refund_request["MEMBER"] = login_id["MEMBER_ID"];
                        select_refund_request["PRODUCT"] = refund_item["BUY_PRODUCT"];
                        select_refund_request["REQUEST_DATE"] = dateTimePicker3.Value;
                    }

                    refund_item["REFUND"] = 1;

                    refund_request.Rows.Add(select_refund_request);
                    refunD_REQUESTTableAdapter1.Update(dataSet1.REFUND_REQUEST);
                    buyingTableAdapter1.Update(dataSet1.BUYING);



                    this.refunD_REQUESTTableAdapter1.Fill(this.dataSet11.REFUND_REQUEST);
                    bUYINGBindingSource1.Filter = "REFUND IS NULL AND BUY_MEMBER = '" + label1.Text + "'";

                    dataGridView4.Refresh();
                    dataGridView5.Refresh();
                }
            }
            else
                return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm showForm = new LoginForm();
            this.Visible = false;
            showForm.FormClosed += (s, args) => Application.Exit();
            showForm.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string select_item = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();

            DataRow buying_request_bag = buying_request.NewRow();
            DataRow selected_item = product.Rows.Find(select_item);

            //DataRow shopping_bag = bag.NewRow();
            //int total_price = 0;
            int bag_count = bag.Rows.Count;
            int bag_id;

            int now_amount = Convert.ToInt32(selected_item["AMOUNT"]);
            int select_price = Convert.ToInt32(selected_item["PRICE"]);

            if (now_amount == 0)
                MessageBox.Show("재고가 없는 상품은 넣을 수 없습니다.");
            else
            {
                selected_item["AMOUNT"] = now_amount - 1;
                buying_request_bag["BUY_MEMBER"] = label1.Text;
                buying_request_bag["SOLO_PRODUCT"] = select_item;


                if (buying_request.Rows.Count > 0)
                {
                    int maxId = Convert.ToInt32(buying_request.Compute("MAX(BUYING_ID)", string.Empty));
                    buying_request_bag["BUYING_ID"] = maxId + 1;
                }
                else
                    buying_request_bag["BUYING_ID"] = 1;

                if (bag.Rows.Count > 0)
                {
                    int maxId = Convert.ToInt32(bag.Compute("MAX(ID)", string.Empty));
                    buying_request_bag["BEG_ID"] = maxId + 1;
                    bag_id = maxId + 1;
                }
                else
                {
                    buying_request_bag["BEG_ID"] = 1;
                    bag_id = 1;
                }



                buying_request_bag["BUY_DATE"] = dateTimePicker2.Value;
                total_price += select_price;
                label2.Text = "총" + " " + Convert.ToString(total_price) + "원";



                buying_request.Rows.Add(buying_request_bag);
                buyinG_REQUESTTableAdapter1.Update(dataSet12.BUYING_REQUEST);
                productTableAdapter1.Update(dataSet1.PRODUCT);

                buyinG_REQUESTTableAdapter1.Fill(dataSet12.BUYING_REQUEST);

                dataGridView3.Refresh();
                dataGridView6.Refresh();

                bUYINGREQUESTBindingSource.Filter = "BUY_MEMBER = '" + label1.Text + "' AND BEG_ID = " + bag_id;

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            DataRow shopping_bag = bag.NewRow();

            if (bag.Rows.Count > 0)
            {
                int maxId = Convert.ToInt32(bag.Compute("MAX(ID)", string.Empty));
                shopping_bag["ID"] = maxId + 1;
            }
            else
                shopping_bag["ID"] = 1;
            shopping_bag["BAG_MEMBER"] = label1.Text;
            shopping_bag["BAG_DATE"] = dateTimePicker2.Value;
            shopping_bag["AMOUNT"] = label2.Text.Substring(2, label2.Text.Length - 3);

            bag.Rows.Add(shopping_bag);
            bagTableAdapter1.Update(dataSet1.BAG);

            bUYINGREQUESTBindingSource.Filter = "BUY_MEMBER = '" + label1.Text + "' AND BEG_ID IS NULL";

            MessageBox.Show("장바구니 요청 완료");

            total_price = 0;
            label2.Text = "price";
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("배달을 시키시면 3000원의 배달비가 발생합니다.","배달 요청",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRow shopping_bag = bag.NewRow();
                DataRow request_user = user.Rows.Find(label1.Text);

                if (bag.Rows.Count > 0)
                {
                    int maxId = Convert.ToInt32(bag.Compute("MAX(ID)", string.Empty));
                    shopping_bag["ID"] = maxId + 1;
                }
                else
                    shopping_bag["ID"] = 1;
                shopping_bag["BAG_MEMBER"] = label1.Text;
                shopping_bag["BAG_DATE"] = dateTimePicker2.Value;

                if (request_user["GRADE"] == DBNull.Value)
                {
                    shopping_bag["AMOUNT"] = Convert.ToInt32(label2.Text.Substring(2, label2.Text.Length - 3));
                    shopping_bag["DRIVE"] = 3000;
                }
                else if (Convert.ToInt32(request_user["GRADE"]) == 2)
                {
                    shopping_bag["AMOUNT"] = Convert.ToInt32(label2.Text.Substring(2, label2.Text.Length - 3));
                    shopping_bag["DRIVE"] = 6000;
                    MessageBox.Show("당신은 불량고객이니 배송비가 두배 추가결제됩니다.");
                }
                else if (Convert.ToInt32(request_user["GRADE"]) == 1)
                {
                    shopping_bag["AMOUNT"] = Convert.ToInt32(label2.Text.Substring(2, label2.Text.Length - 3));
                    shopping_bag["DRIVE"] = 0;
                    MessageBox.Show("당신은 우수고객이니 배송비가 없습니다.");
                }
                bag.Rows.Add(shopping_bag);
                bagTableAdapter1.Update(dataSet1.BAG);

                bUYINGREQUESTBindingSource.Filter = "BUY_MEMBER = '" + label1.Text + "' AND BEG_ID IS NULL";

                MessageBox.Show("장바구니 요청 완료");

                total_price = 0;
                label2.Text = "price";
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button48.Text+"'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button32.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button45.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button30.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button37.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button42.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button33.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button47.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button46.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button38.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button43.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button50.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button36.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button34.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button39.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button40.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button49.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button44.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button41.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            List<string> addItems = new List<string>();
            DataRow[] gum = product.Select("TYPE='" + button35.Text + "'");

            foreach (DataRow i in gum)
            {
                addItems.Add(i["PRODUCT_NAME"].ToString());
            }

            HashSet<string> setItems = new HashSet<string>(addItems);
            addItems.Clear();
            addItems.AddRange(setItems);

            comboBox2.DataSource = addItems;
        }
    }
}