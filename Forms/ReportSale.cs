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
    public partial class ReportSale : Form
    {
        
    OleDbConnection con = ClassGenric.Conaction();
    DataTable CustDT = new DataTable();
    DataTable CustDT1 = new DataTable();
    DataTable CustDT2 = new DataTable();
    OleDbDataAdapter CustDA;

    public ReportSale()
        {
            InitializeComponent();
            CustDT = new DataTable();
            CustDA = new OleDbDataAdapter("SELECT * FROM salepill", con);
            CustDA.Fill(CustDT);
            dgv_Sale.DataSource = CustDT;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
