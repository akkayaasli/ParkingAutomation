using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAut.screens
{
    public partial class formMarka : Form
    {
        public formMarka()
        {
            InitializeComponent();
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count>0)
            {
                txtID.Text = secilen.SubItems[0].Text;
                txtMarkaAdi.Text = secilen.SubItems[1].Text;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
