using ParkingAut.classes;
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

        CarParkDBContext db = new CarParkDBContext();


        private void formMarka_Load(object sender, EventArgs e)
        {
            var markaListesi = db.TableBrands.ToList();
            for (int i = 0; i < markaListesi.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markaListesi[i].ID.ToString());
                ekle.SubItems.Add(markaListesi[i].MarkaAdi);
                listView1.Items.Add(ekle);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

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

 


    }
}
