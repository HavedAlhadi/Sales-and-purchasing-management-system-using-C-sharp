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
    public partial class FormSearchCust : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        OleDbDataAdapter dta;
        int index = -1;   
        public FormSearchCust()
        {
            InitializeComponent();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer", con);
            dta.Fill(CustDT);
            dgvCust.DataSource = CustDT;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            CustDT.Clear();
            CustDT = new DataTable();            
            dta = new OleDbDataAdapter("SELECT * FROM customer where name_cust like '%" + txtSearchCust.Text + "%'", con);
            dta.Fill(CustDT);
            dgvCust.DataSource = CustDT;
        }

        private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvCust.CurrentRow.Index;
        }

        private void labCloseFAddIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
           
                    if (txtSearchCust.Text != "")
                        btnSearchCust.Enabled = true;
                    else
                        btnSearchCust.Enabled = false;                            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEditCost_Click(object sender, EventArgs e)
        {
            if(index!=-1)
            {
                ClassGenric.Ahadi_index(index);
                this.Close();
            }
            this.Close();
        }

        private void dgvCust_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                index = dgvCust.CurrentRow.Index;

            }
            catch (Exception xx)
            { }
        }

        private void FormSearchCust_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
