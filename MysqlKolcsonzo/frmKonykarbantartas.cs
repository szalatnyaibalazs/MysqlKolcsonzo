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
    public partial class frmKonykarbantartas : Form
    {
        DBdatabase adatbazis;
        List<Kategoria> kategoriak = new List<Kategoria>();
        bool ujkonyv = false;
        public frmKonykarbantartas(DBdatabase adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;

            KonyvekFeltoltese();

            KategoriaFeltoltes();
            cbKategoria.ValueMember = "Id";
            cbKategoria.DisplayMember = "Nev";
            cbKategoria.DataSource = kategoriak;
        }
        public void KategoriaFeltoltes()
        {
            try
            {
                string lekerdezes = "select id,nev from kategoriak";

                adatbazis.MySqlKapcsolat.Open();

                MySqlDataReader sorok;
                MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MySqlKapcsolat);
                sorok = parancs.ExecuteReader();
                ;

                if (sorok.HasRows)
                {
                    while (sorok.Read())
                    {
                        int id = sorok.GetInt32(0);
                        string nev = sorok.GetString(1);


                        var kategoria = new Kategoria
                        {
                            Id = id,
                            Nev = nev
                        };

                        kategoriak.Add(kategoria);
                    }
                }

                adatbazis.MySqlKapcsolat.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void KonyvekFeltoltese()
        {
            try
            {
                string lekerdezes = "SELECT k.id as id,szerzo,cim,ISBN,nev "+
                    "FROM konyvek as k "+
                    "inner JOIN kategoriak as ka on ka.id = k.kategoria_id";
                adatbazis.MySqlKapcsolat.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(lekerdezes, adatbazis.MySqlKapcsolat);
                DataTable konyvekTabla = new DataTable();
                da.Fill(konyvekTabla);

                dgvKonyvek.DataSource = konyvekTabla;
                dgvKonyvek.Rows[0].Selected = true;
                AdatokatBeir(0);

                adatbazis.MySqlKapcsolat.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKonyvek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kivalasztottSor = dgvKonyvek.CurrentCell.RowIndex;
            AdatokatBeir(kivalasztottSor);
        }
        private void AdatokatBeir(int sor)
        {
            tbSzerzo.Text = dgvKonyvek.Rows[sor].Cells[1].Value.ToString();
            tbCim.Text = dgvKonyvek.Rows[sor].Cells[2].Value.ToString();
            tbIsbn.Text = dgvKonyvek.Rows[sor].Cells[3].Value.ToString();
            cbKategoria.SelectedIndex = cbKategoria.FindString(dgvKonyvek.Rows[sor].Cells[4].Value.ToString());
        }

        private void dgvKonyvek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Engedelyez();
        }
        private void Engedelyez()
        {
            tbCim.Enabled = true;
            tbSzerzo.Enabled = true;
            tbIsbn.Enabled = true;
            btnMegsem.Enabled = true;
            btnMentes.Enabled = true;
            cbKategoria.Enabled = true;
            btnUj.Enabled = false;
            dgvKonyvek.Enabled = false;
        }
        private void NemEngedelyez()
        {
            tbCim.Enabled = false;
            tbSzerzo.Enabled = false;
            tbIsbn.Enabled = false;
            btnMegsem.Enabled = false;
            btnMentes.Enabled = false;
            cbKategoria.Enabled = false;
            btnUj.Enabled = true;
            dgvKonyvek.Enabled = true;
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            NemEngedelyez();
            ujkonyv = false;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            string cim = tbCim.Text;
            string szerzo = tbSzerzo.Text;
            string isbn = tbIsbn.Text;
            string kategoria = cbKategoria.SelectedValue.ToString();

            if (!ujkonyv)
            {
                int kivalasztottSor = dgvKonyvek.CurrentCell.RowIndex;
                string id = dgvKonyvek.Rows[kivalasztottSor].Cells[0].Value.ToString();

                if (cim != "" && szerzo != "" && isbn != "")
                {
                    try
                    {
                        string lekerdez = $"update konyvek set cim='{cim}', szerzo='{szerzo}', isbn='{isbn}', kategoria_id={kategoria}  where id = {id};";

                        adatbazis.MySqlKapcsolat.Open();
                        MySqlCommand cmd = new MySqlCommand(lekerdez, adatbazis.MySqlKapcsolat);
                        cmd.ExecuteNonQuery();

                        adatbazis.MySqlKapcsolat.Close();

                        KonyvekFeltoltese();
                        AdatokatBeir(0);

                        NemEngedelyez();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adat nem lehet üres", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                try
                {
                    string lekerdez = $"insert into konyvek (cim,szerzo,isbn,kategoria_id) values ('{cim}', '{szerzo}','{isbn}', {kategoria});";

                    adatbazis.MySqlKapcsolat.Open();
                    MySqlCommand cmd = new MySqlCommand(lekerdez, adatbazis.MySqlKapcsolat);
                    cmd.ExecuteNonQuery();

                    adatbazis.MySqlKapcsolat.Close();

                    KonyvekFeltoltese();
                    AdatokatBeir(0);

                    NemEngedelyez();

                    ujkonyv = false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Number + " " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            Engedelyez();
            tbCim.Text = "";
            tbSzerzo.Text = "";
            tbIsbn.Text = "";
            ujkonyv = true;
        }
    }
}
