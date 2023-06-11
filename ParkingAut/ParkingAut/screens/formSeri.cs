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
    public partial class formSeri : Form
    {
        public formSeri()
        {
            InitializeComponent();
        }



        CarParkDBContext db = new CarParkDBContext();
        private void formSeri_Load(object sender, EventArgs e)
        {
            Listele();
            var comboListe = db.TableBrands.ToList();
            comboMarka.DataSource = comboListe;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";
        }

        private void Listele()
        {
            listView1.Items.Clear();
            var liste = from x in db.TableSerialNum
                        join y in db.TableBrands on
                        x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkaAdi,
                            x.seri
                        };
            foreach (var item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdi);
                viewItem.SubItems.Add(item.seri);
                listView1.Items.Add(viewItem);
            }
        }
        void Temizle()
        {
            txtID.Text = "";
            txtSeri.Text = "";
            comboMarka.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int markaid = (int)comboMarka.SelectedValue;
            var ekle = new serialNum();
            ekle.MarkaID = markaid;
            ekle.seri = txtSeri.Text;
            db.TableSerialNum.Add(ekle);
            db.SaveChanges();
            Temizle();
            Listele();
            MessageBox.Show("Araca yeni seri eklendi.","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);     

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenID = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.TableSerialNum.FirstOrDefault(x => x.ID == secilenID);
            db.TableSerialNum.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç serisi silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TableSerialNum.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaID = (int)comboMarka.SelectedValue;
            guncelle.seri = txtSeri.Text;
            db.SaveChanges();
            MessageBox.Show("Araç serisi güncellendi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void formSeri_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];//hangisi seçildi
            if (listView1.SelectedItems.Count > 0)//seçilen birden fazla mı?
            {
                txtID.Text = secilen.SubItems[0].Text;
                comboMarka.Text = secilen.SubItems[1].Text;
                txtSeri.Text = secilen.SubItems[2].Text;
            }
        }
    }
}
