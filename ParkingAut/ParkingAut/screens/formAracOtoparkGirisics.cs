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
    }
}
