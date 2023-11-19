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
    public partial class tfasel : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        DataTable CustDT1;
        DataTable CustDT2 = new DataTable();
        OleDbDataAdapter CustDA;
        OleDbDataAdapter CustDA1;
        OleDbCommand OperEdit;
        OleDbCommand ItemQEdit;
        int idexs, idexsval;
        public tfasel()
        {
            InitializeComponent();
            getTable();

        }
        public tfasel(int x, int y)
        {
            idexs = x;
            idexsval = y;
            InitializeComponent();
            getTable();

        }
        public void getTable()
        {
            try
            {
                buypill_Id.Text = idexs.ToString();
                double buy_Amount_Piad = 0, buy_Amount_R = 0;
                CustDT2.Clear();
                CustDA = new OleDbDataAdapter("SELECT operation.id_oper, operation.id_buy, operation.item_oper, items.numpar_item, items.price_item, items.quantity_item, operation.buy_quntity, operation.buy_discound, operation.buy_unitprice, operation.buy_totalG, operation.buy_totalB, operation.buy_earn, operation.date_oper, operation.time_oper, operation.user_oper, operation.buy_notes, operation.operitemEnd, operation.buy_unit FROM items , operation where items.name_item = operation.item_oper and id_buy = " + idexs + "", con);
                CustDA.Fill(CustDT2);
                dgvBuy.DataSource = CustDT2;
                Item_c.Text = dgvBuy.Rows.Count.ToString();
                CustDT1 = new DataTable();
                CustDA1 = new OleDbDataAdapter("SELECT * FROM buypill", con);
                CustDA1.Fill(CustDT1);
                txtAP.Text = (CustDT1.Rows[idexsval]["buy_Amount_Piad"]).ToString();
                txtAR.Text = (CustDT1.Rows[idexsval]["buy_Amount_Rem"]).ToString();
            }
            catch (Exception es) { }
        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            CustDT2.Clear();
            CustDA = new OleDbDataAdapter("SELECT operation.id_oper, operation.id_buy, operation.item_oper, items.numpar_item, items.price_item, items.quantity_item, operation.buy_quntity, operation.buy_discound, operation.buy_unitprice, operation.buy_totalG, operation.buy_totalB, operation.buy_earn, operation.date_oper, operation.time_oper, operation.user_oper, operation.buy_notes, operation.operitemEnd, operation.buy_unit FROM items , operation where items.name_item = operation.item_oper and id_buy = " + idexs + "and item_oper='" + txtSearchPillBuy.Text + "'", con);
            CustDA.Fill(CustDT2);
            dgvBuy.DataSource = CustDT2;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdet_Click(object sender, EventArgs e)
        {
            getTable();
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
            this.Close();
        }
    


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
