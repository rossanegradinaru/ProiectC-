namespace GestiunePortofoliuActiuni
{
    partial class AdaugaActiune
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumar = new System.Windows.Forms.TextBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.btAdauga = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.userControl11 = new GestiunePortofoliuActiuni.UserControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire societate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar actiuni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valoare nominala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret vanzare";
            // 
            // tbNumar
            // 
            this.tbNumar.Location = new System.Drawing.Point(304, 122);
            this.tbNumar.Name = "tbNumar";
            this.tbNumar.Size = new System.Drawing.Size(273, 26);
            this.tbNumar.TabIndex = 4;
            this.tbNumar.Validated += new System.EventHandler(this.tbNumar_Validated);
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(304, 187);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(273, 26);
            this.tbVal.TabIndex = 5;
            this.tbVal.Validated += new System.EventHandler(this.tbVal_Validated);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(304, 71);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(273, 26);
            this.tbDenumire.TabIndex = 6;
            this.tbDenumire.TextChanged += new System.EventHandler(this.tbDenumire_TextChanged);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(304, 250);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(273, 26);
            this.tbPret.TabIndex = 7;
            this.tbPret.Validated += new System.EventHandler(this.tbPret_Validated);
            // 
            // btAdauga
            // 
            this.btAdauga.Location = new System.Drawing.Point(261, 365);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(119, 40);
            this.btAdauga.TabIndex = 8;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(472, 365);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 40);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Anuleaza";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-77, 344);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(287, 77);
            this.userControl11.TabIndex = 10;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click);
            // 
            // AdaugaActiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.tbNumar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaActiune";
            this.Text = "AdaugaActiune";
            this.Load += new System.EventHandler(this.AdaugaActiune_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumar;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Button btCancel;
        private UserControl1 userControl11;
    }
}