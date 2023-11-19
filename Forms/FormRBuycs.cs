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
    public partial class FormRBuycs : Form
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
        int Idd, index=-1;
        int Idsale;
        public int INDEX = 0;
        //----------------------------------------------
        private void panel16_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DPDFPillBuy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillComboImpo()
        {
            CustDT = new DataTable();
            CustDT.Clear();
            CustDA = new OleDbDataAdapter("SELECT (name_impo) FROM importer", con);
            CustDA.Fill(CustDT);
            combImpo.DataSource = CustDT;
            combImpo.DisplayMember = "name_impo";
        }
        private void FillComboItem()
        {
            CustDT = new DataTable();
            CustDT.Clear();
            CustDA = new OleDbDataAdapter("SELECT (name_impo) FROM importer", con);
            CustDA.Fill(CustDT);
            combImpo.DataSource = CustDT;
            cmbGroubeItem.DisplayMember = "name_impo";
        }
        int id_buy = -1;
        private void combImpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try { 
            CustDT = new DataTable();
            CustDT.Clear();
            CustDA = new OleDbDataAdapter("SELECT * FROM importer where name_impo='"+ combImpo.Text+ "'", con);
            CustDA.Fill(CustDT);
            ImpoId.Text= CustDT.Rows[0]["id_impo"].ToString();
            ImpoPhone.Text = CustDT.Rows[0]["phone_impo"].ToString();
                //==========================================================================
            CustDT = new DataTable();
            CustDT.Clear();
            CustDA = new OleDbDataAdapter("SELECT (NPbuy_impo) FROM buypill where buy_impo='" + combImpo.Text + "'", con);
            CustDA.Fill(CustDT);
            compill.DataSource = CustDT;
                compill.DisplayMember = "NPbuy_impo";
                //==============================================================================
                CustDT = new DataTable();
                CustDT.Clear();
                CustDA = new OleDbDataAdapter("SELECT * FROM buypill where buy_impo='" + combImpo.Text + "' and NPbuy_impo='"+ compill.Text+ "'", con);
                CustDA.Fill(CustDT);
                id_buy= Convert.ToInt32(CustDT.Rows[0]["id_buy"]);
                //=============================================================================               
            }
            catch (Exception ex) { }
        }

        private void compill_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //==============================================================================
                CustDT = new DataTable();
                CustDT.Clear();
                CustDA = new OleDbDataAdapter("SELECT * FROM buypill where buy_impo='" + combImpo.Text + "' and NPbuy_impo= " +Convert.ToInt32(compill.Text) + "", con);
                CustDA.Fill(CustDT);
                id_buy = Convert.ToInt32(CustDT.Rows[0]["id_buy"]);                
                //=============================================================================               
                //==============================================================================
                CustDT = new DataTable();
                CustDT.Clear();
                CustDA = new OleDbDataAdapter("SELECT (item_oper) FROM operation where id_buy= " + id_buy + "", con);
                CustDA.Fill(CustDT);
                cmbGroubeItem.DataSource = CustDT;
                cmbGroubeItem.DisplayMember = "item_oper";
                //=============================================================================


            }
            catch (Exception ex) { }
        }

        private void comb()
        {

            
        }

        public FormRBuycs()
        {
            InitializeComponent();            
            TotalRBuy.KeyPress += ClassGenric.AhadiTextNum;
            Count_RBuy.KeyPress += ClassGenric.AhadiTextNum;
            ImpoId.KeyPress += ClassGenric.AhadiTextNum;
            ImpoPhone.KeyPress += ClassGenric.AhadiTextNum;
            txtRbuy.KeyPress += ClassGenric.AhadiTextNum;
            FillComboImpo();
        }
        public void getTable()
        {
            getIdSale();
            CustDT2.Clear();
            CustDA = new OleDbDataAdapter("", con);
            CustDA.Fill(CustDT2);
            dgvBuy.DataSource = CustDT2;

                        
        }
        public void getIdSale()
        {
            CustDT = new DataTable();
            CustDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            CustDA1 = new OleDbDataAdapter("SELECT * FROM rebuypill", con);
            CustDA1.Fill(CustDT1);
            //   MAX(id_user) 
            CustDA = new OleDbDataAdapter("SELECT MAX(id_rebuy) FROM rbuypill", con);
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
            txtRbuy.Text = (MaxId).ToString();
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
                    TotalRBuy.Text = "0";
                }
            }
            getIdSale();
            txtRbuy.Text = (MaxId).ToString();
            From_DPDRBuy.Value = DateTime.Now.Date;
            To_DPDRBuy.Value = DateTime.Now.Date;
            cash.Checked = false;
            pro.Checked = false;
            cmbGroubeItem.Text = "أصنف الفاتورة";
            combImpo.Text = "الموردين";
        }
    }
}
