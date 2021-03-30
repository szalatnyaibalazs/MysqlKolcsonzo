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
    public partial class frmKolcsonzes : Form
    {
        DBdatabase adatbazis;
        List<Konyv> konyvek = new List<Konyv>();
        List<Szemely> szemelyek = new List<Szemely>();
        public frmKolcsonzes(DBdatabase adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            dtpLejarat.MinDate = DateTime.Now;

            KonyvekFeltoltese();
            cbKonyv.DisplayMember = "KonyvAdat";
            cbKonyv.ValueMember = "Id";
            cbKonyv.DataSource = konyvek;
            cbKonyv.SelectedIndex = 0;

            SzemelyekFeltoltese();
            cbTag.DisplayMember = "SzemelyAdat";
            cbTag.ValueMember = "Id";
            cbTag.DataSource = szemelyek;
            cbTag.SelectedIndex = 0;
            
        }

        private void btnKolcsonoz_Click(object sender, EventArgs e)
        {
            string konyvId = cbKonyv.SelectedValue.ToString();
            string tagId = cbTag.SelectedValue.ToString();
            string lejarat = dtpLejarat.Value.ToString("yyyy-MM-dd");

            if (NemKolcsonozheto(konyvId))
            {
                MessageBox.Show("Sajnos ez a könyv nem kölcsönözhető","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string lekerdez = "insert into kolcsonzesek (konyv_id, tag_id, lejarat, ervenyes)  values ("+konyvId+", "+tagId+", '"+lejarat+"', 1);";
                try
                {
                    adatbazis.MySqlKapcsolat.Open();
                    MySqlCommand cmd = new MySqlCommand(lekerdez,adatbazis.MySqlKapcsolat);
                    cmd.ExecuteNonQuery();
                    
                    
                    adatbazis.MySqlKapcsolat.Close();

                MessageBox.Show("Sikeres kölcsönzés ", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Number + " " + ex.Message, "Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
        private void KonyvekFeltoltese()
        {
            try
            {
                string select = "select id,szerzo,cim,ISBN from konyvek";
                adatbazis.MySqlKapcsolat.Open();

                MySqlDataReader sorok;
                MySqlCommand parancs = new MySqlCommand(select, adatbazis.MySqlKapcsolat);
                sorok = parancs.ExecuteReader();
;

                if (sorok.HasRows)
                {
                    while (sorok.Read())
                    {
                        int id = sorok.GetInt32(0);
                        string szerzo = sorok.GetString(1);
                        string cim = sorok.GetString(2);
                        string isbn = sorok.GetString(3);

                        var konyv = new Konyv
                        {
                            Id = id,
                            Isbn = isbn,
                            Szerzo = szerzo,
                            Cim = cim
                        };

                        konyvek.Add(konyv);
                    }
                }

                adatbazis.MySqlKapcsolat.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number +" "+ex.Message,"Hiba");
            }
        }

        private void SzemelyekFeltoltese()
        {
            try
            {
                string select = "select id,nev,levelezesi_cim from tagok";
                adatbazis.MySqlKapcsolat.Open();

                MySqlDataReader sorok;
                MySqlCommand parancs = new MySqlCommand(select, adatbazis.MySqlKapcsolat);
                sorok = parancs.ExecuteReader();
                ;

                if (sorok.HasRows)
                {
                    while (sorok.Read())
                    {
                        int id = sorok.GetInt32(0);
                        string nev = sorok.GetString(1);
                        string levelezesicim = sorok.GetString(2);
                        

                        var szemely = new Szemely
                        {
                            Id = id,
                            Nev = nev,
                            Levelezesicim = levelezesicim
                        };

                        szemelyek.Add(szemely);
                    }
                }

                adatbazis.MySqlKapcsolat.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number + " " + ex.Message, "Hiba");
            }
        }
        private bool NemKolcsonozheto(string id)
        {
            bool vissza;
            string lekerdezes = "select * from kolcsonzesek where konyv_id = "+id+ " and ervenyes = 1;";
            try
            {
                adatbazis.MySqlKapcsolat.Open();
                MySqlDataReader sorok;
                MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MySqlKapcsolat);
                sorok = parancs.ExecuteReader();
                vissza = sorok.HasRows;
                adatbazis.MySqlKapcsolat.Close();
                return vissza;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number + " " + ex.Message, "Hiba");
                return false;
            }
        }
    }
}
