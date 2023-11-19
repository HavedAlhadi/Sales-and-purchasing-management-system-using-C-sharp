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
    public partial class Form_AddGroup : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable GroupItemsDT = new DataTable();
        DataTable GroupItemsDT1 = new DataTable();
        OleDbDataAdapter GroupItemsDA;
        OleDbDataAdapter GroupItemsDA1;
        int MaxId = 1;
        int INDEX = 0;

        //======================================================
        //======================================================
        public Form_AddGroup()
        {
            InitializeComponent();
            btnSaveDataGroup.Visible = true;
            btnEditG.Visible = false;
            txtNameGroup.KeyPress += ClassGenric.AhadiText;            
            DPDGroupI.Value = DateTime.Now.Date;
            DPTGroupI.Value = DateTime.Now;
            getIdGruop();
        }

        //======================================================
        //======================================================
        public Form_AddGroup(int id, string text, DateTime date, DateTime time, string UserA, int i)
        {
            InitializeComponent();
            btnSaveDataGroup.Visible = false;
            btnEditG.Visible = true;
            txtIdGroup.Text = id.ToString();
            txtNameGroup.Text = text;
            txtUsetAG.Text = UserA;
            INDEX = i;
            txtNameGroup.KeyPress += ClassGenric.AhadiText;
            DPDGroupI.Value = date;
            DPTGroupI.Value = time;            
        }
        //======================================================
        //======================================================

        private void getIdGruop()
        {
            GroupItemsDT.Clear();
            GroupItemsDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            GroupItemsDA1 = new OleDbDataAdapter("SELECT * FROM  group_items", con);
            GroupItemsDA1.Fill(GroupItemsDT1);
            //   MAX(id_group) أكبر قيمة في قاعدة البيانات  
            GroupItemsDA = new OleDbDataAdapter("SELECT MAX(id_group) FROM group_items", con);
            GroupItemsDA.Fill(GroupItemsDT);
            if (GroupItemsDT1.Rows.Count == 0)
            {
                MaxId = 1;
            }
            else
            {
                MaxId = Convert.ToInt32(GroupItemsDT.Rows[0][0]);
                MaxId += 1;
            }
            txtIdGroup.Text = (MaxId).ToString();
        }
        //======================================================
        //======================================================

        private void Form2_AddGroup_Load(object sender, EventArgs e)
        {
            txtNameGroup.Focus();
        }
        //======================================================
        //======================================================

        private void labVisUnit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //======================================================
        //======================================================

        FormMangGU FMGU;
        private void btnRegisterGroup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Controls[0].Controls.Count > 0)
            {
                foreach (Control fd in Application.OpenForms[1].Controls[0].Controls)
                {
                    if (fd is FormMangGU)
                    {
                        fd.Controls[1].Visible = false;
                        fd.Controls[0].Visible = true;
                        fd.Controls[6].Controls[1].Enabled = false;
                        fd.Controls[6].Controls[0].Enabled = true;
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                FMGU = new FormMangGU(1);
                FMGU.Dock = DockStyle.Fill;
                FMGU.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FMGU);
                FMGU.BringToFront();
                FMGU.Show();
            }
            else
            {
                FMGU = new FormMangGU(1);
                //FMGU.BringToFront();
                FMGU.TopLevel = false;
                FMGU.Dock = DockStyle.Fill;
                Application.OpenForms[1].Controls[0].Controls.Add(FMGU);
                FMGU.Show();
            }
            this.Close();
        }
        private bool CheckGroupName()
        {
            GroupItemsDT1.Clear();
            GroupItemsDA1 = new OleDbDataAdapter("SELECT (name_group) FROM group_items where name_group='" + txtNameGroup.Text + "'", con);
            GroupItemsDA1.Fill(GroupItemsDT1);
            if (GroupItemsDT1.Rows.Count > 0)
            {
                txtNameGroup.ForeColor = Color.Red;
                txtNameGroup.Focus();
                return false;
            }
            else
            {
                txtNameGroup.ForeColor = Color.Black;
            }
            return true;
        }
        // إضافة مجموعة 
        private void btnSaveDataGroup_Click(object sender, EventArgs e)
        {
            GroupItemsDT.Clear();
                       try
            {
                if (txtNameGroup.Text.Trim()!= "")
                {
                    if (CheckGroupName())
                    {
                        con.Open();
                        GroupItemsDA = new OleDbDataAdapter("SELECT * FROM group_items", con);
                        GroupItemsDA.Fill(GroupItemsDT);
                        GroupItemsDT.Rows.Add();
                        int Idnew = GroupItemsDT.Rows.Count - 1;
                        //----------------------------------------------------
                        GroupItemsDT.Rows[Idnew]["id_group"] = txtIdGroup.Text;
                        GroupItemsDT.Rows[Idnew]["name_group"] = txtNameGroup.Text;
                        GroupItemsDT.Rows[Idnew]["date_group"] = DPDGroupI.Value;
                        GroupItemsDT.Rows[Idnew]["time_group"] = DPTGroupI.Value;
                        GroupItemsDT.Rows[Idnew]["user_group"] = txtUsetAG.Text;
                        OleDbCommandBuilder save = new OleDbCommandBuilder(GroupItemsDA);
                        GroupItemsDA.Update(GroupItemsDT);
                        GroupItemsDT.AcceptChanges();
                        new MessagBoxH().ShowDialog();
                        ClearTextBox();
                        txtNameGroup.Focus();
                    }
                    else
                    {
                        new MessagBoxH(2, "المجموعة موجودة!").ShowDialog();
                    }
                }
                else
                {
                    new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
                    txtNameGroup.Focus();
                }
            }
            catch (OleDbException xx)
            { new MessagBoxH(2, " خطأ " + xx.Message).ShowDialog(); }
            finally { con.Close(); }
        }

        //======================================================
        //======================================================
        public void ClearTextBox()
        {
            getIdGruop();
            txtNameGroup.Text = "";
            txtNameGroup.Focus();
            DPDGroupI.Value = DateTime.Now.Date;
            DPTGroupI.Value = DateTime.Now;
        }

        private void txtNameGroup_Leave(object sender, EventArgs e)
        {
            CheckGroupName();
        }
        // تعديل مجموعة 
        private void btnEditG_Click(object sender, EventArgs e)
        {
            GroupItemsDT.Clear();
            //الطريقة المنفصلة
            try
            {
                con.Open();
                GroupItemsDA = new OleDbDataAdapter("SELECT * FROM group_items", con);
                GroupItemsDA.Fill(GroupItemsDT);
                int Idnew = INDEX;
                //----------------------------------------------------
                GroupItemsDT.Rows[Idnew]["id_group"] = txtIdGroup.Text;
                GroupItemsDT.Rows[Idnew]["name_group"] = txtNameGroup.Text;
                GroupItemsDT.Rows[Idnew]["date_group"] = DPDGroupI.Value;
                GroupItemsDT.Rows[Idnew]["time_group"] = DPTGroupI.Value;
                GroupItemsDT.Rows[Idnew]["user_group"] = txtUsetAG.Text;
                //-----------------------------------------------------
                if (txtNameGroup.Text.Trim() != "")
                {
                    if (CheckGroupName() && (txtNameGroup.Text == GroupItemsDT.Rows[Idnew]["name_group"].ToString()))
                    {
                        OleDbCommandBuilder save = new OleDbCommandBuilder(GroupItemsDA);
                        GroupItemsDA.Update(GroupItemsDT);
                        GroupItemsDT.AcceptChanges();
                        new MessagBoxH(0, "تم التعديل بنجاح").ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        new MessagBoxH(2, "اسم المجموعة موجود").ShowDialog();
                    }
                }
                else
                {
                    new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
                }
            }
            catch (OleDbException xx)
            { new MessagBoxH(2, "اسم المجموعة موجود").ShowDialog(); }
            finally { con.Close(); }
        }
    }
}
