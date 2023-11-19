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
    public partial class haved_toolreport : UserControl
    {
        public Image ItemImage
        {
            get { return imgIcon.Image; }
            set { imgIcon.Image = value; }
        }

        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        public string ItemTime
        {
            get { return lblItemTime.Text; }
            set { lblItemTime.Text = value; }
        }

        public string ItemSize
        {
            get { return lblItemSize.Text; }
            set { lblItemSize.Text = value; }
        }

        public haved_toolreport()
        {
            InitializeComponent();
        }
   

        private void lblItemTime_Click(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click_1(object sender, EventArgs e)
        {

        }
    }
}
