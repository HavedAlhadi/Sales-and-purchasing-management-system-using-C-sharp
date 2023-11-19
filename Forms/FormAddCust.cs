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
    public partial class FormAddCust : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT = new DataTable();
        DataTable CustDT1 = new DataTable();
        OleDbDataAdapter CustDA;
        OleDbDataAdapter CustDA1;
        int MaxId = 1;
        int INDEX = 0;

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public FormAddCust()
        {
            InitializeComponent();
            btnSaveCost.Visible = true;
            btnEdite.Visible = false;
            txtNameCost.KeyPress += ClassGenric.AhadiText;
            txtPhoneCost.KeyPress += ClassGenric.AhadiTextNum;
            txtbalanceCust.KeyPress += ClassGenric.AhadiTextNum;
            DPDCost.Value = DateTime.Now.Date;
            DPTCost.Value = DateTime.Now;
            getIdUser();
        }

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public FormAddCust(int id, string CName, string CPh, string Caddres, DateTime date, DateTime time, string Cbalance, string Cgender, string Ctype, string CNote, string userA, int i)
        {
            InitializeComponent();
            btnEdite.Visible = true;
            btnSaveCost.Visible = false;
            INDEX = i;
            txtIdCost.Text = id.ToString();
            txtNameCost.Text = CName;
            txtPhoneCost.Text = CPh;
            txtAdress.Text = Caddres;
            txtbalanceCust.Text = Cbalance;
            if (Cgender == "ذكر")
                Male.Checked = true;
            else
                Famle.Checked = true;
            if (Ctype == "نقد")
                Cash.Checked = true;
            else
                postpone.Checked = true;            
            txtMo.Text = CNote;
            txtUasrCost.Text = userA;
            DPDCost.Value = date;
            DPTCost.Value = time;
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //دالة ترجع أكبر  قيمة في حقل الأيدي
        private void getIdUser()
        {
            CustDT.Clear();
            CustDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            CustDA1 = new OleDbDataAdapter("SELECT * FROM  customer", con);
            CustDA1.Fill(CustDT1);
            //   MAX(id_Csst) 
            CustDA = new OleDbDataAdapter("SELECT MAX(id_cust) FROM customer", con);
            CustDA.Fill(CustDT);
            if (CustDT1.Rows.Count == 0)
            {
                MaxId = 1;
            }
            else
            {
                MaxId = Convert.ToInt32(CustDT.Rows[0][0]);
                MaxId += 1;
            }
            txtIdCost.Text = (MaxId).ToString();
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //دالة فحص الحقول الفارغة
        private bool CheckTextEmpty()
        {
            if (txtNameCost.Text.Trim() != "" && txtPhoneCost.Text.Trim() != "")
            {
                if (Male.Checked == false && Famle.Checked == false )
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
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //دالة لفحص هل القيمة موجودة سابقا أم لا
        private bool CheckPremery(string s1, TextBox t)
        {
            CustDT1.Clear();
            CustDA1 = new OleDbDataAdapter("SELECT ('" + s1 + "') FROM customer where'" + s1 + "'='" + t.Text + "'", con);
            CustDA1.Fill(CustDT1);
            if (CustDT1.Rows.Count > 0)
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

        private void FormAddCust_Load(object sender, EventArgs e)
        {

        }
        FormMangCust FMC;
        private void Btn_RegisterUser_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Controls[0].Controls.Count > 0)
            {
                foreach (Control fd in Application.OpenForms[1].Controls[0].Controls)
                {
                    if (fd is FormMangCust)
                    {
                        //panelContiner
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                FMC = new FormMangCust();
                FMC.Dock = DockStyle.Fill;
                FMC.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FMC);
                FMC.BringToFront();
                FMC.Show();
            }
            else
            {
                FMC = new FormMangCust();
                FMC.TopLevel = false;
                FMC.Dock = DockStyle.Fill;
                Application.OpenForms[1].Controls[0].Controls.Add(FMC);
                FMC.BringToFront();
                FMC.Show();
            }
            this.Close();            
        }

        private void txtIdCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameCost_TextChanged(object sender, EventArgs e)
        {

        }
        //زر إضافة الصنف
        private void btnSaveCost_Click(object sender, EventArgs e)
        {
            CustDT.Clear();
            //الطريقة المنفصلة
            try
            {

                if (CheckTextEmpty())
                {
                    if (CheckPremery("name_cust", txtNameCost))
                    {
                        if (CheckPremery("phon_cust", txtPhoneCost))
                        {
                            con.Open();
                            CustDA = new OleDbDataAdapter("SELECT * FROM customer", con);
                            CustDA.Fill(CustDT);
                            CustDT.Rows.Add();
                            int Idnew = CustDT.Rows.Count - 1;
                            //----------------------------------------------------                           
                            CustDT.Rows[Idnew]["id_cust"] = txtIdCost.Text;
                            CustDT.Rows[Idnew]["name_cust"] = txtNameCost.Text;
                            CustDT.Rows[Idnew]["phon_cust"] = txtPhoneCost.Text;
                            CustDT.Rows[Idnew]["addres_cust"] = txtAdress.Text;
                            CustDT.Rows[Idnew]["date_cust"] = DPDCost.Value;
                            CustDT.Rows[Idnew]["time_cust"] = DPTCost.Value;
                            CustDT.Rows[Idnew]["balance_cust"] = txtbalanceCust.Text;
                            if (Male.Checked == true)
                            {
                                CustDT.Rows[Idnew]["gender_cust"] = Male.Text;
                            }   
                            else
                                CustDT.Rows[Idnew]["gender_cust"] = Famle.Text;
                            if (Cash.Checked == true)
                            {
                                CustDT.Rows[Idnew]["type_cust"] = Cash.Text;
                            }
                            else
                                CustDT.Rows[Idnew]["type_cust"] = postpone.Text;
                           
                            CustDT.Rows[Idnew]["note_cust"] = txtMo.Text;
                            CustDT.Rows[Idnew]["uesr_cust"] = txtUasrCost.Text;
                            //-----------------------------------------------------
                            OleDbCommandBuilder save = new OleDbCommandBuilder(CustDA);
                            CustDA.Update(CustDT);
                            CustDT.AcceptChanges();
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
            txtIdCost.Text = (MaxId).ToString();
            DPDCost.Value = DateTime.Now.Date;            
            DPTCost.Value = DateTime.Now;
            Cash.Checked = false;
            postpone.Checked = false;
            Male.Checked = false;
            Famle.Checked = false;            
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            CustDT.Clear();
            //الطريقة المنفصلة
            try
            {
                con.Open();
                CustDA = new OleDbDataAdapter("SELECT * FROM customer", con);
                CustDA.Fill(CustDT);
                int Idnew =INDEX;
                if (CheckTextEmpty())
                {
                    if (CheckPremery("name_cust", txtNameCost) || (txtNameCost.Text == CustDT.Rows[Idnew]["name_cust"].ToString()))
                    {
                        if (CheckPremery("phon_cust", txtPhoneCost) ||(txtPhoneCost.Text == CustDT.Rows[Idnew]["phon_cust"].ToString()))
                        {                           
                            //----------------------------------------------------                           
                            CustDT.Rows[Idnew]["id_cust"] = txtIdCost.Text;
                            CustDT.Rows[Idnew]["name_cust"] = txtNameCost.Text;
                            CustDT.Rows[Idnew]["phon_cust"] = txtPhoneCost.Text;
                            CustDT.Rows[Idnew]["addres_cust"] = txtAdress.Text;
                            CustDT.Rows[Idnew]["date_cust"] = DPDCost.Value;
                            CustDT.Rows[Idnew]["time_cust"] = DPTCost.Value;
                            CustDT.Rows[Idnew]["balance_cust"] = txtbalanceCust.Text;
                            if (Male.Checked == true)
                            {
                                CustDT.Rows[Idnew]["gender_cust"] = Male.Text;
                            }
                            else
                                CustDT.Rows[Idnew]["gender_cust"] = Famle.Text;
                            if (Cash.Checked == true)
                            {
                                CustDT.Rows[Idnew]["type_cust"] = Cash.Text;
                            }
                            else
                                CustDT.Rows[Idnew]["type_cust"] = postpone.Text;

                            CustDT.Rows[Idnew]["note_cust"] = txtMo.Text;
                            CustDT.Rows[Idnew]["uesr_cust"] = txtUasrCost.Text;
                            //-----------------------------------------------------
                            OleDbCommandBuilder save = new OleDbCommandBuilder(CustDA);
                            CustDA.Update(CustDT);
                            CustDT.AcceptChanges();
                            new MessagBoxH(0, "تم التعديل بنجاح").ShowDialog();
                            this.Close();                            
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

        private void DPDCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DPTCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
