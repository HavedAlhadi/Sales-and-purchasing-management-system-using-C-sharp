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
    public partial class FormMangItems : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable ItemDT;
        OleDbDataAdapter dta;
        int index = -1;
        //*********************************************************************\\
        //*********************************************************************\\
        public FormMangItems()
        {
            InitializeComponent();
            ItemDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM items", con);
            dta.Fill(ItemDT);
            dgvItem.DataSource = ItemDT;
        }
        //*********************************************************************\\
        //*********************************************************************\\
        private void chickDatag()
        {
            if (dgvItem.Rows.Count == 1)
            {
                btnDelateIt.Enabled = false;
                btnSearchI.Enabled = false;
                BtnUpdateIt.Enabled = false;
            }
            else
            {
                if (txtSearchIt.Text != "")
                    btnSearchI.Enabled = true;
                else
                    btnSearchI.Enabled = false;
                btnDelateIt.Enabled = true;
                BtnUpdateIt.Enabled = true;
            }
        }
        //*********************************************************************\\
        //*********************************************************************\\
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*********************************************************************\\
        //*********************************************************************\\

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //*********************************************************************\\
        //*********************************************************************\\      
        FormAddItemcs FAI;
        private void btnAddIt_Click(object sender, EventArgs e)
        {
            FAI = new FormAddItemcs();
            FAI.ShowDialog();
        }
        private void BtnUpdateIt_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items", con);
                dta.Fill(ItemDT);
                int id;
                DateTime date, time, dateE;
                string IName, NPI, priceI, nameG, nameU, earnI, QuI, userA;
                id = Convert.ToInt32(ItemDT.Rows[index]["ID_item"]);
                IName = ItemDT.Rows[index]["name_item"].ToString();
                NPI = ItemDT.Rows[index]["numpar_item"].ToString();
                priceI = ItemDT.Rows[index]["price_item"].ToString();
                nameG = ItemDT.Rows[index]["nameGrop_item"].ToString();
                nameU = ItemDT.Rows[index]["name_unit_item"].ToString();
                earnI = ItemDT.Rows[index]["earn_item"].ToString();
                QuI = ItemDT.Rows[index]["quantity_item"].ToString();
                date = Convert.ToDateTime(ItemDT.Rows[index]["date_item"]);
                dateE = Convert.ToDateTime(ItemDT.Rows[index]["dateEnd_item"]);
                time = Convert.ToDateTime(ItemDT.Rows[index]["time_item"]);
                userA = ItemDT.Rows[index]["user_item"].ToString();
                FAI = new FormAddItemcs(id, IName, NPI, priceI, nameG, nameU, earnI, QuI, date, time, dateE, userA, index);
                FAI.ShowDialog();
                con.Close();
            }
        catch(Exception ex) { }
                
        }
        //*********************************************************************\\
        //*********************************************************************\\       

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItem.Text == "بحث باسم الصنف")
            {
                txtSearchIt.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchIt.KeyPress += ClassGenric.AhadiText;
            }
            else if (cmbItem.Text == "بحث برقم الصنف")
            {
                txtSearchIt.KeyPress -= ClassGenric.AhadiText;
                txtSearchIt.KeyPress += ClassGenric.AhadiTextNum;
            }
            else if (cmbItem.Text == "بحث بالمجموعة")
            {
                txtSearchIt.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchIt.KeyPress += ClassGenric.AhadiText;
            }
            else if (cmbItem.Text == "بحث بالوحدة")
            {
                txtSearchIt.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchIt.KeyPress += ClassGenric.AhadiText;
            }
        }
        //*********************************************************************\\
        //*********************************************************************\\

        private void txtSearchIt_TextChanged(object sender, EventArgs e)
        {
            chickDatag();
        }

        private void txtSearchIt_Leave(object sender, EventArgs e)
        {
            chickDatag();
        }
        //*********************************************************************\\
        //*********************************************************************\\

        private void btnSearchI_Click(object sender, EventArgs e)
        {
            if (cmbItem.Text == "بحث باسم الصنف")
            {
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where name_item like '%" + txtSearchIt.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }
            else if (cmbItem.Text == "بحث برقم الصنف")
            {                
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where numpar_item like '%" + txtSearchIt.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }
            else if (cmbItem.Text == "بحث بالمجموعة")
            {
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where nameGrop_item like '%" + txtSearchIt.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }
            else if (cmbItem.Text == "بحث بالوحدة")
            {
                ItemDT.Clear();
                ItemDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM items where nameunit_item like '%" + txtSearchIt.Text + "%'", con);
                dta.Fill(ItemDT);
                dgvItem.DataSource = ItemDT;
            }
            else
            {
                new MessagBoxH(2, "فضلا إختر نوع البحت").ShowDialog();
            }
        }
        //*********************************************************************\\
        //*********************************************************************\\

        private void btnDelateIt_Click(object sender, EventArgs e)
        {
            MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف المستخدم");
            mg.ShowDialog();
            if (mg.result())
            {
                index = dgvItem.CurrentRow.Index;
                ItemDT.Rows[index].Delete();
                new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                OleDbCommandBuilder save = new OleDbCommandBuilder(dta);
                dta.Update(ItemDT);
                ItemDT.AcceptChanges();
                dgvItem.DataSource = ItemDT;
            }
            chickDatag();
        }
        //*********************************************************************\\
        //*********************************************************************\\

        private void btnUpdet_Click(object sender, EventArgs e)
        {
            chickDatag();
            ItemDT.Clear();
            ItemDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM items", con);
            dta.Fill(ItemDT);
            dgvItem.DataSource = ItemDT;
            btnSearchI.Enabled = false;
            txtSearchIt.Text = "";
            cmbItem.Text = "";
        }

        //*********************************************************************\\
        //*********************************************************************\\
        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvItem.CurrentRow.Index;
        }

        private void dgvItem_SelectionChanged(object sender, EventArgs e)
        {
            try { 
            index = dgvItem.CurrentRow.Index;
            }
            catch(Exception ee) { }
        }
    }
}
