using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SuperSoft
{
    public partial class Login : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        OleDbCommand cmd = new OleDbCommand();
        SuperM SM = new SuperM();
        public Login()
        {
            InitializeComponent();            
            this.Visible = true;
            btnLogin.Enabled = false;
            TxtU.Text= "اسم المستخدم";
            TxtP.Text = "كلمة المرور";
            focsP.Focus();                        
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labVisUnit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void panelHeadGroup_MouseDown(object sender, MouseEventArgs e)
        {
            

        }
        private void labVisUnit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from users";
            bool flg = false;
            if (CheckTextEmpty())
            { 
            OleDbDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                if (TxtU.Text == drr["username"].ToString() && TxtP.Text.Trim() == (drr["pass_user"].ToString()))
                {
                    flg = true;
                }
            }
            if (flg)
            {
                    this.Visible = false;
                    SM.Show();
                }
            else
            {
                new MessagBoxH(2, " المستخدم او كلمة المرور خاطئة").ShowDialog();
            }                                  
            }
            else
                new MessagBoxH(2, "يوجد حقل فارغ!").ShowDialog();
            con.Close();
        }

        private bool CheckTextEmpty()
        {
            if (TxtU.Text.Trim() != "اسم المستخدم" && TxtU.Text.Trim() != "")
            {
                if (TxtP.Text.Trim() != "كلمة المرور" && TxtP.Text.Trim() != "")
                {
                    btnLogin.Enabled = true;
                    return true;
                }
            }
            btnLogin.Enabled = false;
            return false;
        }
        private bool CheckTextU()
        {
            if (TxtU.Text.Trim() != "" || TxtU.Text.Trim() == "اسم المستخدم" )
            {
                return true;
            }            
            return false;
        }
        private bool CheckTextP()
        {
            if (TxtP.Text.Trim() == "كلمة المرور" || TxtP.Text.Trim() != "")
            {
                return true;
            }
            return false;
        }
          
        private void panelBackColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtU_Leave(object sender, EventArgs e)
        {
            if (!CheckTextU())
                TxtU.Text = "اسم المستخدم";
           
        }

        private void TxtU_TextChanged(object sender, EventArgs e)
        {
            CheckTextEmpty();
        }

        private void TxtP_Leave_1(object sender, EventArgs e)
        {
            if (!CheckTextP())
                TxtP.Text = "كلمة المرور";
        }

        private void TxtP_TextChanged(object sender, EventArgs e)
        {
            CheckTextEmpty();
        }

        private void TxtU_Enter(object sender, EventArgs e)
        {
            if(TxtU.Text == "اسم المستخدم")
            {
                TxtU.Text = "";
            }

        }

        private void TxtP_Enter(object sender, EventArgs e)
        {
            if (TxtP.Text == "كلمة المرور")
            {
                TxtP.Text = "";
            }
        }
            }
}
