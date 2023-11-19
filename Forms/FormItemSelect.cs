using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SuperSoft
{
   
    public partial class FormItemsSelect : Form 
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable ItemDT;
        DataTable ItemDT1;
        DataTable ItemDT2;
        OleDbDataAdapter dta;
        OleDbDataAdapter dta1;
        public int index = -1;
        public int Idsale;
        public string SaleFillUser;
        int Q,col;
        int dis;
        //=====================================================
        // متغيرات الحسابات
        string item;
        double Qty, disc, price, unitp, total, totalB, earn;
        //====================================================
        public void BuyCall()
        {
            try
            { 
            item = (dgvItem.Rows[dgvItem.CurrentRow.Index].Cells[1].Value).ToString();
            Qty = Convert.ToInt32(txtQ.Text);
            disc = (Convert.ToDouble(txtdisc.Text) / 100);
            price= Convert.ToInt32(dgvItem.Rows[dgvItem.CurrentRow.Index].Cells[3].Value);
                // اجمالي البيع
            total = Qty * price;
               // اجمالي الشراء بعد الخصم
            totalB = total-(total*disc);
                // اجمالي الشراء للوحدة الواحدة
            unitp = totalB / Qty;
                // اجمالي الشراء للوحدة الواحدة
            earn = total - totalB;
                //++++++++++++++++++++++++++++++++++++
                labelTG.Text = total.ToString()+"ر.ي";
                labelTB.Text = totalB.ToString() + "ر.ي";
                labelDis.Text = disc.ToString() + "ر.ي";
                labelEarn.Text = earn.ToString() + "ر.ي";
            }
            catch (Exception e)
            {
                labelTG.Text = "0 "+ "ر.ي";
                labelTB.Text = "0 "+ "ر.ي";
                labelDis.Text = "0 " + "ر.ي";
                labelEarn.Text = "0 "+ "ر.ي";
            }
        }
        public FormItemsSelect(int x ,string SaleFillU)
        {
            InitializeComponent();
            txtSearchItem.Focus();
            Idsale = x;
            SaleFillUser = SaleFillU;        
            txtdisc.KeyPress += ClassGenric.AhadiTextNum;
            txtQ.KeyPress += ClassGenric.AhadiTextNum;
            getTable();
            
            
        }
        private void getTable()
        {
            ItemDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM items", con);
            dta.Fill(ItemDT);
            dgvItem.DataSource = ItemDT;
            //ItemDT1 = new DataTable();
            //ItemDT1.Clear();
            //dta = new OleDbDataAdapter("SELECT * FROM unit_items", con);
            //dta.Fill(ItemDT1);
            //cmbUnitsItem.DataSource = ItemDT1;
            //cmbUnitsItem.DisplayMember = "name_unit";
            //cmbUnitsItem.ValueMember = "id_unit";           
            clear();
        }
            private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chichNorT()
        {

            if (Namei.Checked)
            {
                txtSearchItem.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchItem.KeyPress += ClassGenric.AhadiText;
                txtSearchItem.Text = "";
            }
            else if (Numi.Checked || parki.Checked)
            {
                txtSearchItem.KeyPress -= ClassGenric.AhadiText;
                txtSearchItem.KeyPress += ClassGenric.AhadiTextNum;
                txtSearchItem.Text = "";
            }
        }
        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            if(Namei.Checked)
            {
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where name_item like '%" + txtSearchItem.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }
            else if(Numi.Checked)
            {
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where id_item like '%" + txtSearchItem.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }
            else if(parki.Checked)
            {
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where numpar_item like '%" + txtSearchItem.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }           
        }

        private void Namei_CheckedChanged(object sender, EventArgs e)
        {
            chichNorT();
        }

        private void Numi_CheckedChanged(object sender, EventArgs e)
        {
            chichNorT();
        }

        private void parki_CheckedChanged(object sender, EventArgs e)
        {
            chichNorT();
        }
        private void labCloseFAddIt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            BuyCall();
        }

        private void txtdisc_TextChanged(object sender, EventArgs e)
        {
            BuyCall();
        }

        private void labelTB_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear()
        {
            cmbUnitsItem.Text = "اختر وحدة الصنف";
            txtQ.Text ="0";
            txtdisc.Text = "0";
            DPDEItem.Value = DateTime.Now.Date;
            txtNote.Text = "";
            labelTG.Text = "0 " + "ر.ي";
            labelTB.Text = "0 " + "ر.ي";
            labelDis.Text = "0 " + "ر.ي";
            labelEarn.Text = "0 " + "ر.ي";
        }
        private void EnterInPillBuy()
        {
            if (txtQ.Text == "0")
                new MessagBoxH(2, "الكمية غير صحيحة").ShowDialog();
            else if (DPDEItem.Value == DateTime.Now.Date || DPDEItem.Value <= DateTime.Now.Date)
                new MessagBoxH(2, "تاريخ الإنتهاء غير صحيح").ShowDialog();
            else if (index != -1)
            {
                BuyCall();//دالة الحساب 
                ItemDT.Clear();
                ItemDT2 = new DataTable();
                dta1 = new OleDbDataAdapter("SELECT * FROM items", con);
                dta1.Fill(ItemDT2);
                string NameItem = ItemDT2.Rows[index]["name_item"].ToString();
                Q = Convert.ToInt32(txtQ.Text);
                string Note = txtNote.Text;
                string U = "";
                DateTime DE = DPDEItem.Value;
                dis = Convert.ToInt32(txtdisc.Text);
                if (cmbUnitsItem.SelectedIndex == -1)
                    new MessagBoxH(2, "لم تحدد الوحدة").ShowDialog();
                else
                {
                    U = cmbUnitsItem.Text;
                    new MessagBoxH(0, "تم الإضافة بنجاح").ShowDialog();
                    clear();
                    OleDbCommand cmd;
                    cmd = new OleDbCommand("insert into operation (id_buy,item_oper,buy_quntity,buy_discound,buy_unit,buy_notes,operitemEnd,user_oper,buy_totalG,buy_totalB,buy_earn,buy_unitprice) values(" + Idsale + ",'" + NameItem + "'," + Q + "," + dis + ",'" + U + "','" + Note + "',#" + DE.ToString() + "#,'" + SaleFillUser + "'," + total + "," + totalB + "," + earn + "," + unitp + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    getTable();
                }
                //ClassGenric.Ahadi_Cols(0);                 
            }
        }
        private void EnterInPillSale()
        {
            if (txtQ.Text == "0")
                new MessagBoxH(2, "الكمية غير صحيحة").ShowDialog();
            else if (DPDEItem.Value == DateTime.Now.Date || DPDEItem.Value <= DateTime.Now.Date)
                new MessagBoxH(2, "تاريخ الإنتهاء غير صحيح").ShowDialog();
            else if (index != -1)
            {
                BuyCall();//دالة الحساب 
                ItemDT.Clear();
                ItemDT2 = new DataTable();
                dta1 = new OleDbDataAdapter("SELECT * FROM items", con);
                dta1.Fill(ItemDT2);
                string NameItem = ItemDT2.Rows[index]["name_item"].ToString();
                Q = Convert.ToInt32(txtQ.Text);
                string Note = txtNote.Text;
                string U = "";
                DateTime DE = DPDEItem.Value;
                dis = Convert.ToInt32(txtdisc.Text);
                if (cmbUnitsItem.SelectedIndex == -1)
                    new MessagBoxH(2, "لم تحدد الوحدة").ShowDialog();
                else
                {
                    U = cmbUnitsItem.Text;
                    new MessagBoxH(0, "تم الإضافة بنجاح").ShowDialog();
                    clear();
                    OleDbCommand cmd;
                    cmd = new OleDbCommand("insert into operation (id_buy,item_oper,sale_quntity,sale_discound,sale_unit,buy_notes,operitemEnd,user_oper,buy_totalG,buy_totalB,buy_earn,buy_unitprice) values(" + Idsale + ",'" + NameItem + "'," + Q + "," + dis + ",'" + U + "','" + Note + "',#" + DE.ToString() + "#,'" + SaleFillUser + "'," + total + "," + totalB + "," + earn + "," + unitp + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    getTable();
                }
                                 
            }
        }
        private void BtnEditCost_Click(object sender, EventArgs e)
        {
            ClassGenric.Ahadi_Cols();
            if (col == 0)
                EnterInPillBuy();
            else
                EnterInPillSale();
        }

        private void dgvItem_SelectionChanged(object sender, EventArgs e)
        {
            
            try
            {
                ItemDT1 = new DataTable();
                ItemDT1.Clear();
                dta = new OleDbDataAdapter("SELECT (name_unit_item) FROM items where ID_item=" + Convert.ToInt32(dgvItem.Rows[dgvItem.CurrentRow.Index].Cells[0].Value) + "", con);
                dta.Fill(ItemDT1);
                cmbUnitsItem.DataSource = ItemDT1;
                cmbUnitsItem.DisplayMember = "name_unit_item";
                index = dgvItem.CurrentRow.Index;
                BuyCall();                
            }
            catch (Exception x) { }
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvItem.CurrentRow.Index;
            //ClassGenric.Ahadi_index(index);
        }

        private void FormItemsSelect_Load(object sender, EventArgs e)
        {
            BuyCall();
        }

        private void cmbUnitsItem_SelectedIndexChanged(object sender, EventArgs e)
        {            

        }

      
    }
}
