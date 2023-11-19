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
    public partial class FormSalePill : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        DataTable CustDT1 = new DataTable();
        DataTable CustDT2 = new DataTable();
        OleDbDataAdapter CustDA;
        OleDbDataAdapter CustDA1;
        OleDbCommand OperEdit;
        OleDbCommand ItemQEdit;
        double TotalGAllPill = 0, TotalBAllPill = 0, EarnAllPill = 0, DiscAllPill = 0;
        //----------------------------------------------
        int MaxId = 1, CountItemsPill = 0;
        int Idd;
        int Idsale;
        public int INDEX = 0;
        //----------------------------------------------
        public FormSalePill()
        {
            InitializeComponent();
            CustName.KeyPress += ClassGenric.AhadiTextNum;
            buy_ExtsraDiscount.KeyPress += ClassGenric.AhadiTextNum;
            Amount_Piad.KeyPress += ClassGenric.AhadiTextNum;
            Amount_Rem.KeyPress += ClassGenric.AhadiTextNum;            
            FillColor();
            getTable();
            PillFoterCallculat();
            pro.Checked = false;
        }
        //دالة تعبية جدول يحتوي
        public void getTable()
        {
            getIdSale();
            CustDT2.Clear();
            CustDA = new OleDbDataAdapter("SELECT operation.id_oper, operation.id_sale, operation.item_oper, items.numpar_item, items.price_item, items.quantity_item, operation.sale_quntity, operation.sale_discound, operation.sale_totalG, operation.sale_totalB, operation.date_oper, operation.time_oper, operation.user_oper, operation.sale_notes, operation.SaleitemEnd FROM items, operation where items.name_item = operation.item_oper and id_sale = " + Sale_ID.Text + "", con);
            CustDA.Fill(CustDT2);
            dgvSale.AutoGenerateColumns = false;
        }
        //دالة تعمل على إرجاع أكبر ادي في جدول المشتريات
        public void getIdSale()
        {
            CustDT = new DataTable();
            CustDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            CustDA1 = new OleDbDataAdapter("SELECT * FROM salepill", con);
            CustDA1.Fill(CustDT1);
            //   MAX(id_user) 
            CustDA = new OleDbDataAdapter("SELECT MAX(id_sal) FROM salepill", con);
            CustDA.Fill(CustDT);
            if (CustDT1.Rows.Count == 0)
            {
                MaxId = 1;
            }
            else
            {
                MaxId = Convert.ToInt32(CustDT.Rows[0][0]);
                MaxId += 1;
            }
            Sale_ID.Text = (MaxId).ToString();
        }
  
        private void FormBuyPill_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            new FormSearchCust().ShowDialog();
            INDEX = ClassGenric.Ahadi_indexG();
            if (INDEX == -1)
                return;
            else
            {
                try
                {
                    CustDT.Clear();
                    CustDT = new DataTable();
                    CustDA = new OleDbDataAdapter("SELECT * FROM customer", con);
                    CustDA.Fill(CustDT);
                    CustID.Text = CustDT.Rows[INDEX]["id_cust"].ToString();
                }
                catch (Exception xx)
                {
                    CustPhone.Text = "";
                    CustID.Text = "";
                    CustName.Text = "";
                }
            }
            }
        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Piad_TextChanged(object sender, EventArgs e)
        {
            if (Amount_Piad.Text != "")
                Amount_Rem.Text = (TotalBAllPill - Convert.ToDouble(Amount_Piad.Text)).ToString();
        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {
            CustDT.Clear();
            CustDT = new DataTable();
            CustDA = new OleDbDataAdapter("SELECT * FROM customer  where name_cust like '%" + CustName.Text + "%'", con);
            CustDA.Fill(CustDT);
            if (CustDT.Rows.Count > 0 && (CustName.Text != "" && CustName.Text != "غير موجود"))
            {

                CustPhone.Text = CustDT.Rows[0]["phon_cust"].ToString();
                CustID.Text = CustDT.Rows[0]["id_cust"].ToString();
                CustName.Text = CustDT.Rows[0]["name_cust"].ToString();
            }
            else
            {
                CustPhone.Text = "غير موجود";
                CustID.Text = "";
            }
        }

        private void CustName_Enter(object sender, EventArgs e)
        {
            if (CustName.Text == "غير موجود")
            {
                CustName.Text = "";
            }

        }

        private void CustID_TextChanged(object sender, EventArgs e)
        {
            CustDT.Clear();
            CustDT = new DataTable();
            CustDA = new OleDbDataAdapter("SELECT * FROM customer where id_cust like '%" + CustID.Text + "%'", con);
            CustDA.Fill(CustDT);
            if (CustDT.Rows.Count > 0 && CustID.Text != "")
            {

                CustPhone.Text = CustDT.Rows[0]["phon_cust"].ToString();
                CustID.Text = CustDT.Rows[0]["id_cust"].ToString();
                CustName.Text = CustDT.Rows[0]["name_cust"].ToString();
            }
            else
            {
                CustName.Text = "غير موجود";
            }
        }

        private void FormSalePill_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Insert)
            {
                BtnAddItem_Click(sender, e);
            }
        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Idd = dgvSale.CurrentRow.Index;
            }
            catch (Exception ex) { }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvSale.Rows.Count > 0)
            {
                Idd = Convert.ToInt32(dgvSale.Rows[dgvSale.CurrentRow.Index].Cells[0].Value);
                DataTable CustDT3 = new DataTable();
                OleDbCommand cmd;
                MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف السجل");
                mg.ShowDialog();
                if (mg.result())
                {
                    CustDT3.Clear();
                    cmd = new OleDbCommand("DELETE from operation where id_oper= " + Idd + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                    getTable();
                }
            }
            else
            {
                new MessagBoxH(2, "لا توجد سجلات!").ShowDialog();
            }
            PillFoterCallculat();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustDT.Clear();
            if (CustName.Text == "")
            {                
                CustName.Text="---";
            }          
            else if (pro.Checked == false && cash.Checked == false)
                new MessagBoxH(2, " ادخل نوع الفاتورة ").ShowDialog();
            else if (!(dgvSale.Rows.Count > 0))
                new MessagBoxH(2, " لا توجد بيانات ").ShowDialog();
            else if (cash.Checked && Amount_Piad.Text == "")
            {
                new MessagBoxH(2, "قم بإيصال مبلغ الفاتورة").ShowDialog();
                Amount_Piad.Focus();
            }
            else
            {
                try
                {

                    CustDA = new OleDbDataAdapter("SELECT * FROM buypill", con);
                    CustDA.Fill(CustDT);
                    CustDT.Rows.Add();
                    int Idnew = CustDT.Rows.Count - 1;
                    //----------------------------------------------------
                    CustDT.Rows[Idnew]["id_sal"] = Sale_ID.Text;
                    CustDT.Rows[Idnew]["sale_Cust"] = CustName.Text;
                    CustDT.Rows[Idnew]["date_buy"] = DPDFPillSale.Value;
                    CustDT.Rows[Idnew]["time_buy"] = DPTPillSale.Value;
                    if (cash.Checked == true)
                    {
                        CustDT.Rows[Idnew]["type_buy"] = cash.Text;
                    }
                    else
                        CustDT.Rows[Idnew]["type_buy"] = pro.Text;
                    CustDT.Rows[Idnew]["buy_countitems"] = Convert.ToInt32(Item_Count.Text);
                    CustDT.Rows[Idnew]["buy_discount"] = Convert.ToInt32(Discount_SalePill.Text);
                    CustDT.Rows[Idnew]["buy_totalB"] = Convert.ToInt32(TotalB_SalePill.Text);
                    CustDT.Rows[Idnew]["buy_totalG"] = Convert.ToInt32(TotalG_SalePill.Text);
                    if (Amount_Piad.Text == "")
                        Amount_Piad.Text = "0";
                    CustDT.Rows[Idnew]["buy_Amount_Piad"] = Convert.ToInt32(Amount_Piad.Text);
                    CustDT.Rows[Idnew]["buy_Amount_Rem"] = Convert.ToInt32(Amount_Rem.Text);
                    CustDT.Rows[Idnew]["buy_earn"] = Convert.ToDouble(Earn_SalePill.Text);
                    if (buy_ExtsraDiscount.Text != "")
                        CustDT.Rows[Idnew]["buy_ExtsraDiscount"] = Convert.ToDouble(buy_ExtsraDiscount.Text);
                    else
                        CustDT.Rows[Idnew]["buy_ExtsraDiscount"] = 0;
                    CustDT.Rows[Idnew]["buy_user"] = SalesMan.Text;
                    OleDbCommandBuilder save = new OleDbCommandBuilder(CustDA);
                    CustDA.Update(CustDT);
                    CustDT.AcceptChanges();
                    /////==================================================
                    // حفظ البيانات بالعلاقة يحتوي
                    //for (int i = 0; i < dgvSale.Rows.Count-1; i++)
                    //{
                    //    OperEdit = new OleDbCommand("Update operation set buy_discount=" + Convert.ToDouble(dgvSale.Rows[i].Cells[7].Value) + ",buy_earn=" + Convert.ToDouble(dgvSale.Rows[i].Cells[11].Value) + ",buy_notes='" + (dgvSale.Rows[i].Cells[15].Value).ToString() + "',buy_totalG=" + Convert.ToDouble(dgvSale.Rows[i].Cells[9].Value) + ",buy_unitprice=" + Convert.ToDouble(dgvSale.Rows[i].Cells[5].Value) + ",operitemEnd= '" + Convert.ToDateTime(dgvSale.Rows[i].Cells[16].Value).ToString() + "' where id_oper=" + Convert.ToInt32(dgvSale.Rows[i].Cells[0].Value) + "", con);
                    //    con.Open();
                    //    OperEdit.ExecuteNonQuery();
                    //    con.Close();
                    //}
                    /////==================================================
                    ///////==================================================
                    ///تعديل كمية الأصناف في جدول الاصناف

                    for (int i = 0; i < dgvSale.Rows.Count; i++)
                    {
                        double Quitems = 0;
                        Quitems = (Convert.ToInt32(dgvSale.Rows[i].Cells[6].Value) + Convert.ToInt32(dgvSale.Rows[i].Cells[5].Value));
                        ItemQEdit = new OleDbCommand("Update items set quantity_item=" + Quitems + " where name_item='" + (dgvSale.Rows[i].Cells[2].Value).ToString() + "'", con);
                        con.Open();
                        ItemQEdit.ExecuteNonQuery();
                        con.Close();
                    }

                    ///////==================================================
                    new MessagBoxH().ShowDialog();
                    ClearTextBox();
                    getTable();
                }
                catch (OleDbException xx)
                { new MessagBoxH(2, xx.Message).ShowDialog(); }
                finally { con.Close(); }
                ClearTextBox();
            }

        }
        public void ClearTextBox()
        {
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                    t.Text = "";
                foreach (Control t1 in t.Controls)
                {
                    if (t1 is TextBox)
                        t1.Text = "";
                    foreach (Control t2 in t1.Controls)
                    {
                        if (t2 is TextBox)
                            t2.Text = "";

                    }
                    CustPhone.Text = "";
                    CustID.Text = "";
                    buy_ExtsraDiscount.Text = "0";
                }
            }
            getIdSale();
            Sale_ID.Text = (MaxId).ToString();
            DPDFPillSale.Value = DateTime.Now.Date;
            DPTPillSale.Value = DateTime.Now;
            cash.Checked = false;
            pro.Checked = false;
        }
        //DGV دالة تلوين الخلايا القابلة للتعديل من 
        private void FillColor()
        {
            dgvSale.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvSale.Columns[2].DefaultCellStyle.ForeColor = Color.White;
            dgvSale.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvSale.Columns[5].DefaultCellStyle.ForeColor = Color.White;
            dgvSale.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvSale.Columns[7].DefaultCellStyle.ForeColor = Color.White;
            dgvSale.Columns[17].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvSale.Columns[17].DefaultCellStyle.ForeColor = Color.White;
        }
        private void PillFoterCallculat()
        {
            TotalGAllPill = 0; TotalBAllPill = 0; EarnAllPill = 0; DiscAllPill = 0;
            for (int i = 0; i < dgvSale.Rows.Count; i++)
            {
                TotalGAllPill += Convert.ToInt32(dgvSale.Rows[i].Cells[9].Value);
                TotalBAllPill += Convert.ToInt32(dgvSale.Rows[i].Cells[10].Value);
                //CountItemsPill += Convert.ToInt32(dgvSale.Rows[i].Cells[6].Value);
                DiscAllPill += Convert.ToDouble(dgvSale.Rows[i].Cells[7].Value);
                EarnAllPill += Convert.ToDouble(dgvSale.Rows[i].Cells[11].Value);
            }
            // Item_Count.Text = CountItemsPill.ToString();
            Item_Count.Text = dgvSale.Rows.Count.ToString();
            TotalG_SalePill.Text = TotalGAllPill.ToString();
            TotalB_SalePill.Text = TotalBAllPill.ToString();
            Discount_SalePill.Text = DiscAllPill.ToString();
            Earn_SalePill.Text = (EarnAllPill).ToString();
            DiscPrsint.Text = (DiscAllPill / 100).ToString() + "%";
            EaenParins.Text = (EarnAllPill / 100).ToString() + "%";
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            ClassGenric.Ahadi_Cols(1);
            Idsale = Convert.ToInt32(Sale_ID.Text);
            using (FormItemsSelect f = new FormItemsSelect(Idsale, SalesMan.Text))
            {
                f.ShowDialog();
                getTable();
            }
            PillFoterCallculat();
        }
    }
}
