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
    public partial class ReportBuy : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT = new DataTable();
        DataTable CustDT1 = new DataTable();
        DataTable CustDT2 = new DataTable();
        OleDbDataAdapter CustDA;
        int index = -1;
        public ReportBuy()
        {
            InitializeComponent();
            Filldgv_Buy();
            buypill_Count.Text = dgv_Buy.Rows.Count.ToString();
            DPDFPillBuy.Value = DateTime.Now.Date;
        }
        private void Filldgv_Buy()
        {
            try
            {
                double buy_Amount_Piad = 0, buy_Amount_R = 0;
                CustDT = new DataTable();
                CustDA = new OleDbDataAdapter("SELECT * FROM buypill", con);
                CustDA.Fill(CustDT);
                dgv_Buy.DataSource = CustDT;
                for (int i = 0; i < dgv_Buy.Rows.Count; i++)
                {
                    buy_Amount_Piad += (Convert.ToDouble(CustDT.Rows[i]["buy_Amount_Piad"]));
                    buy_Amount_R += (Convert.ToDouble(CustDT.Rows[i]["buy_Amount_Rem"]));
                }
                txtAP.Text = buy_Amount_Piad.ToString();
                txtAR.Text = buy_Amount_R.ToString();
            }
            catch (Exception es) { }
            
            
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Buy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Buy_DoubleClick(object sender, EventArgs e)
        {
            
            new tfasel(Convert.ToInt32(dgv_Buy.Rows[dgv_Buy.CurrentRow.Index].Cells[1].Value), index).ShowDialog();
        }

        private void dgv_Buy_CellClick(object sender, DataGridViewCellEventArgs e)
        {   try
            {
                index = dgv_Buy.CurrentRow.Index;
            }
            catch (Exception es) { }
        }

private void btnUpdet_Click(object sender, EventArgs e)
        {
            CustDT = new DataTable();
            CustDA = new OleDbDataAdapter("SELECT * FROM buypill", con);
            CustDA.Fill(CustDT);
            dgv_Buy.DataSource = CustDT;
            txtSearchImpo.Text = "";
        }

        private void btnDelateICust_Click(object sender, EventArgs e)
        {
            if (dgv_Buy.Rows.Count > 0)
            {
                index = Convert.ToInt32(dgv_Buy.Rows[dgv_Buy.CurrentRow.Index].Cells[1].Value);
                DataTable CustDT3 = new DataTable();
                OleDbCommand cmd;
                MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف السجل");
                mg.ShowDialog();
                if (mg.result())
                {
                    CustDT3.Clear();
                    cmd = new OleDbCommand("DELETE from buypill where id_buy= " + index + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                    Filldgv_Buy();
                }

            }
        }
        FormFillBuys FMGU;
        private void btnAddCost_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Controls[0].Controls.Count > 0)
            {
                foreach (Control fd in Application.OpenForms[1].Controls[0].Controls)
                {
                    if (fd is FormFillBuys)
                    {                        
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                FMGU = new FormFillBuys();
                FMGU.Dock = DockStyle.Fill;
                FMGU.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FMGU);
                FMGU.BringToFront();
                FMGU.Show();
            }
            else
            {
                FMGU = new FormFillBuys();
                FMGU.TopLevel = false;
                FMGU.Dock = DockStyle.Fill;
                Application.OpenForms[1].Controls[0].Controls.Add(FMGU);
                FMGU.BringToFront();
                FMGU.Show();
            }            
        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            if (txtSearchImpo.Text != "")
            {
                CustDT.Clear();
                CustDT = new DataTable();
                CustDA = new OleDbDataAdapter("SELECT * FROM buypill where buy_impo like '%" + txtSearchImpo.Text + "%'", con);
                CustDA.Fill(CustDT);
                dgv_Buy.DataSource = CustDT;
            }
            else if(DPDFPillBuy.Value != DateTime.Now.Date)
            {
                CustDT.Clear();
                CustDT = new DataTable();
                CustDA = new OleDbDataAdapter("SELECT * FROM buypill where date_buy = #" + (DateTime.Parse(DPDFPillBuy.Text)).ToString("MM/dd/yyyy") + "#", con);
                CustDA.Fill(CustDT);
                dgv_Buy.DataSource = CustDT;
                //new MessagBoxH(2, (DPDFPillBuy.Value).ToString()).ShowDialog();
            }
            else
            {
                new MessagBoxH(2, "البحت عن فراغ").ShowDialog();

            }

        }

        private void DPDFPillBuy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
