namespace GestiunePortofoliuActiuni
{
    partial class FormularActiuni
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
            this.lvActiuni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAdaugare = new System.Windows.Forms.Button();
            this.btStergere = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrieActiuneDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionariDataSet1 = new GestiunePortofoliuActiuni.ActionariDataSet();
            this.actionariTableAdapter1 = new GestiunePortofoliuActiuni.ActionariDataSetTableAdapters.ActionariTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionariDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvActiuni
            // 
            this.lvActiuni.AllowDrop = true;
            this.lvActiuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvActiuni.HideSelection = false;
            this.lvActiuni.Location = new System.Drawing.Point(56, 100);
            this.lvActiuni.Name = "lvActiuni";
            this.lvActiuni.Size = new System.Drawing.Size(1015, 313);
            this.lvActiuni.TabIndex = 0;
            this.lvActiuni.UseCompatibleStateImageBehavior = false;
            this.lvActiuni.View = System.Windows.Forms.View.Details;
            this.lvActiuni.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvActiuni_DragDrop);
            this.lvActiuni.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvActiuni_DragEnter);
            this.lvActiuni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvActiuni_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire societate";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Număr acțiuni";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valoare nominală";
            this.columnHeader3.Width = 193;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preț vânzare";
            this.columnHeader4.Width = 172;
            // 
            // btAdaugare
            // 
            this.btAdaugare.Location = new System.Drawing.Point(99, 474);
            this.btAdaugare.Name = "btAdaugare";
            this.btAdaugare.Size = new System.Drawing.Size(157, 65);
            this.btAdaugare.TabIndex = 1;
            this.btAdaugare.Text = "Adauga o actiune";
            this.btAdaugare.UseVisualStyleBackColor = true;
            this.btAdaugare.Click += new System.EventHandler(this.btAdaugare_Click);
            // 
            // btStergere
            // 
            this.btStergere.Location = new System.Drawing.Point(314, 474);
            this.btStergere.Name = "btStergere";
            this.btStergere.Size = new System.Drawing.Size(190, 65);
            this.btStergere.TabIndex = 2;
            this.btStergere.Text = "Sterge actiunea selectata";
            this.btStergere.UseVisualStyleBackColor = true;
            this.btStergere.Click += new System.EventHandler(this.btStergere_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(893, 474);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(140, 65);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Inchide";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierToolStripMenuItem,
            this.scrieActiuneDinFisierToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.fisierToolStripMenuItem.Text = "Fișier";
            // 
            // salveazaInFisierToolStripMenuItem
            // 
            this.salveazaInFisierToolStripMenuItem.Name = "salveazaInFisierToolStripMenuItem";
            this.salveazaInFisierToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.salveazaInFisierToolStripMenuItem.Text = "Salvează acțiuni în fișier";
            this.salveazaInFisierToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierToolStripMenuItem_Click);
            // 
            // scrieActiuneDinFisierToolStripMenuItem
            // 
            this.scrieActiuneDinFisierToolStripMenuItem.Name = "scrieActiuneDinFisierToolStripMenuItem";
            this.scrieActiuneDinFisierToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.scrieActiuneDinFisierToolStripMenuItem.Text = "Scrie acțiuni din fișier";
            this.scrieActiuneDinFisierToolStripMenuItem.Click += new System.EventHandler(this.scrieActiuneDinFisierToolStripMenuItem_Click);
            // 
            // actionariDataSet1
            // 
            this.actionariDataSet1.DataSetName = "ActionariDataSet";
            this.actionariDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionariTableAdapter1
            // 
            this.actionariTableAdapter1.ClearBeforeFill = true;
            // 
            // FormularActiuni
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestiunePortofoliuActiuni.Properties.Resources.Untitled1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 583);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btStergere);
            this.Controls.Add(this.btAdaugare);
            this.Controls.Add(this.lvActiuni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularActiuni";
            this.Text = "FormularActiuni";
            this.Load += new System.EventHandler(this.FormularActiuni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionariDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvActiuni;
        private System.Windows.Forms.Button btAdaugare;
        private System.Windows.Forms.Button btStergere;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrieActiuneDinFisierToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private ActionariDataSet actionariDataSet1;
        private ActionariDataSetTableAdapters.ActionariTableAdapter actionariTableAdapter1;
    }
}