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
    public partial class FormFillBuys : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT ;
        DataTable CustDT1 = new DataTable();
        DataTable CustDT2 = new DataTable();
        OleDbDataAdapter CustDA;
        OleDbDataAdapter CustDA1;
        OleDbCommand OperEdit;
        OleDbCommand ItemQEdit;
        double TotalGAllPill = 0, TotalBAllPill = 0, EarnAllPill = 0, DiscAllPill = 0;        
        //----------------------------------------------
        int MaxId = 1,CountItemsPill=0;
        int Idd;
        int Idsale;
        public int INDEX = 0;
        //----------------------------------------------
        public FormFillBuys()
        {
            InitializeComponent();
            TxtNumPimpo.KeyPress += ClassGenric.AhadiTextNum;
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
            CustDA = new OleDbDataAdapter("SELECT operation.id_oper, operation.id_buy, operation.item_oper, items.numpar_item, items.price_item, items.quantity_item, operation.buy_quntity, operation.buy_discound, operation.buy_unitprice, operation.buy_totalG, operation.buy_totalB, operation.buy_earn, operation.date_oper, operation.time_oper, operation.user_oper, operation.buy_notes, operation.operitemEnd, operation.buy_unit FROM items , operation where items.name_item = operation.item_oper and id_buy = " + PillBuy_ID.Text + "", con);
            CustDA.Fill(CustDT2);
            dgvBuy.DataSource = CustDT2;
        }
        //دالة تعمل على إرجاع أكبر ادي في جدول المشتريات
        public void getIdSale()
        {
            CustDT = new DataTable();
            CustDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            CustDA1 = new OleDbDataAdapter("SELECT * FROM buypill", con);
            CustDA1.Fill(CustDT1);
            //   MAX(id_user) 
            CustDA = new OleDbDataAdapter("SELECT MAX(id_buy) FROM buypill", con);
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
            PillBuy_ID.Text = (MaxId).ToString();
        }
        //دالة التنظيف
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
                    ImpoPhone.Text = "";
                    ImpoId.Text = "";
                    buy_ExtsraDiscount.Text = "0";
                }
            }
            getIdSale();
            PillBuy_ID.Text = (MaxId).ToString();
            DPDFPillBuy.Value = DateTime.Now.Date;
            DPTPillBuy.Value = DateTime.Now;
            cash.Checked = false;
            pro.Checked = false;            
        }
        private void FormFillSale_Load(object sender, EventArgs e)
        {

        }
        //DGV دالة تلوين الخلايا القابلة للتعديل من 
        private void FillColor()
        {
            dgvBuy.Columns[16].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvBuy.Columns[16].DefaultCellStyle.ForeColor = Color.White;
            dgvBuy.Columns[8].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvBuy.Columns[8].DefaultCellStyle.ForeColor = Color.White;
            dgvBuy.Columns[9].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvBuy.Columns[9].DefaultCellStyle.ForeColor = Color.White;
            dgvBuy.Columns[10].DefaultCellStyle.BackColor = Color.FromArgb(45, 55, 77);
            dgvBuy.Columns[10].DefaultCellStyle.ForeColor = Color.White;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
        //البحث عن مورد    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            new FormSImpo().ShowDialog();
            INDEX =ClassGenric.Ahadi_indexG();
            if (INDEX == -1)
                return;
            else
            {
                try
                {
                CustDT.Clear();
                CustDT = new DataTable();
                CustDA = new OleDbDataAdapter("SELECT * FROM importer", con);
                CustDA.Fill(CustDT);
                ImpoId.Text = CustDT.Rows[INDEX]["id_impo"].ToString();
                
                }
                catch (Exception xx)
                {
                    ImpoPhone.Text = "";
                    ImpoId.Text = "";
                    ImpoName.Text = "";
                }
            }           
        }
        //الإكمل التلقائي للبحق عن مورد
        private void CustId_TextChanged(object sender, EventArgs e)
        {
            CustDT.Clear();
            CustDT = new DataTable();
            CustDA = new OleDbDataAdapter("SELECT * FROM importer where id_impo like '%" + ImpoId.Text + "%'", con);
            CustDA.Fill(CustDT);
            if (CustDT.Rows.Count > 0&& ImpoId.Text != "")
            {
               
                    ImpoPhone.Text = CustDT.Rows[0]["phone_impo"].ToString();
                    ImpoId.Text = CustDT.Rows[0]["id_impo"].ToString();
                    ImpoName.Text = CustDT.Rows[0]["name_impo"].ToString();               
            }
            else
            {
                ImpoName.Text = "غير موجود";
            }
        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {
            CustDT.Clear();
            CustDT = new DataTable();
            CustDA = new OleDbDataAdapter("SELECT * FROM importer where name_impo like '%" + ImpoName.Text + "%'", con);
            CustDA.Fill(CustDT);
            if (CustDT.Rows.Count > 0 && (ImpoName.Text != ""&& ImpoName.Text != "غير موجود"))
            {

                ImpoPhone.Text = CustDT.Rows[0]["phone_impo"].ToString();
                ImpoId.Text = CustDT.Rows[0]["id_impo"].ToString();
                ImpoName.Text = CustDT.Rows[0]["name_impo"].ToString();
            }
            else
            {
                ImpoPhone.Text = "غير موجود";
                ImpoId.Text = "";
            }

        }
        //فتح نافذة إضافة صنف
        public void Button1_Click(object sender, EventArgs e)
        {
            ClassGenric.Ahadi_Cols(0);
            Idsale = Convert.ToInt32(PillBuy_ID.Text);          
            using (FormItemsSelect f=new FormItemsSelect(Idsale, PillBuyUser.Text))
            {
                f.ShowDialog();
                getTable();             
            }
            PillFoterCallculat();
        }

        private void FormFillSale_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Insert)
            {
                Button1_Click(sender, e);
            }
        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                Idd = dgvBuy.CurrentRow.Index;
            }
            catch (Exception ex) { }
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSale_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double TotalG, TotalB, unitp,Earn, dis;
            int Q = 0;
            DateTime de=DateTime.Now.Date;
            string Note = "";
            try {
                    Q = Convert.ToInt32(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[6].Value);
                    dis = Convert.ToDouble(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[7].Value);             
                     de = Convert.ToDateTime(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[16].Value);
                      Note = (dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[15].Value).ToString();
                      TotalG = Convert.ToInt32(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[6].Value) * Convert.ToInt32(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[4].Value);
                      TotalB = TotalG - (TotalG * (dis/100));
                      unitp = TotalB / Q;
                      Earn = TotalG - TotalB;
                  OleDbCommand cmd;
                  cmd = new OleDbCommand("update operation set buy_quntity = "+ Q + " ,buy_discound = " + dis + ",buy_notes = '" + Note + "',operitemEnd = #" + de.ToString() + "#,buy_totalG ="+TotalG+ ",buy_totalB =" + TotalB +",buy_earn ="+Earn+",buy_unitprice= "+unitp+" where id_oper = " + Convert.ToInt32(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[0].Value) + "", con);
                  con.Open();
                  cmd.ExecuteNonQuery();
                  con.Close();
                  getTable();
                PillFoterCallculat();
            }
            catch (Exception xx)
            { getTable(); }
           
        }

        private void PillFoterCallculat()
        {
            TotalGAllPill = 0; TotalBAllPill = 0; EarnAllPill = 0; DiscAllPill = 0;
            for (int i = 0; i < dgvBuy.Rows.Count ; i++)
            {                
                TotalGAllPill += Convert.ToInt32(dgvBuy.Rows[i].Cells[9].Value);
                TotalBAllPill += Convert.ToInt32(dgvBuy.Rows[i].Cells[10].Value);
                //CountItemsPill += Convert.ToInt32(dgvBuy.Rows[i].Cells[6].Value);
                DiscAllPill += Convert.ToDouble(dgvBuy.Rows[i].Cells[7].Value);
                EarnAllPill+= Convert.ToDouble(dgvBuy.Rows[i].Cells[11].Value);
            }
            // Item_Count.Text = CountItemsPill.ToString();
            Item_Count.Text = dgvBuy.Rows.Count.ToString();
            TotalG_BuyPill.Text = TotalGAllPill.ToString();
            TotalB_BuyPill.Text = TotalBAllPill.ToString();
            Discount_BuyPill.Text = DiscAllPill.ToString();
            Earn_BuyPill.Text = (EarnAllPill).ToString();
            DiscPrsint.Text = (DiscAllPill / 100).ToString() + "%";
            EaenParins.Text= (EarnAllPill / 100).ToString() + "%";
        }
        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }
        //حذف سجل من الفاتورة
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
            {
                Idd = Convert.ToInt32(dgvBuy.Rows[dgvBuy.CurrentRow.Index].Cells[0].Value);
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
        //حفظ الفاتورة
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            CustDT.Clear();
            if (ImpoName.Text == "")
            {
                new MessagBoxH(2, " ادخل اسم المورد ").ShowDialog();
                ImpoName.Focus();
            }
            else if (TxtNumPimpo.Text == "")
            {
                new MessagBoxH(2, " ادخل رقم فاتورة المورد").ShowDialog();
                TxtNumPimpo.Focus();
            }
            else if (pro.Checked == false && cash.Checked == false)
                new MessagBoxH(2, " ادخل نوع الفاتورة ").ShowDialog();
            else if (!(dgvBuy.Rows.Count > 0))
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
                    CustDT.Rows[Idnew]["id_buy"] = PillBuy_ID.Text;
                    CustDT.Rows[Idnew]["buy_impo"] = ImpoName.Text;
                    CustDT.Rows[Idnew]["date_buy"] = DPDFPillBuy.Value;
                    CustDT.Rows[Idnew]["time_buy"] = DPTPillBuy.Value;
                    if (cash.Checked == true)
                    {
                        CustDT.Rows[Idnew]["type_buy"] = cash.Text;
                    }
                    else
                    CustDT.Rows[Idnew]["type_buy"] = pro.Text;
                    CustDT.Rows[Idnew]["buy_countitems"] = Convert.ToInt32(Item_Count.Text);
                    CustDT.Rows[Idnew]["buy_discount"] = Convert.ToInt32(Discount_BuyPill.Text);
                    CustDT.Rows[Idnew]["buy_totalB"] = Convert.ToInt32(TotalB_BuyPill.Text);
                    CustDT.Rows[Idnew]["buy_totalG"] = Convert.ToInt32(TotalG_BuyPill.Text);                  
                    if (Amount_Piad.Text == "")
                        Amount_Piad.Text = "0";                    
                    CustDT.Rows[Idnew]["buy_Amount_Piad"] = Convert.ToInt32(Amount_Piad.Text);
                    CustDT.Rows[Idnew]["buy_Amount_Rem"] = Convert.ToInt32(Amount_Rem.Text);
                    CustDT.Rows[Idnew]["buy_earn"] = Convert.ToDouble(Earn_BuyPill.Text);
                    if (buy_ExtsraDiscount.Text != "")
                        CustDT.Rows[Idnew]["buy_ExtsraDiscount"] = Convert.ToDouble(buy_ExtsraDiscount.Text);
                    else
                        CustDT.Rows[Idnew]["buy_ExtsraDiscount"] = 0;
                    CustDT.Rows[Idnew]["buy_user"] = PillBuyUser.Text;
                    OleDbCommandBuilder save = new OleDbCommandBuilder(CustDA);
                    CustDA.Update(CustDT);
                    CustDT.AcceptChanges();
                    /////==================================================
                    // حفظ البيانات بالعلاقة يحتوي
                    //for (int i = 0; i < dgvBuy.Rows.Count-1; i++)
                    //{
                    //    OperEdit = new OleDbCommand("Update operation set buy_discount=" + Convert.ToDouble(dgvBuy.Rows[i].Cells[7].Value) + ",buy_earn=" + Convert.ToDouble(dgvBuy.Rows[i].Cells[11].Value) + ",buy_notes='" + (dgvBuy.Rows[i].Cells[15].Value).ToString() + "',buy_totalG=" + Convert.ToDouble(dgvBuy.Rows[i].Cells[9].Value) + ",buy_unitprice=" + Convert.ToDouble(dgvBuy.Rows[i].Cells[5].Value) + ",operitemEnd= '" + Convert.ToDateTime(dgvBuy.Rows[i].Cells[16].Value).ToString() + "' where id_oper=" + Convert.ToInt32(dgvBuy.Rows[i].Cells[0].Value) + "", con);
                    //    con.Open();
                    //    OperEdit.ExecuteNonQuery();
                    //    con.Close();
                    //}
                    /////==================================================
                    ///////==================================================
                    ///تعديل كمية الأصناف في جدول الاصناف

                    for (int i = 0; i < dgvBuy.Rows.Count; i++)
                    {
                        double Quitems = 0;
                        Quitems = (Convert.ToInt32(dgvBuy.Rows[i].Cells[6].Value) + Convert.ToInt32(dgvBuy.Rows[i].Cells[5].Value));
                        ItemQEdit = new OleDbCommand("Update items set quantity_item=" + Quitems + " where name_item='" + (dgvBuy.Rows[i].Cells[2].Value).ToString() + "'", con);
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
                { new MessagBoxH(2,  xx.Message).ShowDialog(); }
                finally { con.Close(); }
                ClearTextBox();
            }
                      
        }


        private void DiscountValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Piad_TextChanged(object sender, EventArgs e)
        { if (Amount_Piad.Text != "")                
            Amount_Rem.Text = (TotalBAllPill - Convert.ToDouble(Amount_Piad.Text)).ToString();
        }

        private void buy_ExtsraDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Item_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImpoName_Enter(object sender, EventArgs e)
        {
            if (ImpoName.Text == "غير موجود")
            {
                ImpoName.Text = "";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumPimpo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
