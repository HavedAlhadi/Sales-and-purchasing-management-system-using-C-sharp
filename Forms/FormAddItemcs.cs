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
    public partial class FormAddItemcs : Form
    {
        OleDbConnection con = ClassGenric.Conaction();
        DataTable ItemDT = new DataTable();        
        DataTable ItemDT1 = new DataTable();
        DataTable ItemDT2 = new DataTable();
        DataTable ItemDT3 = new DataTable();
        OleDbDataAdapter ItemDA;
        OleDbDataAdapter ItemDA1;
        int MaxId = 1;
        int INDEX = 0;
        //====================================

        public FormAddItemcs()
        {
            InitializeComponent();
            BtnIEdit.Visible = false;
            BtnSaveItem.Visible = true;
            txtNameItem.KeyPress += ClassGenric.AhadiText;
            txtNumPar.KeyPress += ClassGenric.AhadiTextNum;
            txtPriceItem.KeyPress += ClassGenric.AhadiTextNum;
            txt_earn.KeyPress += ClassGenric.AhadiTextNum;
            txtQItem.KeyPress += ClassGenric.AhadiTextNum;
            DPDItem.Value = DateTime.Now.Date;
            DPTItim.Value = DateTime.Now;
            getIdUser();
            FillCompoGroupItem();
            FillCompoUnitsItem();
        }

        public FormAddItemcs(int id, string IName, string NPI, string priceI, string nameG, string nameU, string earnI, string QuI, DateTime date, DateTime time, DateTime dateE, string userA, int i)
        {
            InitializeComponent();

            FillCompoGroupItem();
            FillCompoUnitsItem();
            BtnIEdit.Visible = true;
            BtnSaveItem.Visible = false;
            INDEX = i;
            txtIdItem.Text = id.ToString();
            txtNameItem.Text = IName;
            txtNumPar.Text = NPI;
            txtPriceItem.Text = priceI;
            cmbGroubeItem.Text = nameG;
            cmbUnitsItem.Text = nameU;
            txt_earn.Text = earnI;
            txtQItem.Text = QuI;
            DPDItem.Value = date;
            DPTItim.Value = time;
            DPDEItem.Value = dateE;           
        }

        //دالة ترجع أكبر  قيمة في حقل الأيدي
        private void getIdUser()
        {
            ItemDT.Clear();
            ItemDT1.Clear();
            //فحص هل يحتوي الجدول على قيم
            ItemDA1 = new OleDbDataAdapter("SELECT * FROM items", con);
            ItemDA1.Fill(ItemDT1);
            //   MAX(id_user) 
            ItemDA = new OleDbDataAdapter("SELECT MAX(iD_item) FROM items", con);
            ItemDA.Fill(ItemDT);
            if (ItemDT1.Rows.Count == 0)
            {
                MaxId = 1;
            }
            else
            {
                MaxId = Convert.ToInt32(ItemDT.Rows[0][0]);
                MaxId += 1;
            }
            txtIdItem.Text = (MaxId).ToString();
        }
        //دالة فحص الحقول الفارغة
        private bool CheckTextEmpty()
        {
            if (txtNameItem.Text.Trim() != "" && txtPriceItem.Text.Trim() != ""&& txtQItem.Text.Trim()!="")
            {
                if (cmbGroubeItem.SelectedIndex!= -1 && cmbUnitsItem.SelectedIndex != -1)
                {
                 //   BtnSaveItem.Enabled = true;
                    return true;
                }
            }
            //BtnSaveItem.Enabled = false;
            return false;
        }

        //دالة ملاء كمبو بوكس المجموعات
        private void FillCompoGroupItem()
        {
            ItemDT3.Clear();
            ItemDA = new OleDbDataAdapter("SELECT * FROM group_items", con);
            ItemDA.Fill(ItemDT3);
            cmbGroubeItem.DataSource = ItemDT3;
            cmbGroubeItem.DisplayMember = "name_group";
            cmbGroubeItem.ValueMember = "id_group";

        }
        private void FillCompoUnitsItem()
        {
            ItemDT2.Clear();
            ItemDA= new OleDbDataAdapter("SELECT * FROM unit_items", con);
            ItemDA.Fill(ItemDT2);
            cmbUnitsItem.DataSource = ItemDT2;
            cmbUnitsItem.DisplayMember = "name_unit";
            cmbUnitsItem.ValueMember = "id_unit";
        }

        //دالة لفحص هل القيمة موجودة سابقا أم لا
        private bool CheckPremery(string s1, TextBox t)
        {
            ItemDT1.Clear();
            ItemDA1 = new OleDbDataAdapter("SELECT ('"+s1+"') FROM items where'" + s1 + "'='" + t.Text + "'", con);
            ItemDA1.Fill(ItemDT1);
            if (ItemDT1.Rows.Count > 0)
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

        //زر فتح سجل الأصناف
        FormMangItems FMI;
        private void Btn_RegisterUser_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Controls[0].Controls.Count > 0)
            {
                foreach (Control fd in Application.OpenForms[1].Controls[0].Controls)
                {
                    if (fd is FormMangItems)
                    {                       
                        fd.BringToFront();
                        fd.Show();
                        this.Close();
                        return;
                    }
                }
                FMI = new FormMangItems();
                FMI.Dock = DockStyle.Fill;
                FMI.TopLevel = false;
                Application.OpenForms[1].Controls[0].Controls.Add(FMI);
                FMI.BringToFront();
                FMI.Show();
            }
            else
            {
                FMI = new FormMangItems();
                FMI.TopLevel = false;
                FMI.Dock = DockStyle.Fill;
                Application.OpenForms[1].Controls[0].Controls.Add(FMI);
                FMI.BringToFront();
                FMI.Show();
            }
            this.Close();

        }

        //زر إضافة الصنف
        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            ItemDT.Clear();
            //الطريقة المنفصلة
            try
            {
               
                if (CheckTextEmpty())
                {
                    if (CheckPremery("name_item", txtNameItem))
                    {
                        if (CheckPremery("numpar_item", txtNumPar))
                        {
                            con.Open();
                            ItemDA = new OleDbDataAdapter("SELECT * FROM items", con);
                            ItemDA.Fill(ItemDT);
                            ItemDT.Rows.Add();
                            int Idnew = ItemDT.Rows.Count - 1;
                            //----------------------------------------------------                           
                            ItemDT.Rows[Idnew]["ID_item"] = txtIdItem.Text;
                            ItemDT.Rows[Idnew]["name_item"] = txtNameItem.Text;
                            ItemDT.Rows[Idnew]["numpar_item"] = txtNumPar.Text;
                            ItemDT.Rows[Idnew]["price_item"] = txtPriceItem.Text;
                            ItemDT.Rows[Idnew]["nameGrop_item"] = cmbGroubeItem.Text;
                            ItemDT.Rows[Idnew]["name_unit_item"] = cmbUnitsItem.Text;
                            ItemDT.Rows[Idnew]["earn_item"] = txt_earn.Text;
                            ItemDT.Rows[Idnew]["quantity_item"] = txtQItem.Text;
                            ItemDT.Rows[Idnew]["date_item"] = DPDItem.Value;
                            ItemDT.Rows[Idnew]["time_item"] = DPTItim.Value;
                            ItemDT.Rows[Idnew]["dateEnd_item"] = DPDEItem.Value;
                            ItemDT.Rows[Idnew]["user_item"] = txt_UserAddItem.Text;
                            //-----------------------------------------------------
                            OleDbCommandBuilder save = new OleDbCommandBuilder(ItemDA);
                            ItemDA.Update(ItemDT);
                            ItemDT.AcceptChanges();
                            new MessagBoxH().ShowDialog();
                            ClearTextBox();
                        }
                    }
                    else
                    {
                        new MessagBoxH(2, "الصنف موجود").ShowDialog();
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
            txtIdItem.Text = (MaxId).ToString();            
            DPDItem.Value = DateTime.Now.Date;
            DPDEItem.Value = DateTime.Now.Date;
            DPTItim.Value = DateTime.Now;
            FillCompoGroupItem();
            FillCompoUnitsItem();
        }
        //زر تعديل الصنف
        private void BtnIEdit_Click(object sender, EventArgs e)
        {
            ItemDT.Clear();
            //الطريقة المنفصلة
            try
            {
                con.Open();
                ItemDA = new OleDbDataAdapter("SELECT * FROM items", con);
                ItemDA.Fill(ItemDT);
                int Idnew = INDEX;
                //----------------------------------------------------
                ItemDT.Rows[Idnew]["ID_item"] = txtIdItem.Text;
                ItemDT.Rows[Idnew]["name_item"] = txtNameItem.Text;
                ItemDT.Rows[Idnew]["numpar_item"] = txtNumPar.Text;
                ItemDT.Rows[Idnew]["price_item"] = txtPriceItem.Text;
                ItemDT.Rows[Idnew]["nameGrop_item"] = cmbGroubeItem.Text;
                ItemDT.Rows[Idnew]["name_unit_item"] = cmbUnitsItem.Text;
                ItemDT.Rows[Idnew]["earn_item"] = txt_earn.Text;
                ItemDT.Rows[Idnew]["quantity_item"] = txtQItem.Text;
                ItemDT.Rows[Idnew]["date_item"] = DPDItem.Value;
                ItemDT.Rows[Idnew]["time_item"] = DPTItim.Value;
                ItemDT.Rows[Idnew]["dateEnd_item"] = DPDEItem.Value;
                ItemDT.Rows[Idnew]["user_item"] = txt_UserAddItem.Text;
                //-----------------------------------------------------
                if (CheckTextEmpty())
                {
                    if (CheckPremery("name_item", txtNameItem))
                    {
                        if (CheckPremery("numpar_item", txtNumPar))
                        {
                            OleDbCommandBuilder save = new OleDbCommandBuilder(ItemDA);
                            ItemDA.Update(ItemDT);
                            ItemDT.AcceptChanges();
                            new MessagBoxH(0,"تم التعديل بنجاح").ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        new MessagBoxH(2, "الصنف موجود").ShowDialog();
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
