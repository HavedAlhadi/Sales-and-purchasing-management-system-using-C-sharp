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
    public partial class FormAddImpo : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable ImpoDT = new DataTable();
        DataTable ImpoDT1 = new DataTable();
        OleDbDataAdapter ImpoDA;
        OleDbDataAdapter ImpoDA1;
        int MaxId = 1;
        int INDEX = 0;
        public FormAddImpo()
        {
            InitializeComponent();
            BtnSaveImpo.Visible = true;
            btnEditeImpo.Visible = false;
            txtNameImpo.KeyPress -= ClassGenric.AhadiTextNum;
            txtNameImpo.KeyPress += ClassGenric.AhadiText;
            txtPhoneImpo.KeyPress -= ClassGenric.AhadiText;
            txtPhoneImpo.KeyPress += ClassGenric.AhadiTextNum;
            txtbalanceImpo.KeyPress -= ClassGenric.AhadiText;
            txtbalanceImpo.KeyPress += ClassGenric.AhadiTextNum;
            DPDImpo.Value = DateTime.Now.Date;
            DPTImpo.Value = DateTime.Now;
            getIdUser();

        }
        public FormAddImpo(int id, string CName, string CPh, DateTime date, DateTime time, string Cbalance, string Cgender, string Ctype, string CNote, string userA, int i)
        {
            InitializeComponent();
            btnEditeImpo.Visible = true;
            BtnSaveImpo.Visible = false;
            INDEX = i;
            txtIdImpo.Text = id.ToString();
            txtNameImpo.Text = CName;
            txtPhoneImpo.Text = CPh;            
            txtbalanceImpo.Text = Cbalance;
            if (Cgender == "ذكر")
                Male.Checked = true;
            else
                Famle.Checked = true;
            if (Ctype == "نقد")
                Cash.Checked = true;
            else
                postpone.Checked = true;
            txtNoteImpo.Text = CNote;
            txtUasrImpo.Text = userA;
            DPDImpo.Value = date;
            DPTImpo.Value = time;
        }

        //دالة ترجع أكبر  قيمة في حقل الأيدي
        private void getIdUser()
        {
            ImpoDT.Clear();
            ImpoDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            ImpoDA1 = new OleDbDataAdapter("SELECT * FROM  importer", con);
            ImpoDA1.Fill(ImpoDT1);
            //   MAX(id_impo) 
            ImpoDA = new OleDbDataAdapter("SELECT MAX(id_impo) FROM importer", con);
            ImpoDA.Fill(ImpoDT);
            if (ImpoDT1.Rows.Count == 0)
            {
                MaxId = 1;
            }
            else
            {
                MaxId = Convert.ToInt32(ImpoDT.Rows[0][0]);
                MaxId += 1;
            }
            txtIdImpo.Text = (MaxId).ToString();
        }
        //دالة فحص الحقول الفارغة
        private bool CheckTextEmpty()
        {
            if (txtNameImpo.Text.Trim() != "" && txtPhoneImpo.Text.Trim() != "")
            {
                if (Male.Checked == false && Famle.Checked == false)
                {
                    if (Cash.Checked == false && postpone.Checked == false)
                    {
                        return false;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
        //دالة لفحص هل القيمة موجودة سابقا أم لا
        private bool CheckPremery(string s1, TextBox t)
        {
            ImpoDT1.Clear();
            ImpoDA1 = new OleDbDataAdapter("SELECT ('" + s1 + "') FROM importer where'" + s1 + "'='" + t.Text + "'", con);
            ImpoDA1.Fill(ImpoDT1);
            if (ImpoDT1.Rows.Count > 0)
            {
                t.ForeColor = Color.Red;
                t.Focus();
                return false;
            }
            else
            {
                t.ForeColor = Color.Black;
            }
            return true;
        }
        private void labCloseFAddIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddImpo_Load(object sender, EventArgs e)
        {

        }
        FormMangImpo FAI ;
        private void Btn_RegisterImpo_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms[1].Controls[0].Controls.Count > 0)
            {
                foreach (Control fd in Application.OpenForms[1].Controls[0].Controls)
                {
                    if (fd is FormMangImpo)
                    {
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                FAI = new FormMangImpo();
                FAI.Dock = DockStyle.Fill;
                FAI.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FAI);
                FAI.BringToFront();
                FAI.Show();
            }
            else
            {
                FAI = new FormMangImpo();
                FAI.Dock = DockStyle.Fill;
                FAI.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FAI);
                FAI.BringToFront();
                FAI.Show();
            }
            this.Close();           
        }

        private void DPDCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ImpoDT.Clear();
            //الطريقة المنفصلة
            try
            {

                if (CheckTextEmpty())
                {
                    if (CheckPremery("name_impo", txtNameImpo))
                    {
                        if (CheckPremery("phone_impo", txtPhoneImpo))
                        {
                            con.Open();
                            ImpoDA = new OleDbDataAdapter("SELECT * FROM importer", con);
                            ImpoDA.Fill(ImpoDT);
                            ImpoDT.Rows.Add();
                            int Idnew = ImpoDT.Rows.Count - 1;
                            //----------------------------------------------------                           
                            ImpoDT.Rows[Idnew]["id_impo"] = txtIdImpo.Text;
                            ImpoDT.Rows[Idnew]["name_impo"] = txtNameImpo.Text;
                            ImpoDT.Rows[Idnew]["phone_impo"] = txtPhoneImpo.Text;                            
                            ImpoDT.Rows[Idnew]["date_impo"] = DPDImpo.Value;
                            ImpoDT.Rows[Idnew]["time_impo"] = DPTImpo.Value;
                            ImpoDT.Rows[Idnew]["balance_impo"] = txtbalanceImpo.Text;
                            if (Male.Checked == true)
                            {
                                ImpoDT.Rows[Idnew]["gender_impo"] = Male.Text;
                            }
                            else
                                ImpoDT.Rows[Idnew]["gender_impo"] = Famle.Text;
                            if (Cash.Checked == true)
                            {
                                ImpoDT.Rows[Idnew]["type_impo"] = Cash.Text;
                            }
                            else
                                ImpoDT.Rows[Idnew]["type_impo"] = postpone.Text;

                            ImpoDT.Rows[Idnew]["note_impo"] = txtNoteImpo.Text;
                            ImpoDT.Rows[Idnew]["user_impo"] = txtUasrImpo.Text;
                            //-----------------------------------------------------
                            OleDbCommandBuilder save = new OleDbCommandBuilder(ImpoDA);
                            ImpoDA.Update(ImpoDT);
                            ImpoDT.AcceptChanges();
                            new MessagBoxH().ShowDialog();
                            ClearTextBox();
                        }
                    }
                    else
                    {
                        new MessagBoxH(2, "العميل موجود").ShowDialog();
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
        //زر تعديل التهيئة للإضافة مرة أخرى
        public void ClearTextBox()
        {
            getIdUser();
            foreach (Control t in this.Controls.OfType<TextBox>())
            {
                t.Text = "";
            }
            txtUasrImpo.Text = "haved";
            txtIdImpo.Text = (MaxId).ToString();
            DPDImpo.Value = DateTime.Now.Date;
            DPTImpo.Value = DateTime.Now;
            Cash.Checked = false;
            postpone.Checked = false;
            Male.Checked = false;
            Famle.Checked = false;
        }

        private void btnEditeImpo_Click(object sender, EventArgs e)
        {
            ImpoDT.Clear();
            //الطريقة المنفصلة
            try
            {
                con.Open();
                ImpoDA = new OleDbDataAdapter("SELECT * FROM importer", con);
                ImpoDA.Fill(ImpoDT);               
                int Idnew = INDEX;
                if (CheckTextEmpty())
                {
                    if (CheckPremery("name_impo", txtNameImpo) || (txtNameImpo.Text == ImpoDT.Rows[Idnew]["name_impo"].ToString()))
                    {
                        if (CheckPremery("phone_impo", txtPhoneImpo)|| (txtPhoneImpo.Text == ImpoDT.Rows[Idnew]["phone_impo"].ToString()))
                        {
                            //----------------------------------------------------                           
                            ImpoDT.Rows[Idnew]["id_impo"] = txtIdImpo.Text;
                            ImpoDT.Rows[Idnew]["name_impo"] = txtNameImpo.Text;
                            ImpoDT.Rows[Idnew]["phone_impo"] = txtPhoneImpo.Text;                            
                            ImpoDT.Rows[Idnew]["date_impo"] = DPDImpo.Value;
                            ImpoDT.Rows[Idnew]["time_impo"] = DPTImpo.Value;
                            ImpoDT.Rows[Idnew]["balance_impo"] = txtbalanceImpo.Text;
                            if (Male.Checked == true)
                            {
                                ImpoDT.Rows[Idnew]["gender_impo"] = Male.Text;
                            }
                            else
                                ImpoDT.Rows[Idnew]["gender_impo"] = Famle.Text;
                            if (Cash.Checked == true)
                            {
                                ImpoDT.Rows[Idnew]["type_impo"] = Cash.Text;
                            }
                            else
                                ImpoDT.Rows[Idnew]["type_impo"] = postpone.Text;
                            ImpoDT.Rows[Idnew]["note_impo"] = txtNoteImpo.Text;
                            ImpoDT.Rows[Idnew]["user_impo"] = txtUasrImpo.Text;
                            //-----------------------------------------------------
                            OleDbCommandBuilder save = new OleDbCommandBuilder(ImpoDA);
                            ImpoDA.Update(ImpoDT);
                            ImpoDT.AcceptChanges();
                            new MessagBoxH(0, "تم التعديل بنجاح").ShowDialog();
                            this.Close();                            
                        }
                    }
                    else
                    {
                        new MessagBoxH(2, "المورد موجود").ShowDialog();
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

    }
}
