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
    public partial class FormMangGU : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable UserDT;
        OleDbDataAdapter dta;
        int index = 0;
        public FormMangGU()
        {
            InitializeComponent();
            button1.Enabled = false;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM group_items", con);
            dta.Fill(UserDT);
            dgvGroupItems.DataSource = UserDT;
            chickDatag();
        }
        //
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        //
        public void ShowPU(int x)
        {
            this.panelGroup.Visible = false;
            this.panelUnit.Visible = true;
            this.panel2.Visible = true;
            button6.Enabled = false;
            button1.Enabled = true;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM unit_items", con);
            dta.Fill(UserDT);
            dgvUnit.DataSource = UserDT;
            chickDataU();
        }
        //
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        //
        public void ShowPG(int x)
        {
            this.panelUnit.Visible = false;
            this.panelGroup.Visible = true;
            this.panel2.Visible = false;
            button6.Enabled = true;
            button1.Enabled = false;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM group_items", con);
            dta.Fill(UserDT);
            dgvGroupItems.DataSource = UserDT;
            chickDatag();
            chickDatag();
        }
        public FormMangGU(int b)
        {
            InitializeComponent();
            if (b == 0)
            {
                ShowPU(0);
            }
            else
            {
                ShowPG(1);
            }
        }
        //
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        //
        //دالة لفحص الجدول فارغ 
        private void chickDatag()
        {
            if (dgvGroupItems.Rows.Count ==0)
            {
                btnDelG.Enabled = false;
                btnSearchG.Enabled = false;
                btnEditG.Enabled = false;
            }
            else
            {
                if (txtSearchG.Text != "")
                    btnSearchG.Enabled = true;
                else
                    btnSearchG.Enabled = false;
                btnDelG.Enabled = true;
                btnEditG.Enabled = true;
            }
        }
        //
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        //       
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMangGU_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labVisUnit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.panel2.Visible = true;
            this.panel2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.panelGroup.Visible = false;
            this.panelUnit.Visible = true;
            this.panel2.Visible = false;
            button6.Enabled = false;
            button1.Enabled = true;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM unit_items", con);
            dta.Fill(UserDT);
            dgvUnit.DataSource = UserDT;
            chickDataU();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelUnit.Visible = false;
            this.panelGroup.Visible = true;
            this.panel2.Visible = false;
            button6.Enabled = true;
            button1.Enabled = false;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM group_items", con);
            dta.Fill(UserDT);
            dgvGroupItems.DataSource = UserDT;
            chickDatag();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        FormAddUnit FaddU; 
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            new FormAddUnit().ShowDialog();
        }
        Form_AddGroup FaddG;
        private void btnAddG_Click(object sender, EventArgs e)
        {
            new Form_AddGroup().ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGroupItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvGroupItems.CurrentRow.Index;
        }

        private void btnEditG_Click(object sender, EventArgs e)
        {
            con.Open();
            index = dgvGroupItems.CurrentRow.Index;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM group_items", con);
            dta.Fill(UserDT);
            int id;
            DateTime date, time;
            string name,userA;
            id = Convert.ToInt32(UserDT.Rows[index]["id_group"]);
            name = UserDT.Rows[index]["name_group"].ToString();
            date = Convert.ToDateTime(UserDT.Rows[index]["date_group"]);
            time = Convert.ToDateTime(UserDT.Rows[index]["time_group"]);
            userA = UserDT.Rows[index]["user_group"].ToString();
            FaddG = new Form_AddGroup(id, name, date, time, userA, index);
            FaddG.ShowDialog();           
            con.Close();

        }

        private void btnUpdet_Click(object sender, EventArgs e)
        {
            index =1;                        
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM group_items", con);
            dta.Fill(UserDT);
            dgvGroupItems.DataSource = UserDT;
            btnSearchG.Enabled = false;
            txtSearchG.Text = "";
            comBSearchG.Text = "إختر نوع البحث";
            chickDatag();
        }

        private void btnDelG_Click(object sender, EventArgs e)
        {
            if(index>=0)
            { 
            MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف المجموعة");
            mg.ShowDialog();
            if (mg.result())
            {
                index = dgvGroupItems.CurrentRow.Index;
                UserDT.Rows[index].Delete();
                new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                OleDbCommandBuilder save = new OleDbCommandBuilder(dta);
                dta.Update(UserDT);
                UserDT.AcceptChanges();
                dgvGroupItems.DataSource = UserDT;
            }
            }
            chickDatag();
        }

        private void btnSearchG_Click(object sender, EventArgs e)
        {
            if (comBSearchG.Text == "البحث باسم المجموعة")
            {
                txtSearchG.KeyPress += ClassGenric.AhadiText;
                UserDT.Clear();
                UserDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM group_items where name_group like '%" + txtSearchG.Text + "%'", con);
                dta.Fill(UserDT);
                dgvGroupItems.DataSource = UserDT;
            }
            else if (comBSearchG.Text == "البحث برقم المجموعة")
            {
                comBSearchG.KeyPress += ClassGenric.AhadiTextNum;
                UserDT.Clear();
                UserDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM group_items where id_group like '%" + txtSearchG.Text + "%'", con);
                dta.Fill(UserDT);
                dgvGroupItems.DataSource = UserDT;
            }
            else
            {
                new MessagBoxH(2, "فضلا إختر نوع البحت").ShowDialog();
            }
        }

        private void txtSearchG_TextChanged(object sender, EventArgs e)
        {
            chickDatag();
        }

        private void comBSearchG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBSearchG.Text == "البحث باسم المجموعة")
            {
                txtSearchG.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchG.KeyPress += ClassGenric.AhadiText;
                txtSearchG.Text = "";
            }
            else if (comBSearchG.Text == "البحث برقم المجموعة")
            {
                txtSearchG.KeyPress -= ClassGenric.AhadiText;
                txtSearchG.KeyPress += ClassGenric.AhadiTextNum;
                txtSearchG.Text = "";
            }
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvUnit.CurrentRow.Index;
        }

        private void btnUpdeatUnit_Click(object sender, EventArgs e)
        {
            con.Open();
            index = dgvGroupItems.CurrentRow.Index;
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM unit_items", con);
            dta.Fill(UserDT);
            int id;
            DateTime date, time;
            string name, userA;
            id = Convert.ToInt32(UserDT.Rows[index]["id_unit"]);
            name = UserDT.Rows[index]["name_unit"].ToString();
            date = Convert.ToDateTime(UserDT.Rows[index]["date_unit"]);
            time = Convert.ToDateTime(UserDT.Rows[index]["time_unit"]);
            userA = UserDT.Rows[index]["user_unit"].ToString();
            FaddU = new FormAddUnit(id, name, date, time, userA, index);
            FaddU.ShowDialog();
            con.Close();
        }

        private void btnDelUnit_Click(object sender, EventArgs e)
        {
            index = dgvUnit.CurrentRow.Index;
            if (index >= 0)
            {
                MessagBoxH mg = new MessagBoxH(1, "هل تريد بالتاكيد حذف الوحدة");
                mg.ShowDialog();
                if (mg.result())
                {                    
                    UserDT.Rows[index].Delete();
                    new MessagBoxH(0, "تم الحذف بنجاح").ShowDialog();
                    OleDbCommandBuilder save = new OleDbCommandBuilder(dta);
                    dta.Update(UserDT);
                    UserDT.AcceptChanges();
                    dgvGroupItems.DataSource = UserDT;
                }
            }
            chickDataU();
        }
        private void chickDataU()
        {
            if (dgvUnit.Rows.Count == 0)
            {
                btnDelUnit.Enabled = false;
                btnSearchUnit.Enabled = false;
                btnUpdeatUnit.Enabled = false;
            }
            else
            {
                if (txtSearchU.Text != "")
                    btnSearchUnit.Enabled = true;
                else
                    btnSearchUnit.Enabled = false;
                btnDelUnit.Enabled = true;
                btnUpdeatUnit.Enabled = true;
            }
        }

        private void comSearchU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSearchU.Text == "البحث باسم الوحدة")
            {
                txtSearchU.KeyPress -= ClassGenric.AhadiTextNum;
                txtSearchU.KeyPress += ClassGenric.AhadiText;
                txtSearchU.Text = "";
            }
            else if (comSearchU.Text == "البحث برقم الوحدة")
            {
                txtSearchU.KeyPress -= ClassGenric.AhadiText;
                txtSearchU.KeyPress += ClassGenric.AhadiTextNum;
                txtSearchU.Text = "";
            }
        }

        private void btnSearchUnit_Click(object sender, EventArgs e)
        {
            if (comSearchU.Text == "البحث باسم الوحدة")
            {                
                UserDT.Clear();
                UserDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM unit_items where name_unit like '%" + txtSearchU.Text + "%'", con);
                dta.Fill(UserDT);
                dgvUnit.DataSource = UserDT;
            }
            else if (comSearchU.Text == "البحث برقم الوحدة")
            {             
                UserDT.Clear();
                UserDT = new DataTable();
                dta = new OleDbDataAdapter("SELECT * FROM unit_items where id_unit like '%" + txtSearchU.Text + "%'", con);
                dta.Fill(UserDT);
                dgvUnit.DataSource = UserDT;
            }
            else
            {
                new MessagBoxH(2, "فضلا إختر نوع البحت").ShowDialog();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUnit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefUnit_Click(object sender, EventArgs e)
        {
            index = 1;
            UserDT.Clear();
            UserDT = new DataTable();
            dta = new OleDbDataAdapter("SELECT * FROM unit_items", con);
            dta.Fill(UserDT);
            dgvUnit.DataSource = UserDT;
            btnSearchUnit.Enabled = false;
            txtSearchU.Text = "";
            comSearchU.Text = "إختر نوع البحث";
            chickDataU();
        }

        private void txtSearchU_TextChanged(object sender, EventArgs e)
        {
            chickDataU();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
