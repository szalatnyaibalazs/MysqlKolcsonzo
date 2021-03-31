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
    public partial class frmBelepes : Form
    {
        DBdatabase adatbazis;
        User felhasznalo;
        public frmBelepes()
        {
            InitializeComponent();
            tbFelhasznalo.Focus();
            adatbazis = new DBdatabase("localhost", "videoteka", "root");
        }

        private void btnBelepes_Click(object sender, EventArgs e)
        {
            string nev = tbFelhasznalo.Text;
            string jelszo = tbJelszo.Text;

            if (nev != "" && jelszo != "")
            {
                try
                {
                    adatbazis.MySqlKapcsolat.Open();
                    string lekerdezes = "SELECT nev, jelszo, jogosultsag, teljesNev FROM felhasznalok " +
"WHERE nev = '" + nev + "' and jelszo = '" + jelszo + "';";
                    MySqlDataReader sorok;
                    MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MySqlKapcsolat);
                    sorok = parancs.ExecuteReader();
                    if (sorok.HasRows)
                    {
                        while (sorok.Read())
                        {
                            string felhasznalonev = sorok["nev"].ToString();
                            string felhasznaloJelszo = sorok["jelszo"].ToString();
                            string jogosultsag = sorok["jogosultsag"].ToString();
                            string teljesNev = sorok["teljesNev"].ToString();

                            felhasznalo = new User(felhasznalonev, felhasznaloJelszo, jogosultsag, teljesNev);
                        }
                        //MessageBox.Show("Köszöntelek: "+felhasznalo.TeljesNev);
                        this.Hide();
                        adatbazis.MySqlKapcsolat.Close();
                        frmFo formFo = new frmFo(adatbazis,felhasznalo);
                        formFo.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Felhasználónév vagy jelszó nem jó", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        adatbazis.MySqlKapcsolat.Close();
                    }
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adatbazis.MySqlKapcsolat.Close();
                }
            }
            else
            {
                MessageBox.Show("Felhasználónév vagy jelszó nem lehet üres", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
