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
    public partial class FormAddUnit : Form
    {

        OleDbConnection con = ClassGenric.Conaction();
        DataTable UnitItemsDT = new DataTable();
        DataTable UnitItemsDT1 = new DataTable();
        OleDbDataAdapter UnitItemsDA;
        OleDbDataAdapter UnitItemsDA1;
        int MaxId = 1;
        int INDEX = 0;
        //######################################################
        //######################################################
        
        public FormAddUnit()
        {
            InitializeComponent();
            btnSaveDataUnit.Visible = true;
            btnEditU.Visible = false;
            txtNameUnit.KeyPress += ClassGenric.AhadiText;
            DPDUnit.Value = DateTime.Now.Date;
            DPTUnit.Value = DateTime.Now;
            getIdUser();
        }

        //######################################################
        //######################################################
        public FormAddUnit(int id, string text, DateTime date, DateTime time, string UserA, int i)
        {
            InitializeComponent();
            btnSaveDataUnit.Visible = false;
            btnEditU.Visible = true;
            txtIdUnit.Text = id.ToString();
            txtNameUnit.Text = text;
            txtUsetAU.Text = UserA;
            INDEX = i;
            txtNameUnit.KeyPress += ClassGenric.AhadiText;
            DPDUnit.Value = date;
            DPTUnit.Value = time;
        }
        //######################################################
        //######################################################
        private void getIdUser()
        {
            UnitItemsDT.Clear();
            UnitItemsDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            UnitItemsDA1 = new OleDbDataAdapter("SELECT * FROM  unit_items", con);
            UnitItemsDA1.Fill(UnitItemsDT1);
            //   MAX(id_unit) أكبر قيمة في قاعدة البيانات  
            UnitItemsDA = new OleDbDataAdapter("SELECT MAX(id_unit) FROM unit_items", con);
            UnitItemsDA.Fill(UnitItemsDT);
            if (UnitItemsDT1.Rows.Count == 0)
            {
                MaxId = 1;
            }
            else
            {
                MaxId = Convert.ToInt32(UnitItemsDT.Rows[0][0]);
                MaxId += 1;
            }
            txtIdUnit.Text = (MaxId).ToString();
        }
        //######################################################
        //######################################################


        private void FormAddUnit_Load(object sender, EventArgs e)
        {

        }

        private void labVisUnit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FormMangGU FMGU; 
        private void btnRegisterUnit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Controls[0].Controls.Count > 0)
            {
                foreach (Control fd in Application.OpenForms[1].Controls[0].Controls)
                {
                    if (fd is FormMangGU)
                    {
                        fd.Controls[0].Visible = false;
                        fd.Controls[1].Visible = true;
                        fd.Controls[6].Controls[0].Enabled = false;
                        fd.Controls[6].Controls[1].Enabled = true;
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                FMGU = new FormMangGU(0);
                FMGU.Dock = DockStyle.Fill;
                FMGU.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FMGU);
                FMGU.BringToFront();
                FMGU.Show();
            }
            else
            {
                FMGU = new FormMangGU(0);
                FMGU.TopLevel = false;
                FMGU.Dock = DockStyle.Fill;
                Application.OpenForms[1].Controls[0].Controls.Add(FMGU);
                FMGU.BringToFront();
                FMGU.Show();
            }
            this.Close();

        }
        private bool CheckUnitName()
        {
            UnitItemsDT1.Clear();
            UnitItemsDA1 = new OleDbDataAdapter("SELECT (name_unit) FROM unit_items where name_unit='" + txtNameUnit.Text + "'", con);
            UnitItemsDA1.Fill(UnitItemsDT1);
            if (UnitItemsDT1.Rows.Count > 0)
            {
                txtNameUnit.ForeColor = Color.Red;
                txtNameUnit.Focus();
                return false;
            }
            else
            {
                txtNameUnit.ForeColor = Color.Black;
            }
            return true;
        }
        private void panelRigUnit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveDataUnit_Click(object sender, EventArgs e)
        {
            UnitItemsDT.Clear();
            //الطريقة المنفصلة
            try
            {
                if (txtNameUnit.Text.Trim() != "")
                {
                    if (CheckUnitName())
                    {
                        con.Open();
                        UnitItemsDA = new OleDbDataAdapter("SELECT * FROM unit_items", con);
                        UnitItemsDA.Fill(UnitItemsDT);
                        UnitItemsDT.Rows.Add();
                        int Idnew = UnitItemsDT.Rows.Count - 1;
                        //----------------------------------------------------
                        UnitItemsDT.Rows[Idnew]["id_unit"] = txtIdUnit.Text;
                        UnitItemsDT.Rows[Idnew]["name_unit"] = txtNameUnit.Text;
                        UnitItemsDT.Rows[Idnew]["date_unit"] = DPDUnit.Value;
                        UnitItemsDT.Rows[Idnew]["time_unit"] = DPTUnit.Value;
                        UnitItemsDT.Rows[Idnew]["user_unit"] = txtUsetAU.Text;
                        OleDbCommandBuilder save = new OleDbCommandBuilder(UnitItemsDA);
                        UnitItemsDA.Update(UnitItemsDT);
                        UnitItemsDT.AcceptChanges();
                        new MessagBoxH().ShowDialog();
                        ClearTextBox();
                        txtNameUnit.Focus();
                    }
                    else
                    {
                        new MessagBoxH(2, "اسم الوحدة موجود").ShowDialog();
                    }
                }
                else
                {
                    new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
                    txtNameUnit.Focus();
                }
            }
            catch (OleDbException xx)
            { new MessagBoxH(2, " خطأ " + xx.Message).ShowDialog(); }
            finally { con.Close(); }
        }

        public void ClearTextBox()
        {
            getIdUser();
            txtNameUnit.Text = "";
            txtNameUnit.Focus();
            DPDUnit.Value = DateTime.Now.Date;
            DPTUnit.Value = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //الطريقة المنفصلة
            try
            {
                con.Open();
                UnitItemsDA = new OleDbDataAdapter("SELECT * FROM unit_items", con);
                UnitItemsDA.Fill(UnitItemsDT);
                int Idnew = INDEX;
                //----------------------------------------------------
                UnitItemsDT.Rows[Idnew]["id_unit"] = txtIdUnit.Text;
                UnitItemsDT.Rows[Idnew]["name_unit"] = txtNameUnit.Text;
                UnitItemsDT.Rows[Idnew]["date_unit"] = DPDUnit.Value;
                UnitItemsDT.Rows[Idnew]["time_unit"] = DPTUnit.Value;
                UnitItemsDT.Rows[Idnew]["user_unit"] = txtUsetAU.Text;
                //-----------------------------------------------------
                if (txtNameUnit.Text.Trim() != "")
                {
                    if (CheckUnitName() && (txtNameUnit.Text == UnitItemsDT.Rows[Idnew]["name_unit"].ToString()))
                    {
                        OleDbCommandBuilder save = new OleDbCommandBuilder(UnitItemsDA);
                        UnitItemsDA.Update(UnitItemsDT);
                        UnitItemsDT.AcceptChanges();
                        new MessagBoxH(0, "تم التعديل بنجاح").ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        new MessagBoxH(2, "اسم الوحدة موجود").ShowDialog();
                    }
                }
                else
                {
                    new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
                }
            }
            catch (OleDbException xx)
            { new MessagBoxH(2, "اسم الوحدة موجود").ShowDialog(); }
            finally { con.Close(); }
        }

        private void txtNameUnit_TextChanged(object sender, EventArgs e)
        {
            CheckUnitName();
        }

        private void txtNameUnit_Leave(object sender, EventArgs e)
        {
            CheckUnitName();
        }
    }
}
