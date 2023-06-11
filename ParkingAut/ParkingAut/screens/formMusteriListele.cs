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
    }
}
