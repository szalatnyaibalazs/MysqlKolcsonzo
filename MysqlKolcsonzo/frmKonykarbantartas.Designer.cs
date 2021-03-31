namespace MysqlKolcsonzo
{
    partial class frmKonykarbantartas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKonyvek = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSzerzo = new System.Windows.Forms.TextBox();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategoria = new System.Windows.Forms.ComboBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonyvek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKonyvek
            // 
            this.dgvKonyvek.AllowUserToAddRows = false;
            this.dgvKonyvek.AllowUserToDeleteRows = false;
            this.dgvKonyvek.AllowUserToResizeColumns = false;
            this.dgvKonyvek.AllowUserToResizeRows = false;
            this.dgvKonyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonyvek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.szerzo,
            this.cim,
            this.isbn,
            this.nev});
            this.dgvKonyvek.Location = new System.Drawing.Point(12, 12);
            this.dgvKonyvek.Name = "dgvKonyvek";
            this.dgvKonyvek.ReadOnly = true;
            this.dgvKonyvek.RowHeadersVisible = false;
            this.dgvKonyvek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonyvek.Size = new System.Drawing.Size(776, 271);
            this.dgvKonyvek.TabIndex = 0;
            this.dgvKonyvek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonyvek_CellClick);
            this.dgvKonyvek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonyvek_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            // 
            // szerzo
            // 
            this.szerzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.szerzo.DataPropertyName = "szerzo";
            this.szerzo.HeaderText = "Szerző";
            this.szerzo.Name = "szerzo";
            this.szerzo.ReadOnly = true;
            this.szerzo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.szerzo.Width = 64;
            // 
            // cim
            // 
            this.cim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cim.DataPropertyName = "cim";
            this.cim.HeaderText = "Könyv címe";
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            this.cim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isbn.Width = 57;
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nev.DataPropertyName = "nev";
            this.nev.HeaderText = "Kategória";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nev.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szerző";
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.Enabled = false;
            this.tbSzerzo.Location = new System.Drawing.Point(87, 312);
            this.tbSzerzo.Name = "tbSzerzo";
            this.tbSzerzo.Size = new System.Drawing.Size(375, 20);
            this.tbSzerzo.TabIndex = 2;
            // 
            // tbCim
            // 
            this.tbCim.Enabled = false;
            this.tbCim.Location = new System.Drawing.Point(87, 353);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(375, 20);
            this.tbCim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Könyv címe";
            // 
            // tbIsbn
            // 
            this.tbIsbn.Enabled = false;
            this.tbIsbn.Location = new System.Drawing.Point(87, 397);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(375, 20);
            this.tbIsbn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN";
            // 
            // cbKategoria
            // 
            this.cbKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoria.Enabled = false;
            this.cbKategoria.FormattingEnabled = true;
            this.cbKategoria.Location = new System.Drawing.Point(528, 304);
            this.cbKategoria.Name = "cbKategoria";
            this.cbKategoria.Size = new System.Drawing.Size(260, 21);
            this.cbKategoria.TabIndex = 7;
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.Location = new System.Drawing.Point(12, 438);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(162, 32);
            this.btnMentes.TabIndex = 8;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.Enabled = false;
            this.btnMegsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegsem.Location = new System.Drawing.Point(192, 438);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(162, 32);
            this.btnMegsem.TabIndex = 9;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // btnUj
            // 
            this.btnUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUj.Location = new System.Drawing.Point(626, 438);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(162, 32);
            this.btnUj.TabIndex = 10;
            this.btnUj.Text = "Új könyv";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // frmKonykarbantartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.cbKategoria);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSzerzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKonyvek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKonykarbantartas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyv karbantartás";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonyvek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKonyvek;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSzerzo;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategoria;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Button btnUj;
    }
}