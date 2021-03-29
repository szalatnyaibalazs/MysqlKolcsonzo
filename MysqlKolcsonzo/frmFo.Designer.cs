namespace MysqlKolcsonzo
{
    partial class frmFo
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
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnKonyvek = new System.Windows.Forms.Button();
            this.btnKolcsonzes = new System.Windows.Forms.Button();
            this.btnVisszavetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(12, 40);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(177, 157);
            this.btnKereses.TabIndex = 0;
            this.btnKereses.Text = "Könyv keresése";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // btnKonyvek
            // 
            this.btnKonyvek.Location = new System.Drawing.Point(215, 40);
            this.btnKonyvek.Name = "btnKonyvek";
            this.btnKonyvek.Size = new System.Drawing.Size(177, 157);
            this.btnKonyvek.TabIndex = 1;
            this.btnKonyvek.Text = "Tag által köcslcsönzött könyvek listázása";
            this.btnKonyvek.UseVisualStyleBackColor = true;
            this.btnKonyvek.Click += new System.EventHandler(this.btnKonyvek_Click);
            // 
            // btnKolcsonzes
            // 
            this.btnKolcsonzes.Enabled = false;
            this.btnKolcsonzes.Location = new System.Drawing.Point(420, 40);
            this.btnKolcsonzes.Name = "btnKolcsonzes";
            this.btnKolcsonzes.Size = new System.Drawing.Size(177, 157);
            this.btnKolcsonzes.TabIndex = 2;
            this.btnKolcsonzes.Text = "Kölcsönzés";
            this.btnKolcsonzes.UseVisualStyleBackColor = true;
            // 
            // btnVisszavetel
            // 
            this.btnVisszavetel.Enabled = false;
            this.btnVisszavetel.Location = new System.Drawing.Point(629, 40);
            this.btnVisszavetel.Name = "btnVisszavetel";
            this.btnVisszavetel.Size = new System.Drawing.Size(177, 157);
            this.btnVisszavetel.TabIndex = 3;
            this.btnVisszavetel.Text = "Visszavétel";
            this.btnVisszavetel.UseVisualStyleBackColor = true;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 287);
            this.Controls.Add(this.btnVisszavetel);
            this.Controls.Add(this.btnKolcsonzes);
            this.Controls.Add(this.btnKonyvek);
            this.Controls.Add(this.btnKereses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnKonyvek;
        private System.Windows.Forms.Button btnKolcsonzes;
        private System.Windows.Forms.Button btnVisszavetel;
    }
}