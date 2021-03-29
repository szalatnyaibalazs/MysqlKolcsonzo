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
    public partial class frmKonyvek : Form
    {
        DBdatabase adatbazis;
        public frmKonyvek(DBdatabase adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            lbEredmenyek.Items.Clear();
            tbTag.Focus();
        }

        private void btnLekerdez_Click(object sender, EventArgs e)
        {
            lbEredmenyek.Items.Clear();

            string tag = tbTag.Text;

            if (tag != "")
            {
                try
                {
                    adatbazis.MySqlKapcsolat.Open();

                    string lekerdezes = "select isbn,szerzo,cim,lejarat from kolcsonzesek as k "+ "inner join konyvek as ko on ko.id = k.konyv_id " +"inner join tagok as t on t.id=k.tag_id "+"WHERE k.ervenyes = 1 and t.nev ='"+tag+"';";
                    MySqlDataReader sorok;
                    MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MySqlKapcsolat);
                    sorok = parancs.ExecuteReader();
                    
                    int darab = 0;

                    if (sorok.HasRows)
                    {
                        while (sorok.Read())
                        {
                            string isbn = sorok["isbn"].ToString();
                            string szerzo = sorok["szerzo"].ToString();
                            string konyvcim = sorok["cim"].ToString();
                            string lejarat = sorok["lejarat"].ToString();
                            lbEredmenyek.Items.Add($"{isbn}, {szerzo}, {konyvcim}, lejárat: {lejarat}");
                            darab++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A lekérdezésnek nincs eredménye", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        lblDarab.Text = darab.ToString();
                    tbTag.Focus();
                    tbTag.SelectAll();
                    adatbazis.MySqlKapcsolat.Close();
                }
                catch (MySqlException ex )
                {
                    MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
