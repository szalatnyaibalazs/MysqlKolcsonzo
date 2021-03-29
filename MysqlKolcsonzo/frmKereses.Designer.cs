namespace MysqlKolcsonzo
{
    partial class frmKereses
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.btnKereses = new System.Windows.Forms.Button();
            this.lbEredmenyek = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cím részlet";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(108, 12);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(443, 26);
            this.tbCim.TabIndex = 0;
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(557, 12);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(124, 29);
            this.btnKereses.TabIndex = 1;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // lbEredmenyek
            // 
            this.lbEredmenyek.FormattingEnabled = true;
            this.lbEredmenyek.ItemHeight = 20;
            this.lbEredmenyek.Location = new System.Drawing.Point(12, 96);
            this.lbEredmenyek.Name = "lbEredmenyek";
            this.lbEredmenyek.Size = new System.Drawing.Size(669, 224);
            this.lbEredmenyek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Találatok:";
            // 
            // frmKereses
            // 
            this.AcceptButton = this.btnKereses;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbEredmenyek);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKereses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keresés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.ListBox lbEredmenyek;
        private System.Windows.Forms.Label label2;
    }
}