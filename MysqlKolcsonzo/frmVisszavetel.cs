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
    public partial class frmVisszavetel : Form
    {
        DBdatabase adatbazis;
        public frmVisszavetel(DBdatabase adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            KolcsonzesekFeltoltese();

        }

        private void btnVisszavesz_Click(object sender, EventArgs e)
        {
            try
            {
                int kivalasztottSor = dgvKolcsonzott.CurrentCell.RowIndex;
                string id = dgvKolcsonzott.Rows[kivalasztottSor].Cells[0].Value.ToString();
                string lekerdezes = "update kolcsonzesek set ervenyes = 0 where id = "+id+";";

                adatbazis.MySqlKapcsolat.Open();
                MySqlCommand cmd = new MySqlCommand(lekerdezes,adatbazis.MySqlKapcsolat);
                cmd.ExecuteNonQuery();
                adatbazis.MySqlKapcsolat.Close();
                KolcsonzesekFeltoltese();

                MessageBox.Show("Sikeres visszavételezés","Információ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KolcsonzesekFeltoltese()
        {
            try
            {
                string lekerdezes = "select k.id as id,t.nev as nev,k.cim as cim, k.szerzo as szerzo,"+
                    "k.ISBN as isbn,ko.lejarat as lejarat "+
                    "from kolcsonzesek as ko inner join konyvek as k on k.id = ko.konyv_id "+ "inner join tagok as t on t.id = ko.tag_id " +
                    "WHERE ko.ervenyes = 1 order by ko.lejarat";

                adatbazis.MySqlKapcsolat.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(lekerdezes,adatbazis.MySqlKapcsolat);
                DataTable kolcsonzesekTabla = new DataTable();
                da.Fill(kolcsonzesekTabla);

                dgvKolcsonzott.DataSource = kolcsonzesekTabla;
                dgvKolcsonzott.Rows[0].Selected = true;

                adatbazis.MySqlKapcsolat.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
