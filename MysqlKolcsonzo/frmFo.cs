using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlKolcsonzo
{
    public partial class frmFo : Form
    {
        DBdatabase adatbazis;
        public frmFo(DBdatabase adatbazis,User felhasznalo)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;

            this.Text = "Főmenü - " + felhasznalo.TeljesNev;

            if (felhasznalo.Jogkor == "admin")
            {
                btnKolcsonzes.Enabled = true;
                btnVisszavetel.Enabled = true;
            }
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            frmKereses formKereses = new frmKereses(adatbazis);
            formKereses.ShowDialog();
        }

        private void frmFo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKonyvek_Click(object sender, EventArgs e)
        {
            frmKonyvek formKonyv = new frmKonyvek(adatbazis);
            formKonyv.ShowDialog();
        }

        private void btnKolcsonzes_Click(object sender, EventArgs e)
        {
            frmKolcsonzes formKolcsonzes = new frmKolcsonzes(adatbazis);
            formKolcsonzes.ShowDialog();
        }
    }
}
