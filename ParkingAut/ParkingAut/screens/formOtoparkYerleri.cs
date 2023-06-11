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
    public partial class formOtoparkYerleri : Form
    {
        public formOtoparkYerleri()
        {
            InitializeComponent();
        }
        CarParkDBContext db = new CarParkDBContext();

        private void formOtoparkYerleri_Load(object sender, EventArgs e)
        {
            int x = 1, y = 1;
            foreach (Control item in panel1.Controls)
            {
                if (item is Label)
                {
                    item.Text = "A-" + x;
                    item.Name = "A-" + x;
                    x++;
                }
            }
            foreach (Control item in panel2.Controls)

            {
                if (item is Label)
                {
                    item.Text = "B-" + y;
                    item.Name = "B-" + y;
                    y++;
                }
            }
            var parkyerleri = from i in db.TableCarParkingSpaces
                              select new
                              {
                                  i.Durumu,
                                  i,
                                  i.ID,
                                  i.ParkYerleri
                              };
            foreach(var item in parkyerleri)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (item.Durumu == "BOŞ" && item.ParkYerleri==lbl.Text)
                    {
                        lbl.BackColor = Color.Green;

                    }
                    else if (item.Durumu == "DOLU" && item.ParkYerleri==lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }
            }

            foreach (var item in parkyerleri)
            {
                foreach (Control lbl in panel2.Controls)
                {
                    if (item.Durumu == "BOŞ" && item.ParkYerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Green;

                    }
                    else if (item.Durumu == "DOLU" && item.ParkYerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }
            }

        }
    }
}
