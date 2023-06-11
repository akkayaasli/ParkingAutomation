using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAut
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            screens.formMarka marka = new screens.formMarka();
            marka.Show();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            screens.formMarka marka = new screens.formMarka();
            marka.Show();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            screens.formSeri seri = new screens.formSeri();
            seri.Show();
        }

        private void seriTool_Click(object sender, EventArgs e)
        {
            screens.formSeri seri = new screens.formSeri();
            seri.Show();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            screens.formMusteriListele seri = new screens.formMusteriListele();
            seri.Show();
        }
    }
}
