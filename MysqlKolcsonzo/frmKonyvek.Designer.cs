namespace MysqlKolcsonzo
{
    partial class frmKonyvek
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
            this.tbTag = new System.Windows.Forms.TextBox();
            this.btnLekerdez = new System.Windows.Forms.Button();
            this.lbEredmenyek = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDarab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tag neve:";
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(138, 33);
            this.tbTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(396, 26);
            this.tbTag.TabIndex = 0;
            // 
            // btnLekerdez
            // 
            this.btnLekerdez.Location = new System.Drawing.Point(577, 33);
            this.btnLekerdez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLekerdez.Name = "btnLekerdez";
            this.btnLekerdez.Size = new System.Drawing.Size(152, 28);
            this.btnLekerdez.TabIndex = 1;
            this.btnLekerdez.Text = "Lekérdez";
            this.btnLekerdez.UseVisualStyleBackColor = true;
            this.btnLekerdez.Click += new System.EventHandler(this.btnLekerdez_Click);
            // 
            // lbEredmenyek
            // 
            this.lbEredmenyek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEredmenyek.FormattingEnabled = true;
            this.lbEredmenyek.ItemHeight = 16;
            this.lbEredmenyek.Location = new System.Drawing.Point(21, 147);
            this.lbEredmenyek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbEredmenyek.Name = "lbEredmenyek";
            this.lbEredmenyek.Size = new System.Drawing.Size(783, 276);
            this.lbEredmenyek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Könyvek száma:";
            // 
            // lblDarab
            // 
            this.lblDarab.AutoSize = true;
            this.lblDarab.Location = new System.Drawing.Point(161, 435);
            this.lblDarab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDarab.Name = "lblDarab";
            this.lblDarab.Size = new System.Drawing.Size(27, 20);
            this.lblDarab.TabIndex = 5;
            this.lblDarab.Text = "12";
            // 
            // frmKonyvek
            // 
            this.AcceptButton = this.btnLekerdez;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 480);
            this.Controls.Add(this.lblDarab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbEredmenyek);
            this.Controls.Add(this.btnLekerdez);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmKonyvek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kölcsönzések listája";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.Button btnLekerdez;
        private System.Windows.Forms.ListBox lbEredmenyek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDarab;
    }
}