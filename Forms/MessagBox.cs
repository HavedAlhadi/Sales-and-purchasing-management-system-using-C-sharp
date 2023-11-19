using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSoft
{
    public partial class MessagBoxH : Form
    {
        int res=0;
        public MessagBoxH()
        {
            InitializeComponent();
            panelErorr.Visible = false;
            panelMesAdd.Visible = true;
            panelMesCloseP.Visible = false;
            Yes.Click += Yes_Click;
        }
        public MessagBoxH(int x)
        {
            InitializeComponent();
            if(x==0)
            { 
            panelMesAdd.Visible = true;
            panelMesCloseP.Visible = false;
                panelErorr.Visible = false;
            }
            else if(x==1)
            {
                panelMesAdd.Visible = true;
                panelMesCloseP.Visible = false;
                panelErorr.Visible = false;
            }
            else
            {
                panelMesAdd.Visible = false;
                panelMesCloseP.Visible = false;
                panelErorr.Visible = true;
            }
        }
        public MessagBoxH(int x,string textM)
        {
            InitializeComponent();
            if (x == 0)
            {
                panelMesAdd.Visible = true;
                panelMesCloseP.Visible = false;
                panelErorr.Visible = false;
                MesText.Text = textM;
            }
            else if (x == 1)
            {
                panelMesAdd.Visible = false;
                panelMesCloseP.Visible = true;
                panelErorr.Visible = false;
                labelCloseP.Text = textM;
            }
            else if(x == 2)
            {
                panelMesAdd.Visible = false;
                panelMesCloseP.Visible = false;
                panelErorr.Visible = true;
                label2.Text = textM;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool result()
        {
            if(res==1)
            return true;
            else
            return false;
        }
        
        private void No_Click(object sender, EventArgs e)
        {
            res = 0;
            this.Close();            
        }

        private void MesClose_Click(object sender, EventArgs e)
        {           
            this.Close();            
        }

        private void alhadiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            res = 1;
            this.Close();
        }

        private void panelErorr_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
