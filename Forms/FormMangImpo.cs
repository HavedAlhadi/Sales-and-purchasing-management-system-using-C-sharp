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
    public partial class FormMangImpo : Form
    {

        OleDbConnection con = ClassGenric.Conaction();
        DataTable ImpoDT;
        OleDbDataAdapter dta;
        int index = -1;
        public FormMangImpo()
        {
            InitializeComponent();
            getTabl();            
            chickDataCust();
        }

        private void getTabl()
        {
            ImpoDT = new DataTable();
            ImpoDT.Clear();
            dta = new OleDbDataAdapter("SELECT * FROM importer", con);
            dta.Fill(ImpoDT);
            dgvImpo.DataSource = ImpoDT;
        }
        private void chickDataCust()
        {
            if (dgvImpo.Rows.Count == 1)
            {
                btnDelateImpo.Enabled = false;
                btnSearchImpo.Enabled = false;
                BtnUpdateImpo.Enabled = false;
            }
            else
            {
                if (txtSearchImpo.Text != "")
                    btnSearchImpo.Enabled = true;
                else
                    btnSearchImpo.Enabled = false;
                btnDelateImpo.Enabled = true;
                BtnUpdateImpo.Enabled = true;
            }
        }
        private void labCloseFAddIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoFamel_CheckedChanged(object sender, EventArgs e)
        {

        }
        FormAddImpo FAI = new FormAddImpo();
        private void btnAddIt_Click(object sender, EventArgs e)
        {
            FAI.ShowDialog();
        }

        private void BtnUpdateImpo_Click(object sender, EventArgs e)
        {
            index = dgvImpo.CurrentRow.Index;
            con.Open();
            ImpoDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer", con);
            dta.Fill(ImpoDT);
            int id;
            DateTime date, time;
            string CName, CNPh, baln, Cgender, Ctype, note, userA;
            id = Convert.ToInt32(ImpoDT.Rows[index]["id_impo"]);
            CName = ImpoDT.Rows[index]["name_impo"].ToString();
            CNPh = ImpoDT.Rows[index]["phone_impo"].ToString();            
            baln = ImpoDT.Rows[index]["balance_impo"].ToString();
            Cgender = ImpoDT.Rows[index]["gender_impo"].ToString();
            Ctype = ImpoDT.Rows[index]["type_impo"].ToString();
            note = ImpoDT.Rows[index]["note_impo"].ToString();
            date = Convert.ToDateTime(ImpoDT.Rows[index]["date_impo"]);
            time = Convert.ToDateTime(ImpoDT.Rows[index]["time_impo"]);
            userA = ImpoDT.Rows[index]["user_impo"].ToString();
            FAI = new FormAddImpo(id, CName, CNPh, date, time, baln, Cgender, Ctype, note, userA, index);
            FAI.ShowDialog();
            getTabl();
            con.Close();
        }

        private void dgvImpo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvImpo.CurrentRow.Index;
        }

        private void cmSearchImpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmSearchImpo.Text == "البحث بالاسم")
            {
                txtSearchImpo.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchImpo.KeyPress += ClassGenric.AhadiText;
                txtSearchImpo.Text = "";
            }
            else if (cmSearchImpo.Text == "البحث برقم الهاتف")
            {
                txtSearchImpo.KeyPress -= ClassGenric.AhadiText;
                txtSearchImpo.KeyPress += ClassGenric.AhadiTextNum;
                txtSearchImpo.Text = "";
            }            
        }

        private void btnSearchImpo_Click(object sender, EventArgs e)
        {
            if (cmSearchImpo.Text == "البحث بالاسم")
            {
                ImpoDT.Clear();
                ImpoDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM importer where name_impo like '%" + txtSearchImpo.Text + "%'", con);
                dta.Fill(ImpoDT);
                dgvImpo.DataSource = ImpoDT;
            }
            else if (cmSearchImpo.Text == "البحث برقم الهاتف")
            {
                ImpoDT.Clear();
                ImpoDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM importer where phone_impo like '%" + txtSearchImpo.Text + "%'", con);
                dta.Fill(ImpoDT);
                dgvImpo.DataSource = ImpoDT;
            }           
            else
            {
                new MessagBoxH(2, "فضلا إختر نوع البحت").ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Famle.Checked = false;
            Male.Checked = false;
            rdoCash.Checked = false;
            Por.Checked = false;
        }
        private void selcte(RadioButton r, string te)
        {
            string s = r.Text;
            ImpoDT.Clear();
            ImpoDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer where " + te + " like '%" + s + "%'", con);
            dta.Fill(ImpoDT);
            dgvImpo.DataSource = ImpoDT;
        }
        private void selcte2(RadioButton r, RadioButton r2, string t1, string t2)
        {
            string s = r.Text;
            string s2 = r2.Text;
            ImpoDT.Clear();
            ImpoDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer where " + t1 + " like '%" + s + "%' and " + t2 + " like '%" + s2 + "%'", con);
            dta.Fill(ImpoDT);
            dgvImpo.DataSource = ImpoDT;
        }
        private void Famle_CheckedChanged(object sender, EventArgs e)
        {
            if (Famle.Checked == true)
            {
                if (Por.Checked == true)
                {
                    selcte2(Famle, Por, "gender_impo", "type_impo");
                    return;
                }
                else if (rdoCash.Checked == true)
                {
                    selcte2(Famle, rdoCash, "gender_impo", "type_impo");
                    return;
                }
                selcte(Famle, "gender_impo");
            }
        }
        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCash.Checked == true)
            {
                if (Male.Checked == true)
                {
                    selcte2(rdoCash, Male, "type_impo", "gender_impo");
                    return;
                }
                else if (Famle.Checked == true)
                {
                    selcte2(rdoCash, Famle, "type_impo", "gender_impo");
                    return;
                }
                selcte(rdoCash, "type_impo");
            }
        }

        private void btnUpdetImpo_Click(object sender, EventArgs e)
        {
            index = 1;
            ImpoDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM importer", con);
            dta.Fill(ImpoDT);
            dgvImpo.DataSource = ImpoDT;
            btnSearchImpo.Enabled = false;
            txtSearchImpo.Text = "";
            cmSearchImpo.Text = "إختر نوع البحث";
            chickDataCust();
        }

        private void btnDelateImpo_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف المورد");
                mg.ShowDialog();
                if (mg.result())
                {
                    index = dgvImpo.CurrentRow.Index;
                    ImpoDT.Rows[index].Delete();
                    new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                    OleDbCommandBuilder save = new OleDbCommandBuilder(dta);
                    dta.Update(ImpoDT);
                    ImpoDT.AcceptChanges();
                    dgvImpo.DataSource = ImpoDT;
                    getTabl();
                }
            }
            chickDataCust();
        }
        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Male.Checked == true)
            {
                if (Por.Checked == true)
                {
                    selcte2(Male, Por, "gender_impo", "type_impo");
                    return;
                }
                else if (rdoCash.Checked == true)
                {
                    selcte2(Male, rdoCash, "gender_impo", "type_impo");
                    return;
                }
                selcte(Male, "gender_impo");
            }

        }
        private void Por_CheckedChanged(object sender, EventArgs e)
        {
            if (Por.Checked == true)
            {

                if (Male.Checked == true)
                {
                    selcte2(Por, Male, "type_impo", "gender_impo");
                    return;
                }
                else if (Famle.Checked == true)
                {
                    selcte2(Por, Famle, "type_cust", "gender_impo");
                }
                selcte(Por, "type_impo");
            }
        }
        private void txtSearchImpo_TextChanged(object sender, EventArgs e)
        {
            chickDataCust();
        }
    }
}
