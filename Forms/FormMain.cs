using System;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
namespace SuperSoft
{
    public partial class SuperM : Form
    {        
        int MnueShow=0;
        private Button currentB;
        private Button currenta;
        private Panel RiteBorderBtn;
        OleDbConnection con = ClassGenric.Conaction();
        DataTable CustDT;
        OleDbDataAdapter dta;
        public SuperM()
        {
            InitializeComponent();
            panelMnIc.Size = new Size(185, 61);
            panelMenu.Width = 185;
            RiteBorderBtn = new Panel();
            RiteBorderBtn.Size = new Size(5, 38);
            RiteBorderBtn.BackColor =Color.FromArgb(72, 143, 192);
            panelMenu.Controls.Add(RiteBorderBtn);
            panelMnIc.Size = new Size(183, 61);
            panelMenu.Width = 183;
            myDesine();
            btnMenuMain_Click(null, null);
            this.WindowState = FormWindowState.Maximized;
        }

       private void ActivBtn(object senderBtn)
        {
            if(senderBtn!=null)
            {
                DisplayBtn();
                currentB = (Button)senderBtn;
                currentB.TextImageRelation = TextImageRelation.ImageBeforeText;
                RiteBorderBtn.Location = new Point(180, currentB.Location.Y);
                RiteBorderBtn.Visible = true;                
                RiteBorderBtn.BringToFront();
            }
        }
        private void DisplayBtn()
        {
            if (currentB != null)
            {                
                //currentB.TextAlign = ContentAlignment.MiddleCenter;
                currentB.TextImageRelation = TextImageRelation.Overlay;
                currentB.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void ActbtnHeader(object senderBtn)
        {
            if (senderBtn != null)
            {
                currenta = (Button)senderBtn;
                btnTilrBar.Visible = true;
                btnTilrBar.Text = currenta.Text;
                btnTilrBar.TextAlign = ContentAlignment.MiddleCenter;
                btnTilrBar.Image = currenta.Image;
                btnTilrBar.ImageAlign = ContentAlignment.MiddleRight;
            }
            btnTilrBarPart2.Visible = false;
        }
        private void ActbtnPart2(object senderBtn)
        {
            if (senderBtn != null)
            {
                currenta = (Button)senderBtn;
                btnTilrBarPart2.Visible = true;
                btnTilrBarPart2.Text = currenta.Text+" <<";
                btnTilrBarPart2.TextAlign = ContentAlignment.MiddleRight;
            }
        }
        private void myDesine()
        {
           foreach(Control x in panelMenu.Controls)
            {
                if((x is Panel) && (x.Name != "panelIcon"))
                {
                    x.Visible = false;
                }
            }
       }
        private void porpoint()
        {
            if (MnueShow == 0)
            {
                panelMnIc.Size = new Size(60, 61);
                panelMenu.Width = 60;
                button2.Visible = false;
                
                foreach (Control x in panelMenu.Controls)
                {
                    
                    if ((x is Button))
                    {                        
                        x.Tag = x.Text;
                        x.Text = "";                                                
                    }
                }
                foreach (Control x in panelIcon.Controls)
                {

                    if ((x is Button))
                    {
                        x.Tag = x.Text;
                        x.Text = "";
                    }
                }
                MnueShow = 1;
            }
            else
            {                
                panelMnIc.Size = new Size(185, 61);
                panelMenu.Width = 185;                
                button2.Visible = true;

                foreach (Control x in panelMenu.Controls)
                {
                    if ((x is Button))
                    {
                        x.Text = x.Tag.ToString();
                        x.Tag = "";
                    }
                }
                foreach (Control x in panelIcon.Controls)
                {
                    if ((x is Button))
                    {
                        x.Text = x.Tag.ToString();
                        x.Tag = "";
                    }
                }
                MnueShow = 0;
            }
        }
        private void hiddenmanu()
        {            
            if (panelItem.Visible == true)
                panelItem.Visible = false;
            if (panelCust.Visible == true)
                panelCust.Visible = false;
            if (panelImpo.Visible == true)
                panelImpo.Visible = false;
            if (panelBuy.Visible == true)
                panelBuy.Visible = false;
            if (panelSale.Visible == true)
                panelSale.Visible = false;
            if (panelUsers.Visible == true)
                panelUsers.Visible = false;
            if (panelSeting.Visible == true)
                panelSeting.Visible = false;                    
             
           
        }
        private void ShowManu(Panel Nmanu, Panel Nmanu1)
        {
            if ((Nmanu.Visible == false) && (Nmanu1.Visible == false))
            {
                hiddenmanu();
                Nmanu.Visible = true;
                Nmanu1.Visible = true;
            }
            else
            { 
                Nmanu.Visible = false;
            Nmanu1.Visible = false;
            }
        }
        private void ShowManu(Panel Nmanu)
        {
            if ((Nmanu.Visible == false))
            {
                hiddenmanu();
                Nmanu.Visible = true;
                
            }
            else
            {
                Nmanu.Visible = false;                
            }
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseSuperMDataSet1.buypill' table. You can move, or remove it, as needed.
           //this.buypillTableAdapter.Fill(this.databaseSuperM.buypill);
            //Style Mian Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void butclear_Click(object sender, EventArgs e)
        {
            hiddenmanu();
        }

        private void textBoxnumberp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 47 && e.KeyChar > 58 && e.KeyChar != 8)
            {
                //e.KeyChar = "\n";
            }
        }

        private void panelf_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form act = null;
        private void OpenMinForm(Form mynewform)
        {
            if (act != null)
                act.Focus();            
                        act = mynewform;
                act.TopLevel = false;
                act.Dock = DockStyle.Fill;
                panelContiner.Controls.Add(act);
                act.BringToFront();
                act.Show();            
        }
        //-------------------------------------------
        private void btnItems_Click(object sender, EventArgs e)
        {
           
            hiddenmanu();
                ActivBtn(sender);
            ActbtnHeader(sender);
            if (MnueShow == 1)
            {
                porpoint();
            }
            ShowManu(panelItem);            
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            hiddenmanu();
            ActbtnHeader(sender);
            ActivBtn(sender);
            if (MnueShow == 1)
            {
                porpoint();
            }
            ShowManu(panelCust);
        }
        private void btnImpo_Click_2(object sender, EventArgs e)
        {
            hiddenmanu();
            ActivBtn(sender);
            ActbtnHeader(sender);
            if (MnueShow == 1)
            {
                porpoint();
            }
            ShowManu(panelImpo);            
        }

        private void btnSale_Click_1(object sender, EventArgs e)
        {
            hiddenmanu();
            ActbtnHeader(sender);
            ActivBtn(sender);
            if (MnueShow == 1)
            {
                porpoint();
            }
            ShowManu(panelSale);
        }
        FormAddItemcs FAIT = new FormAddItemcs();
        private void butAddItem_Click(object sender, EventArgs e)
        {
            butAddItem.Size = new Size(180, 45);
            ActbtnPart2(sender);
            FAIT.ShowDialog();
        }

        private void butAddItem_MouseHover(object sender, EventArgs e)
        {
            butAddItem.Size = new Size(180, 45);
        }

        private void butAddItem_MouseLeave(object sender, EventArgs e)
        {
            butAddItem.Size = new Size(190, 45);
        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcontenr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMneu_Click(object sender, EventArgs e)
        {
            porpoint();
            hiddenmanu();
            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            hiddenmanu();
            ActbtnHeader(sender);
            ActivBtn(sender);
            if (MnueShow == 1)
            {
                porpoint();
            }
            ShowManu(panelBuy);
        }
        Form_AddGroup FAG = new Form_AddGroup();
        private void butAddgroup_Click(object sender, EventArgs e)
        {
            butAddgroup.Size = new Size(180, 45);
            ActbtnPart2(sender);
            FAG.ShowDialog();
        }

        private void butAddgroup_MouseHover(object sender, EventArgs e)
        {
            butAddgroup.Size = new Size(180, 45);
        }

        private void butAddgroup_MouseLeave(object sender, EventArgs e)
        {
            butAddgroup.Size = new Size(190, 45);
        }
        FormAddUnit FAU = new FormAddUnit();
        private void butAddUnit_Click(object sender, EventArgs e)
        {
            butAddUnit.Size = new Size(180, 45);
            ActbtnPart2(sender);
            FAU.ShowDialog();
        }

        private void butAddUnit_MouseHover(object sender, EventArgs e)
        {
            butAddUnit.Size = new Size(180, 45);
        }

        private void butAddUnit_MouseLeave(object sender, EventArgs e)
        {
            butAddUnit.Size = new Size(190, 45);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }        
        private void btnMangItem_Click(object sender, EventArgs e)
        {
            btnMangItem.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormMangItems)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormMangItems());
            }
            else { OpenMinForm(new FormMangItems()); }
        }

        private void btnMangItem_MouseHover(object sender, EventArgs e)
        {
            btnMangItem.Size = new Size(180, 45);
        }

        private void btnMangItem_MouseLeave(object sender, EventArgs e)
        {
            btnMangItem.Size = new Size(190, 45);
        }        
        private void btnM_GU_Click(object sender, EventArgs e)
        {
            btnM_GU.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormMangGU)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }                    
                }
                OpenMinForm(new FormMangGU());
            }
            else { OpenMinForm(new FormMangGU()); }

        }

        private void btnM_GU_MouseHover(object sender, EventArgs e)
        {
            btnM_GU.Size = new Size(180, 45);
        }

        private void btnM_GU_MouseLeave(object sender, EventArgs e)
        {
            btnM_GU.Size = new Size(190, 45);
        }

        private void btnRepItem_Click(object sender, EventArgs e)
        {
            btnRepItem.Size = new Size(180, 45);
            ActbtnPart2(sender);
        }

        private void btnRepItem_MouseHover(object sender, EventArgs e)
        {
            btnRepItem.Size = new Size(180, 45);
        }

        private void btnRepItem_MouseLeave(object sender, EventArgs e)
        {
            btnRepItem.Size = new Size(190, 45);
        }
        FormAddCust FAC = new FormAddCust();
        private void btnAddcust_Click(object sender, EventArgs e)
        {
            btnAddcust.Size = new Size(180, 45);
            ActbtnPart2(sender);
            FAC.ShowDialog();
        }
        private void btnAddcust_MouseHover(object sender, EventArgs e)
        {
            btnAddcust.Size = new Size(180, 45);
        }

        private void btnAddcust_MouseLeave(object sender, EventArgs e)
        {
            btnAddcust.Size = new Size(190, 45);
        }
        private void btnMangCost_Click(object sender, EventArgs e)
        {
            btnMangCost.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormMangCust)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormMangCust());
            }
            else { OpenMinForm(new FormMangCust()); }            
        }

        private void btnMangCost_MouseHover(object sender, EventArgs e)
        {
            btnMangCost.Size = new Size(180, 45);
        }

        private void btnMangCost_MouseLeave(object sender, EventArgs e)
        {
            btnMangCost.Size = new Size(190, 45);
        }

        private void btnReCust_Click(object sender, EventArgs e)
        {
            btnReCust.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is ReportCust)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new ReportCust());
            }
            else { OpenMinForm(new ReportCust()); }
        }

        private void btnReCust_MouseLeave(object sender, EventArgs e)
        {
            btnReCust.Size = new Size(190, 45);
        }

        private void btnReCust_MouseHover(object sender, EventArgs e)
        {
            btnReCust.Size = new Size(180, 45);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            hiddenmanu();
            ActbtnHeader(sender);
            ActivBtn(sender);
            ShowManu(panelUsers);
        }

        private void btnSeting_Click(object sender, EventArgs e)
        {
            hiddenmanu();
            ActbtnHeader(sender);
            ActivBtn(sender);
            ShowManu(panelSeting);
        }
        FormAddImpo FAIM = new FormAddImpo(); 
        private void btnAddimpo_Click(object sender, EventArgs e)
        {
            btnAddimpo.Size = new Size(180, 45);
            ActbtnPart2(sender);
            FAIM.ShowDialog();
        }

        private void btnAddimpo_MouseHover(object sender, EventArgs e)
        {
            btnAddimpo.Size = new Size(180, 45);
        }

        private void btnAddimpo_MouseLeave(object sender, EventArgs e)
        {
            btnAddimpo.Size = new Size(190, 45);
        }

        private void btnmangimpo_Click(object sender, EventArgs e)
        {
            btnmangimpo.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormMangImpo)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormMangImpo());
            }
            else { OpenMinForm(new FormMangImpo()); }            
        }

        private void btnmangimpo_MouseHover(object sender, EventArgs e)
        {
            btnmangimpo.Size = new Size(180, 45);
        }

        private void btnmangimpo_MouseLeave(object sender, EventArgs e)
        {
            btnmangimpo.Size = new Size(190, 45);
        }

        private void btnReimpo_Click(object sender, EventArgs e)
        {
            btnReimpo.Size = new Size(180, 45);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is ReportImpo)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new ReportImpo());
            }
            else { OpenMinForm(new ReportImpo()); }
        }

        private void btnReimpo_MouseHover(object sender, EventArgs e)
        {
            btnReimpo.Size = new Size(180, 45);
        }

        private void btnReimpo_MouseLeave(object sender, EventArgs e)
        {
            btnReimpo.Size = new Size(190, 45);
        }

        private void btnFillsale_Click(object sender, EventArgs e)
        {
            btnFillsale.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormSalePill)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormSalePill());
            }
            else { OpenMinForm(new FormSalePill()); }
        }

        private void btnFillsale_MouseHover(object sender, EventArgs e)
        {
            btnFillsale.Size = new Size(180, 45);
        }

        private void btnFillsale_MouseLeave(object sender, EventArgs e)
        {
            btnFillsale.Size = new Size(190, 45);
        }

        private void btnReSale_Click(object sender, EventArgs e)
        {
            btnReSale.Size = new Size(180, 45);

        }

        private void btnReSale_MouseHover(object sender, EventArgs e)
        {
            btnReSale.Size = new Size(180, 45);
        }

        private void btnReSale_MouseLeave(object sender, EventArgs e)
        {
            btnReSale.Size = new Size(190, 45);
        }

        private void btnMangsale_Click(object sender, EventArgs e)
        {
            btnMangsale.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is ReportSale)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new ReportSale());
            }
            else { OpenMinForm(new ReportSale()); }
        }

        private void btnMangsale_MouseHover(object sender, EventArgs e)
        {
            btnMangsale.Size = new Size(180, 45);
        }

        private void btnMangsale_MouseLeave(object sender, EventArgs e)
        {
            btnMangsale.Size = new Size(190, 45);
        }
      
        private void btnBuyFill_Click(object sender, EventArgs e)
        {
            btnBuyFill.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormFillBuys)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormFillBuys());
            }
            else { OpenMinForm(new FormFillBuys()); }
        }

        private void btnItems_MouseLeave(object sender, EventArgs e)
        {
            btnBuyFill.Size = new Size(190, 45);
        }

       

        private void btnBuyFill_MouseHover(object sender, EventArgs e)
        {
            btnBuyFill.Size = new Size(180, 45);
        }

        private void btnBuyFill_MouseLeave(object sender, EventArgs e)
        {
            btnBuyFill.Size = new Size(190, 45);
        }

        private void btnReBuy_Click(object sender, EventArgs e)
        {
            btnReBuy.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormRBuycs)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormRBuycs());
            }
            else { OpenMinForm(new FormRBuycs()); }
        }

        private void btnReBuy_MouseHover(object sender, EventArgs e)
        {
            btnReBuy.Size = new Size(180, 45);
            
        }

        private void btnReBuy_MouseLeave(object sender, EventArgs e)
        {
            btnReBuy.Size = new Size(190, 45);
        }

        private void btnMangbuy_Click(object sender, EventArgs e)
        {
            btnMangbuy.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is ReportBuy)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new ReportBuy());
            }
            else { OpenMinForm(new ReportBuy()); }

        }

        private void btnMangbuy_MouseHover(object sender, EventArgs e)
        {
            btnMangbuy.Size = new Size(180, 45);
            
        }

        private void btnMangbuy_MouseLeave(object sender, EventArgs e)
        {
            btnMangbuy.Size = new Size(190, 45);
        }

        Form_AddUser Nee= new Form_AddUser();
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnAddUser.Size = new Size(180, 45);
            ActbtnPart2(sender);
            Nee.ShowDialog();
        }

        private void btnAddUser_MouseHover(object sender, EventArgs e)
        {
            btnAddUser.Size = new Size(180, 45);
        }

        private void btnAddUser_MouseLeave(object sender, EventArgs e)
        {
            btnAddUser.Size = new Size(190, 45);
        }
                
       public void btnMangUser_Click(object sender, EventArgs e)
        {
            btnMangUser.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is FormMangUser)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new FormMangUser());
            }
            else {OpenMinForm(new FormMangUser()); }
        }
        static public void OpenChildForm()
        {
            
        }
        private void btnMangUser_MouseHover(object sender, EventArgs e)
        {
            btnMangUser.Size = new Size(180, 45);
        }

        private void btnMangUser_MouseLeave(object sender, EventArgs e)
        {
            btnMangUser.Size = new Size(190, 45);
        }

        private void btnsalhUser_Click(object sender, EventArgs e)
        {
            btnsalhUser.Size = new Size(180, 45);
        }

        private void btnsalhUser_MouseHover(object sender, EventArgs e)
        {
            btnsalhUser.Size = new Size(180, 45);
        }

        private void btnsalhUser_MouseLeave(object sender, EventArgs e)
        {
            btnsalhUser.Size = new Size(190, 45);
        }

        private void btnReUser_Click(object sender, EventArgs e)
        {
            btnReUser.Size = new Size(180, 45);
        }

        private void btnReUser_MouseHover(object sender, EventArgs e)
        {
            btnReUser.Size = new Size(180, 45);
        }

        private void btnReUser_MouseLeave(object sender, EventArgs e)
        {
            btnReUser.Size = new Size(190, 45);
        }

        private void btnCpyePakUp_Click(object sender, EventArgs e)
        {
            btnCpyePakUp.Size = new Size(180, 45);
        }

        private void btnCpyePakUp_MouseLeave(object sender, EventArgs e)
        {
            btnCpyePakUp.Size = new Size(190, 45);
        }

        private void btnCpyePakUp_MouseMove(object sender, MouseEventArgs e)
        {
            btnCpyePakUp.Size = new Size(180, 45);
        }

        private void btnPasePakUp_Click(object sender, EventArgs e)
        {
            btnPasePakUp.Size = new Size(180, 45);
        }

        private void btnPasePakUp_MouseHover(object sender, EventArgs e)
        {
            btnPasePakUp.Size = new Size(180, 45);
        }

        private void btnPasePakUp_MouseLeave(object sender, EventArgs e)
        {
            btnPasePakUp.Size = new Size(190, 45);
        }
        
        private void btnِAboutProjct_Click(object sender, EventArgs e)
        {
            btnِAboutProjct.Size = new Size(180, 45);
            ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is About)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new About());
            }
            else { OpenMinForm(new About()); }
        }

        private void btnِAboutProjct_MouseHover(object sender, EventArgs e)
        {
            btnِAboutProjct.Size = new Size(180, 45);
        }

        private void btnِAboutProjct_MouseLeave(object sender, EventArgs e)
        {
            btnِAboutProjct.Size = new Size(190, 45);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaxmas.Visible = false;
                btnNormal.Visible = true;
                this.WindowState =FormWindowState.Maximized;
            }
            else
            {
                btnMaxmas.Visible = true;
                btnNormal.Visible = false;
                this.WindowState = FormWindowState.Normal;                
            }
                
        }
        //Move Form With My Border
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBorderStyleForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnMenuMain_Click(object sender, EventArgs e)
        {
          //  Application.OpenForms[0].Controls[0].BackColor = Color.Red;
            hiddenmanu();
            ActivBtn(sender);
            ActbtnHeader(sender);
            //CountData();          
            //panelReport.Visible = true;
            //ActbtnPart2(sender);
            if (this.panelContiner.Controls.Count > 0)
            {
                foreach (Control fd in this.panelContiner.Controls)
                {
                    if (fd is ReportSimple)
                    {
                        fd.BringToFront();
                        fd.Show();
                        return;
                    }
                }
                OpenMinForm(new ReportSimple());
            }
            else { OpenMinForm(new ReportSimple()); }
            if (MnueShow == 1)
            {
                porpoint();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {            
            this.WindowState = FormWindowState.Minimized;
        }
    }
 
}
