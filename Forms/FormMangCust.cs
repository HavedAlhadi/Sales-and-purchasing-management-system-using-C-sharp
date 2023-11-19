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
    public partial class FormMangCust : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        OleDbDataAdapter dta;
        int index = -1;
        //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""\\
        public FormMangCust()
        {
            InitializeComponent();
            getTabl();
        }

        //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""\\
        private void getTabl()
        {
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer", con);
            dta.Fill(CustDT);
            dgvCust.DataSource = CustDT;
        }
        private void chickDataCust()
        {
            if (dgvCust.Rows.Count == 1)
            {
                btnDelateICust.Enabled = false;
                btnSearchCust.Enabled = false;
                BtnEditCost.Enabled = false;
            }
            else
            {
                if (txtSearchCust.Text != "")
                    btnSearchCust.Enabled = true;
                else
                    btnSearchCust.Enabled = false;
                btnDelateICust.Enabled = true;
                BtnEditCost.Enabled = true;
            }
        }     
        private void labCloseFAddIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FormAddCust FAC = new FormAddCust();
        private void btnAddIt_Click(object sender, EventArgs e)
        {
            FAC.ShowDialog();
        }
        private void BtnEditCost_Click(object sender, EventArgs e)
        {
            index = dgvCust.CurrentRow.Index;
            con.Open();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer", con);
            dta.Fill(CustDT);
            int id;
            DateTime date, time;
            string CName, CNPh, baln, Cgender, Ctype, addres, note, userA;           
            id = Convert.ToInt32(CustDT.Rows[index]["id_cust"]);
            CName = CustDT.Rows[index]["name_cust"].ToString();
            CNPh = CustDT.Rows[index]["phon_cust"].ToString();
            addres = CustDT.Rows[index]["addres_cust"].ToString();
            baln = CustDT.Rows[index]["balance_cust"].ToString();
            Cgender = CustDT.Rows[index]["gender_cust"].ToString();
            Ctype = CustDT.Rows[index]["type_cust"].ToString();
            note = CustDT.Rows[index]["note_cust"].ToString();
            date = Convert.ToDateTime(CustDT.Rows[index]["date_cust"]);            
            time = Convert.ToDateTime(CustDT.Rows[index]["time_cust"]);
            userA = CustDT.Rows[index]["uesr_cust"].ToString();
            FAC = new FormAddCust(id, CName, CNPh, addres, date, time, baln, Cgender, Ctype,  note, userA, index);
            FAC.ShowDialog();
            con.Close();
        }

        private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvCust.CurrentRow.Index;
        }

        private void cmbSearchCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCust.Text == "البحث بالاسم")
            {
                txtSearchCust.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchCust.KeyPress += ClassGenric.AhadiText;
                txtSearchCust.Text = "";
            }
            else if (cmbSearchCust.Text == "البحث برقم الهاتف")
            {
                txtSearchCust.KeyPress -= ClassGenric.AhadiText;
                txtSearchCust.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchCust.KeyPress += ClassGenric.AhadiTextNum;
                txtSearchCust.Text = "";
            }
            else if (cmbSearchCust.Text == "البحث بالعنوان")
            {
                txtSearchCust.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchCust.KeyPress -= ClassGenric.AhadiText;
                txtSearchCust.Text = "";
            }            
        }
        private void btnSearchG_Click(object sender, EventArgs e)
        {
            if (cmbSearchCust.Text == "البحث بالاسم")
            {
                CustDT.Clear();
                CustDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM customer where name_cust like '%" + txtSearchCust.Text + "%'", con);
                dta.Fill(CustDT);
                dgvCust.DataSource = CustDT;
            }
            else if (cmbSearchCust.Text == "البحث برقم الهاتف")
            {
                CustDT.Clear();
                CustDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM customer where phon_cust like '%" + txtSearchCust.Text + "%'", con);
                dta.Fill(CustDT);
                dgvCust.DataSource = CustDT;
            }
            else if (cmbSearchCust.Text == "البحث بالعنوان")
            {
                CustDT.Clear();
                CustDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM customer where addres_cust like '%" + txtSearchCust.Text + "%'", con);
                dta.Fill(CustDT);
                dgvCust.DataSource = CustDT;
            }            
            else
            {
                new MessagBoxH(2, "فضلا إختر نوع البحت").ShowDialog();
            }
        }
        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            chickDataCust();
        }

        private void btnUpdet_Click(object sender, EventArgs e)
        {
            index = 1;
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer", con);
            dta.Fill(CustDT);
            dgvCust.DataSource = CustDT;
            btnSearchCust.Enabled = false;
            txtSearchCust.Text = "";
            cmbSearchCust.Text = "إختر نوع البحث";
            chickDataCust();
        }

        private void btnDelateICust_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف العميل");
                mg.ShowDialog();
                if (mg.result())
                {
                    index = dgvCust.CurrentRow.Index;
                    CustDT.Rows[index].Delete();
                    new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                    OleDbCommandBuilder save = new OleDbCommandBuilder(dta);
                    dta.Update(CustDT);
                    CustDT.AcceptChanges();
                    dgvCust.DataSource = CustDT;
                    getTabl();
                }
            }
            chickDataCust();
        }

        private void Por_CheckedChanged(object sender, EventArgs e)
        {
            if (Por.Checked== true)
            {
               
                if (Male.Checked == true)
                {
                    selcte2(Por, Male, "type_cust", "gender_cust");
                    return;
                }
                else if (Famle.Checked == true)
                {
                    selcte2(Por, Famle, "type_cust", "gender_cust");
                }
                selcte(Por, "type_cust");

            }               
        }

        private void selcte(RadioButton r,string te)
        {
            string s = r.Text;
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer where "+ te + " like '%" + s + "%'", con);
            dta.Fill(CustDT);
            dgvCust.DataSource = CustDT;            
        }
        private void selcte2(RadioButton r, RadioButton r2, string t1, string t2)
        {
            string s = r.Text;
            string s2 = r2.Text;
            CustDT.Clear();
            CustDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM customer where "+ t1  +" like '%" + s + "%' and "+ t2 + " like '%" + s2 + "%'", con);
            dta.Fill(CustDT);
            dgvCust.DataSource = CustDT;
        }
        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Male.Checked == true)
            {
                if (Por.Checked == true)
                {
                    selcte2(Male, Por,"gender_cust", "type_cust");
                    return;
                }
                else if (rdoCash.Checked == true)
                {
                    selcte2(Male, rdoCash, "gender_cust", "type_cust");
                    return;
                }
                    selcte(Male, "gender_cust");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Famle.Checked = false;
            Male.Checked = false;
            rdoCash.Checked = false;
            Por.Checked = false;
        }

        private void Famle_CheckedChanged(object sender, EventArgs e)
        {
            if (Famle.Checked == true)
            {
                if (Por.Checked == true)
                {
                    selcte2(Famle, Por, "gender_cust", "type_cust");
                    return;
                }
                else if (rdoCash.Checked == true)
                {
                    selcte2(Famle, rdoCash, "gender_cust", "type_cust");
                    return;
                }
                selcte(Famle, "gender_cust");
            }
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCash.Checked == true)
            {
                if (Male.Checked == true)
                {
                    selcte2(rdoCash, Male, "type_cust", "gender_cust");
                    return;
                }
                else if (Famle.Checked == true)
                {
                    selcte2(rdoCash, Famle, "type_cust", "gender_cust");
                    return;
                }
                selcte(rdoCash, "type_cust");
            }
        }
    }
}
