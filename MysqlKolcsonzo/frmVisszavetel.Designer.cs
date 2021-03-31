namespace MysqlKolcsonzo
{
    partial class frmVisszavetel
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
            this.dgvKolcsonzott = new System.Windows.Forms.DataGridView();
            this.btnVisszavesz = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lejarat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzott)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKolcsonzott
            // 
            this.dgvKolcsonzott.AllowUserToAddRows = false;
            this.dgvKolcsonzott.AllowUserToDeleteRows = false;
            this.dgvKolcsonzott.AllowUserToResizeColumns = false;
            this.dgvKolcsonzott.AllowUserToResizeRows = false;
            this.dgvKolcsonzott.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKolcsonzott.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nev,
            this.cim,
            this.szerzo,
            this.isbn,
            this.lejarat});
            this.dgvKolcsonzott.Location = new System.Drawing.Point(12, 12);
            this.dgvKolcsonzott.MultiSelect = false;
            this.dgvKolcsonzott.Name = "dgvKolcsonzott";
            this.dgvKolcsonzott.ReadOnly = true;
            this.dgvKolcsonzott.RowHeadersVisible = false;
            this.dgvKolcsonzott.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKolcsonzott.Size = new System.Drawing.Size(797, 274);
            this.dgvKolcsonzott.TabIndex = 0;
            // 
            // btnVisszavesz
            // 
            this.btnVisszavesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVisszavesz.Location = new System.Drawing.Point(12, 344);
            this.btnVisszavesz.Name = "btnVisszavesz";
            this.btnVisszavesz.Size = new System.Drawing.Size(136, 36);
            this.btnVisszavesz.TabIndex = 1;
            this.btnVisszavesz.Text = "Visszavesz";
            this.btnVisszavesz.UseVisualStyleBackColor = true;
            this.btnVisszavesz.Click += new System.EventHandler(this.btnVisszavesz_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nev.DataPropertyName = "nev";
            this.nev.HeaderText = "Koöcsönző";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nev.Width = 85;
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
            // lejarat
            // 
            this.lejarat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lejarat.DataPropertyName = "lejarat";
            this.lejarat.HeaderText = "Lejárat dátuma";
            this.lejarat.Name = "lejarat";
            this.lejarat.ReadOnly = true;
            this.lejarat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lejarat.Width = 102;
            // 
            // frmVisszavetel
            // 
            this.AcceptButton = this.btnVisszavesz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 402);
            this.Controls.Add(this.btnVisszavesz);
            this.Controls.Add(this.dgvKolcsonzott);
            this.Name = "frmVisszavetel";
            this.Text = "Visszavétel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzott)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKolcsonzott;
        private System.Windows.Forms.Button btnVisszavesz;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lejarat;
    }
}