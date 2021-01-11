using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace GestiunePortofoliuActiuni
{
    public partial class FormularActionari : Form
    {
        int count = 0;
        OleDbConnection conexiune = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\source\repos\GestiunePortofoliuActiuni\GestiunePortofoliuActiuni\Actionari.mdb");

        public FormularActionari()
        {
            InitializeComponent();
        }




        private void btAdaugare_Click(object sender, EventArgs e)
        {
            conexiune.Open();
            OleDbCommand cmd = conexiune.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Actionari values('" + tbNume.Text + "','" + tbPrenume.Text + "','" + tbCNP.Text + "','" + cbActiune.Text + "')";
            cmd.ExecuteNonQuery();
            conexiune.Close();
            tbNume.Text = "";
            tbPrenume.Text = "";
            MessageBox.Show("Înregistrarea a fost realizată cu succes.");
            tbNume.Clear();
            tbPrenume.Clear();
            tbCNP.Clear();

        }

        private void btAfisare_Click(object sender, EventArgs e)
        {
            conexiune.Open();
            OleDbCommand cmd = conexiune.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Actionari";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexiune.Close();

            
        }

        private void btCautare_Click(object sender, EventArgs e)
        {
            count = 0;
            conexiune.Open();
            OleDbCommand cmd = conexiune.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Actionari where Nume='" + tbCautare.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            conexiune.Close();


            if (count == 0)
            {
                MessageBox.Show("Înregistrarea nu a fost găsită.");
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 10, 10);
        }


        
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void închideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            conexiune.Open();
            OleDbCommand cmd = conexiune.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Actionari where Nume='" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            conexiune.Close();


            if (count == 0)
            {
                MessageBox.Show("Înregistrarea nu a fost găsită.");
            }
        }

        private void tbCautare_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void tbCautare_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tbCautare_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void FormularActionari_Load(object sender, EventArgs e)
        {
            textBox1.DragEnter += new DragEventHandler(tbCautare_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(tbCautare_MouseDown);
            textBox1.DragDrop += new DragEventHandler(tbCautare_DragDrop);

            tbCautare.PreviewKeyDown += tbCautare_PreviewKeyDown;
            tbCautare.KeyDown += tbCautare_KeyDown;


        }

        private void tbCautare_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control)
            {
                e.IsInputKey = true;
            }
        }

        private void tbCautare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.K)
            {
                Clipboard.SetText(tbCautare.SelectedText);
            }
        }

       
    }
}

