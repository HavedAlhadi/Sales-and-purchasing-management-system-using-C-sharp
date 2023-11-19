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
    public partial class FormMangUser : Form
    {
        OleDbConnection con= ClassGenric.Conaction();
        DataTable UserDT;
        OleDbDataAdapter dta;
        int index = -1;
        public FormMangUser()
        {
            InitializeComponent();
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM users", con);
            dta.Fill(UserDT);
            dgvUser.DataSource = UserDT;           
            chickDatag();
        }
        //دالة لفحص الجدول فارغ 
        private void chickDatag()
        {
            if (dgvUser.Rows.Count==1)
            {
                btnDelateIt.Enabled = false;
                btnSearchU.Enabled = false;
                BtnUpdateIt.Enabled = false;
            }
            else
            {
                if(txt_Search.Text!="")
                    btnSearchU.Enabled = true;
                else
                    btnSearchU.Enabled = false;
                btnDelateIt.Enabled = true;                
                BtnUpdateIt.Enabled = true;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

        }

        
        private void btnAddIt_Click(object sender, EventArgs e)
        {
            new Form_AddUser().ShowDialog();
            chickDatag();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            
        }
        Form_AddUser FUN;
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvUser.CurrentRow.Index;
            
        }

        private void BtnUpdateIt_Click(object sender, EventArgs e)
        {
            con.Open();
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM users", con);
            dta.Fill(UserDT);
            int id;
            DateTime date, time;
            string name, pho, usern, pass, userA;
            id = Convert.ToInt32(UserDT.Rows[index]["id_user"]);
            name = UserDT.Rows[index]["fillname_user"].ToString();
            pho = UserDT.Rows[index]["phone_user"].ToString();
            usern = UserDT.Rows[index]["username"].ToString();
            pass = UserDT.Rows[index]["pass_user"].ToString();
            date = Convert.ToDateTime(UserDT.Rows[index]["date_user"]);
            time = Convert.ToDateTime(UserDT.Rows[index]["time_user"]);
            userA = UserDT.Rows[index]["user_adduser"].ToString();
            FUN = new Form_AddUser(id, name, pho, usern, pass, date, time, userA, index);
            FUN.ShowDialog();
            con.Close();           
        }

        private void btnUpdet_Click(object sender, EventArgs e)
        {
            chickDatag();
            UserDT.Clear();
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM users", con);
            dta.Fill(UserDT);
            dgvUser.DataSource = UserDT;
            btnSearchU.Enabled =false;
            txt_Search.Text = "";
            comboBox1.Text = "إختر نوع البحث";
        }

        private void btnDelateIt_Click(object sender, EventArgs e)
        {
             MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف المستخدم");
                mg.ShowDialog();
            if (mg.result())
            {
                UserDT.Rows[index].Delete();
                new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                OleDbCommandBuilder save = new OleDbCommandBuilder(dta);
                dta.Update(UserDT);
                UserDT.AcceptChanges();
                dgvUser.DataSource = UserDT;
            }
            chickDatag();
        }

        private void btnSearchU_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="بحث بالاسم")
            {
                txt_Search.KeyPress += ClassGenric.AhadiText;
                UserDT.Clear();
                UserDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM users where fillname_user like '%"+ txt_Search.Text+"%'", con);
                dta.Fill(UserDT);
                dgvUser.DataSource = UserDT;
            }
            else if(comboBox1.Text == "بحث برقم الهاتف")
            {
                txt_Search.KeyPress += ClassGenric.AhadiTextNum;
                UserDT.Clear();
                UserDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM users where phone_user like '%" + txt_Search.Text + "%'", con);
                dta.Fill(UserDT);
                dgvUser.DataSource = UserDT;
            }
            else
            {
                new MessagBoxH(2, "فضلا إختر نوع البحت").ShowDialog();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {            
            
            chickDatag();
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            chickDatag();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "بحث بالاسم")
            {
                txt_Search.KeyPress -= ClassGenric.AhadiTextNum;
                txt_Search.KeyPress += ClassGenric.AhadiText;
            }
            else if (comboBox1.Text == "بحث برقم الهاتف")
            {
                txt_Search.KeyPress += ClassGenric.AhadiTextNum;
                txt_Search.KeyPress += ClassGenric.AhadiText;
            }
        } 

        }
}
