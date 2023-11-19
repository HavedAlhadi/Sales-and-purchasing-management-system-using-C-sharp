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
    public partial class Form_AddUser : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable UserDT= new DataTable();
        DataTable UserDT1 = new DataTable();
        OleDbDataAdapter UserDA;
        OleDbDataAdapter UserDA1;
        int MaxId = 1;
        int INDEX=0;

        //======================================================
        public Form_AddUser()
        {
            InitializeComponent();
            this.Height = 330;
            BtnUEdit.Visible = false;
            Btn_SaveDataUser.Visible = true;
            txt_Fillname.KeyPress += ClassGenric.AhadiText;
            txt_PhoneNumber.KeyPress += ClassGenric.AhadiTextNum;                    
            DPDUser.Value = DateTime.Now.Date;
            DPTUser.Value = DateTime.Now;            
            getIdUser();
        }
        //======================================================
        public Form_AddUser(int id,string FName, string NPhon, string nameU, string Pass,DateTime date, DateTime time, string userU,int i)
        {
            InitializeComponent();
            this.Height = 330;
            Btn_SaveDataUser.Visible=false;
            BtnUEdit.Visible = true;
            INDEX = i;
            txt_IdUser.Text = id.ToString();
            txt_Fillname.Text = FName;
            txt_PhoneNumber.Text = NPhon;
            txt_NameUser.Text = nameU;
            txtUserPass.Text = Pass;
            DPDUser.Value = date;
            DPTUser.Value = time;
            if(nameU=="")
            {
                checkBUser.Checked = false;
            }
            else
            {
                checkBUser.Checked = true;
            }
        }

        //دالة ترجع أكبر  قيمة في حقل الأيدي
        private void getIdUser()
        {
            UserDT.Clear();
            UserDT1.Clear();            
            //فحص هل يحتوي الجدول على قيم
            UserDA1 = new OleDbDataAdapter("SELECT * FROM users ", con);
            UserDA1.Fill(UserDT1);
            //   MAX(id_user) 
            UserDA = new OleDbDataAdapter("SELECT MAX(id_user) FROM users", con);
            UserDA.Fill(UserDT);
            if (UserDT1.Rows.Count==0)
            {
                MaxId = 1;
            }
            else 
            {
                MaxId = Convert.ToInt32(UserDT.Rows[0][0]);
                MaxId += 1;                
            }            
            txt_IdUser.Text = (MaxId).ToString();            
        }       
        
        FormMangUser f;
        private void Btn_RegisterUser_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].MdiChildren.Count() > 0)
            {
                foreach (Form fd in Application.OpenForms[1].MdiChildren)
                {
                    if (fd is FormMangUser)
                    {
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                f = new FormMangUser();
                f.Dock = DockStyle.Fill;
                f.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(f);
                f.BringToFront();
                f.Show();
            }
            else
            {
                f = new FormMangUser();
                f.Dock = DockStyle.Fill;
                f.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(f);
                f.BringToFront();
                f.Show();
            }            
            this.Close();
        }

        private void Form_AddUser_Load(object sender, EventArgs e)
        {
            txt_Fillname.Focus();           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBUser.Checked)
            {
                this.Height = 410;
                panelkeys.Visible = true;                
            }
            else
            { 
                panelkeys.Visible = false;
                this.Height = 330;
            }
        }

        private void Btn_SaveDataUser_Click(object sender, EventArgs e)
        {
            UserDT.Clear();
            //الطريقة المنفصلة
            try
            {
                con.Open();
                UserDA = new OleDbDataAdapter("SELECT * FROM users", con);
                UserDA.Fill(UserDT);
                UserDT.Rows.Add();
                int Idnew = UserDT.Rows.Count - 1;
                //----------------------------------------------------
                UserDT.Rows[Idnew]["id_user"] = txt_IdUser.Text;
                UserDT.Rows[Idnew]["fillname_user"] = txt_Fillname.Text;
                UserDT.Rows[Idnew]["phone_user"] = txt_PhoneNumber.Text;
                UserDT.Rows[Idnew]["date_user"] = DPDUser.Value;
                UserDT.Rows[Idnew]["time_user"] = DPTUser.Value;
                UserDT.Rows[Idnew]["user_adduser"] = txt_UserAddUser.Text;
                if (checkBUser.Checked)
                {
                    UserDT.Rows[Idnew]["username"] = txt_NameUser.Text;
                    UserDT.Rows[Idnew]["pass_user"] = txtUserPass.Text;
                }
                //-----------------------------------------------------
                if(CheckTextEmpty())
                {
                    if(CheckUserName())
                    {
                        OleDbCommandBuilder save = new OleDbCommandBuilder(UserDA);
                        UserDA.Update(UserDT);
                        UserDT.AcceptChanges();
                        new MessagBoxH().ShowDialog();
                        ClearTextBox();
                    }
                    else
                    {
                        new MessagBoxH(2, "اسم المستخدم موجود").ShowDialog();
                    }                
                }
                else
                {
                    new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
                }
            }
            catch (OleDbException xx)
            { new MessagBoxH(2, " خطأ " + xx.Message).ShowDialog(); }
            finally { con.Close(); }            
        }
        public void ClearTextBox()
        {
            getIdUser();
            foreach (Control t in this.Controls.OfType<Panel>())
            {
                foreach (TextBox tx in t.Controls.OfType<TextBox>())
                    tx.Text = "";
            }           
            txt_IdUser.Text = (MaxId).ToString();
            checkBUser.Checked = false;
            DPDUser.Value = DateTime.Now.Date;
            DPTUser.Value = DateTime.Now;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckTextEmpty()
        {           
            if (txt_Fillname.Text.Trim()!=""&& txt_PhoneNumber.Text.Trim() != "")
            {
                if (checkBUser.Checked==true )
                {
                    if(txt_NameUser.Text.Trim() != "" && txtUserPass.Text.Trim() != "")
                    return true;
                    else
                    {
                        txtUserPass.Focus();
                        return false;
                    }
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
        private bool CheckUserName()
        {
            UserDT1.Clear();
            UserDA1 = new OleDbDataAdapter("SELECT (username) FROM users where username='" + txt_NameUser.Text + "'", con);
            UserDA1.Fill(UserDT1);
            if (UserDT1.Rows.Count > 0)
            {
                txt_NameUser.ForeColor = Color.Red;
                txt_NameUser.Focus();
                return false;
            }
            else
            {
                txt_NameUser.ForeColor = Color.Black;               
            }
            return true;
        }
        private void txt_NameUser_Leave(object sender, EventArgs e)
        {
            CheckUserName();
        }

        private void BtnUEdit_Click(object sender, EventArgs e)
        {
            UserDT.Clear();
            //الطريقة المنفصلة
            try
            {
                con.Open();
                UserDA = new OleDbDataAdapter("SELECT * FROM users", con);
                UserDA.Fill(UserDT);                
                int Idnew = INDEX;
                //----------------------------------------------------
                UserDT.Rows[Idnew]["id_user"] = txt_IdUser.Text;
                UserDT.Rows[Idnew]["fillname_user"] = txt_Fillname.Text;
                UserDT.Rows[Idnew]["phone_user"] = txt_PhoneNumber.Text;
                UserDT.Rows[Idnew]["date_user"] = DateTime.Now.Date;
                UserDT.Rows[Idnew]["time_user"] = DateTime.Now;
                UserDT.Rows[Idnew]["user_adduser"] = txt_UserAddUser.Text;
                if (checkBUser.Checked)
                {
                    UserDT.Rows[Idnew]["username"] = txt_NameUser.Text;
                    UserDT.Rows[Idnew]["pass_user"] = txtUserPass.Text;
                }
                //-----------------------------------------------------
                if (CheckTextEmpty())
                {
                    if (CheckUserName() || (txt_NameUser.Text == UserDT.Rows[Idnew]["username"].ToString()))
                    {
                        OleDbCommandBuilder save = new OleDbCommandBuilder(UserDA);
                        UserDA.Update(UserDT);
                        UserDT.AcceptChanges();
                        new MessagBoxH(0,"تم التعديل بنجاح").ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        new MessagBoxH(2, "اسم المستخدم موجود").ShowDialog();
                    }
                }
                else
                {
                    new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
                }                
            }
            catch (OleDbException xx)
            { new MessagBoxH(2, "اسم المستخدم موجود").ShowDialog(); }
            finally { con.Close(); }
            
        }
    }
}
