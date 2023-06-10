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
            MarkaListele();

        }

        private void MarkaListele()
        {
            listView1.Items.Clear();
            var markaListesi = db.TableBrands.ToList();
                for (int i = 0; i < markaListesi.Count; i++)
                {
                    ListViewItem ekle = new ListViewItem(markaListesi[i].ID.ToString());
                    ekle.SubItems.Add(markaListesi[i].MarkaAdi);
                    listView1.Items.Add(ekle);
                }
        }

        void Temizle()
        {
            txtID.Text = "";
            txtMarkaAdi.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var tbl = new brands();
            tbl.MarkaAdi = txtMarkaAdi.Text;
            db.TableBrands.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Araç markası eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenID = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.TableBrands.FirstOrDefault(x => x.ID == secilenID);
            db.TableBrands.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç markası silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TableBrands.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaAdi = txtMarkaAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Araç markası güncellendi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }
    }
}
