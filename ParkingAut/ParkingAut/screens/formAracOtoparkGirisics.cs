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
    public partial class formAracOtoparkGirisics : Form
    {
        public formAracOtoparkGirisics()
        {
            InitializeComponent();
        }
        CarParkDBContext db = new CarParkDBContext();

        private void formAracOtoparkGirisics_Load(object sender, EventArgs e)
        {
            var markagetir = db.TableBrands.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";


            var parkyerigetir = db.TableCarParkingSpaces.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = parkyerigetir;
            comboParkYeri.DisplayMember = "ParkYerleri";
            comboParkYeri.ValueMember = "ID";
        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TableSerialNum.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
                comboSeri.DataSource = serigetir;
                comboSeri.DisplayMember = "Seri";
                comboSeri.ValueMember = "ID";
            }
            catch (Exception)
            {

                
            }
        }

        private void comboMarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var serigetir = db.TableSerialNum.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
            comboSeri.DataSource = serigetir;
            comboSeri.DisplayMember = "Seri";
            comboSeri.ValueMember = "ID";
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var MusteriGetir = db.TableCustomer.Where(x => x.ID.ToString() == txtMusteriID.Text).ToList();
                foreach (var item in MusteriGetir)
                {
                    txtAdiSoyadi.Text = item.AdiSoyadi;
                    txtTelefon.Text = item.Telefon;
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
