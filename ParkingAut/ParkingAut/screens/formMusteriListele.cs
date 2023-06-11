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
    public partial class formMusteriListele : Form
    {
        public formMusteriListele()
        {
            InitializeComponent();
        }
        CarParkDBContext db = new CarParkDBContext();
        private void formMusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TableCustomer.ToList();
        }

        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            pictureBox1.ImageLocation = "";
            dateTimeTarih.Value = DateTime.Now;
        }




        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.TableCustomer
                      where x.ID.ToString() == txtID.Text
                      select x;
            foreach (var item in ara)
            {
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                txtAdres.Text = item.Adres;
                txtEmail.Text = item.Email;
                pictureBox1.ImageLocation = item.Resim;
                dateTimeTarih.Value = item.Tarih;
            }
            if (txtID.Text=="")
            {
                Temizle();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ekle = new customer();
            ekle.AdiSoyadi = txtAdiSoyadi.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.Adres = txtAdres.Text;
            ekle.Email = txtEmail.Text;
            ekle.Resim = pictureBox1.ImageLocation;
            ekle.Tarih = dateTimeTarih.Value;
            db.TableCustomer.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TableCustomer.ToList();
        }
    }
}
