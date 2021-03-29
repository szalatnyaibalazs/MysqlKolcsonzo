using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MysqlKolcsonzo
{

    public partial class frmKereses : Form
    {
        DBdatabase adatbazis;
        public frmKereses(DBdatabase adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;

            lbEredmenyek.Items.Clear();
            tbCim.Focus();
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {

            lbEredmenyek.Items.Clear();
            string cim = tbCim.Text;
            if (cim != "")
            {
                try
                {
                    adatbazis.MySqlKapcsolat.Open();
                    string lekerdezes = "SELECT isbn, szerzo, cim, nev FROM konyvek as k " +
                    "inner join kategoriak as ka on ka.id = k.kategoria_id " +
                    "where cim like '%" + cim + "%';";
                    MySqlDataReader sorok;
                    MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MySqlKapcsolat);
                    sorok = parancs.ExecuteReader();
                    if (sorok.HasRows)
                    {
                        while (sorok.Read())
                        {
                            string isbn = sorok["isbn"].ToString();
                            string szerzo = sorok["szerzo"].ToString();
                            string konyvcim = sorok["cim"].ToString();
                            string kategoria = sorok["nev"].ToString();

                            lbEredmenyek.Items.Add($"{isbn}, {szerzo}, {konyvcim}, Kategória: {kategoria},");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A lekérdezésnek nincs eredménye", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tbCim.Focus();
                    tbCim.SelectAll();
                    adatbazis.MySqlKapcsolat.Close();
                    }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
