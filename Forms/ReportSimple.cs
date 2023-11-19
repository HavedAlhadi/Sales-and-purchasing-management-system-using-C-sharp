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
    public partial class ReportSimple : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        OleDbDataAdapter dta;
        public ReportSimple()
        {
            InitializeComponent();
            CountData();
        }
        private void CountData()
        {
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer", con);
            dta.Fill(CustDT);
            haved_toolreportCust.ItemSize = CustDT.Rows.Count.ToString();
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer", con);
            dta.Fill(CustDT);
            haved_toolreportImpo.ItemSize = CustDT.Rows.Count.ToString();
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM items", con);
            dta.Fill(CustDT);
            haved_toolreportItem.ItemSize = CustDT.Rows.Count.ToString();
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM users", con);
            dta.Fill(CustDT);
            haved_toolreportUsers.ItemSize = CustDT.Rows.Count.ToString();
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM buypill", con);
            dta.Fill(CustDT);
            haved_toolreportBuy.ItemSize = CustDT.Rows.Count.ToString();
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM salepill", con);
            dta.Fill(CustDT);
            haved_toolreportSale.ItemSize = CustDT.Rows.Count.ToString();
        }

        private void labCloseFAddIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
