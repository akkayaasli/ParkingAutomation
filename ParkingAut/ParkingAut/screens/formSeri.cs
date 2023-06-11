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
    }
}
