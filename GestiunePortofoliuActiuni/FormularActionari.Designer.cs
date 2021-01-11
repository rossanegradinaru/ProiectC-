namespace GestiunePortofoliuActiuni
{
    partial class FormularActionari
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularActionari));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipActiuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionariDataSet = new GestiunePortofoliuActiuni.ActionariDataSet();
            this.actionariTableAdapter = new GestiunePortofoliuActiuni.ActionariDataSetTableAdapters.ActionariTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbCautare = new System.Windows.Forms.TextBox();
            this.cbActiune = new System.Windows.Forms.ComboBox();
            this.btAfisare = new System.Windows.Forms.Button();
            this.btAdaugare = new System.Windows.Forms.Button();
            this.btCautare = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginTableAdapter1 = new GestiunePortofoliuActiuni.LoginDataSetTableAdapters.LoginTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionariDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.tipActiuneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actionariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(614, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // tipActiuneDataGridViewTextBoxColumn
            // 
            this.tipActiuneDataGridViewTextBoxColumn.DataPropertyName = "TipActiune";
            this.tipActiuneDataGridViewTextBoxColumn.HeaderText = "TipActiune";
            this.tipActiuneDataGridViewTextBoxColumn.Name = "tipActiuneDataGridViewTextBoxColumn";
            // 
            // actionariBindingSource
            // 
            this.actionariBindingSource.DataMember = "Actionari";
            this.actionariBindingSource.DataSource = this.actionariDataSet;
            // 
            // actionariDataSet
            // 
            this.actionariDataSet.DataSetName = "ActionariDataSet";
            this.actionariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionariTableAdapter
            // 
            this.actionariTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tip acțiune";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(143, 339);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(121, 26);
            this.tbNume.TabIndex = 6;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(143, 379);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(121, 26);
            this.tbPrenume.TabIndex = 7;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(143, 418);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(121, 26);
            this.tbCNP.TabIndex = 8;
            // 
            // tbCautare
            // 
            this.tbCautare.AllowDrop = true;
            this.tbCautare.Location = new System.Drawing.Point(689, 69);
            this.tbCautare.Multiline = true;
            this.tbCautare.Name = "tbCautare";
            this.tbCautare.Size = new System.Drawing.Size(186, 35);
            this.tbCautare.TabIndex = 9;
            this.tbCautare.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbCautare_DragDrop);
            this.tbCautare.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbCautare_DragEnter);
            this.tbCautare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCautare_KeyDown);
            this.tbCautare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbCautare_MouseDown);
            this.tbCautare.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbCautare_PreviewKeyDown);
            // 
            // cbActiune
            // 
            this.cbActiune.FormattingEnabled = true;
            this.cbActiune.Items.AddRange(new object[] {
            "Ordinară",
            "Preferențială"});
            this.cbActiune.Location = new System.Drawing.Point(143, 455);
            this.cbActiune.Name = "cbActiune";
            this.cbActiune.Size = new System.Drawing.Size(121, 28);
            this.cbActiune.TabIndex = 10;
            // 
            // btAfisare
            // 
            this.btAfisare.Location = new System.Drawing.Point(347, 432);
            this.btAfisare.Name = "btAfisare";
            this.btAfisare.Size = new System.Drawing.Size(205, 40);
            this.btAfisare.TabIndex = 11;
            this.btAfisare.Text = "Afișează";
            this.btAfisare.UseVisualStyleBackColor = true;
            this.btAfisare.Click += new System.EventHandler(this.btAfisare_Click);
            // 
            // btAdaugare
            // 
            this.btAdaugare.Location = new System.Drawing.Point(347, 372);
            this.btAdaugare.Name = "btAdaugare";
            this.btAdaugare.Size = new System.Drawing.Size(205, 41);
            this.btAdaugare.TabIndex = 12;
            this.btAdaugare.Text = "Adaugă înregistrare";
            this.btAdaugare.UseVisualStyleBackColor = true;
            this.btAdaugare.Click += new System.EventHandler(this.btAdaugare_Click);
            // 
            // btCautare
            // 
            this.btCautare.Location = new System.Drawing.Point(689, 110);
            this.btCautare.Name = "btCautare";
            this.btCautare.Size = new System.Drawing.Size(186, 53);
            this.btCautare.TabIndex = 13;
            this.btCautare.Text = "Caută după nume";
            this.btCautare.UseVisualStyleBackColor = true;
            this.btCautare.Click += new System.EventHandler(this.btCautare_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.printToolStripMenuItem.Text = "Tipărire";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(689, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 41);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Căutare după nume(drag and drop)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularActionari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestiunePortofoliuActiuni.Properties.Resources.Untitled1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(983, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btCautare);
            this.Controls.Add(this.btAdaugare);
            this.Controls.Add(this.btAfisare);
            this.Controls.Add(this.cbActiune);
            this.Controls.Add(this.tbCautare);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormularActionari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularActionari";
            this.Load += new System.EventHandler(this.FormularActionari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionariDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private ActionariDataSet actionariDataSet;
        private System.Windows.Forms.BindingSource actionariBindingSource;
        private ActionariDataSetTableAdapters.ActionariTableAdapter actionariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipActiuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbCautare;
        private System.Windows.Forms.ComboBox cbActiune;
        private System.Windows.Forms.Button btAfisare;
        private System.Windows.Forms.Button btAdaugare;
        private System.Windows.Forms.Button btCautare;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private LoginDataSetTableAdapters.LoginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}