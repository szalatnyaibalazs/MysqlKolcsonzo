namespace MysqlKolcsonzo
{
    partial class frmKolcsonzes
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
            this.cbKonyv = new System.Windows.Forms.ComboBox();
            this.btnKolcsonoz = new System.Windows.Forms.Button();
            this.dtpLejarat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Könyv";
            // 
            // cbKonyv
            // 
            this.cbKonyv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKonyv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKonyv.FormattingEnabled = true;
            this.cbKonyv.Location = new System.Drawing.Point(195, 23);
            this.cbKonyv.Name = "cbKonyv";
            this.cbKonyv.Size = new System.Drawing.Size(424, 23);
            this.cbKonyv.TabIndex = 0;
            // 
            // btnKolcsonoz
            // 
            this.btnKolcsonoz.Location = new System.Drawing.Point(36, 174);
            this.btnKolcsonoz.Name = "btnKolcsonoz";
            this.btnKolcsonoz.Size = new System.Drawing.Size(148, 30);
            this.btnKolcsonoz.TabIndex = 4;
            this.btnKolcsonoz.Text = "Kölcsönöz";
            this.btnKolcsonoz.UseVisualStyleBackColor = true;
            this.btnKolcsonoz.Click += new System.EventHandler(this.btnKolcsonoz_Click);
            // 
            // dtpLejarat
            // 
            this.dtpLejarat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLejarat.Location = new System.Drawing.Point(195, 127);
            this.dtpLejarat.Name = "dtpLejarat";
            this.dtpLejarat.Size = new System.Drawing.Size(163, 26);
            this.dtpLejarat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kölcsönző személy";
            // 
            // cbTag
            // 
            this.cbTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Location = new System.Drawing.Point(195, 71);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(424, 28);
            this.cbTag.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lejárat";
            // 
            // frmKolcsonzes
            // 
            this.AcceptButton = this.btnKolcsonoz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLejarat);
            this.Controls.Add(this.btnKolcsonoz);
            this.Controls.Add(this.cbKonyv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKolcsonzes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lolcsönzés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKonyv;
        private System.Windows.Forms.Button btnKolcsonoz;
        private System.Windows.Forms.DateTimePicker dtpLejarat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Label label3;
    }
}