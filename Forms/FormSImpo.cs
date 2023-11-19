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
    public partial class FormSImpo : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        OleDbDataAdapter dta;
        int index = -1;
        int i = -1;
        public FormSImpo()
        {
            InitializeComponent();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer", con);
            dta.Fill(CustDT);
            dgvImpo.DataSource = CustDT;
        }

        private void FormSImpo_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {

            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer where name_impo like '%" + txtSearchImpo.Text + "%'", con);
            dta.Fill(CustDT);
            dgvImpo.DataSource = CustDT;
        }

        private void BtnEditCost_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                ClassGenric.Ahadi_index(index);
                this.Close();
            }
            this.Close();
        }

        private void dgvImpo_SelectionChanged(object sender, EventArgs e)
        {
            try 
            {
                index = dgvImpo.CurrentRow.Index;
               
            }
            catch (Exception xx)
            {  }

        }

        private void labCloseFAddIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {

            if (txtSearchImpo.Text != "")
                btnSearchImpo.Enabled = true;
            else
                btnSearchImpo.Enabled = false;
        }
        private void dgvImpo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvImpo.CurrentRow.Index;
        }

        private void labCloseFAddIt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
