using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GestiunePortofoliuActiuni
{
    public partial class FormularIntrare : Form
    {
        public FormularIntrare()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\source\repos\GestiunePortofoliuActiuni\GestiunePortofoliuActiuni\Login.mdb");
            OleDbDataAdapter a = new OleDbDataAdapter("Select count(*) from Login where Username='" + tbUser.Text + "'and Password='" + tbParola.Text + "'", conexiune);
            DataTable dt = new DataTable();
            a.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                FormularIntroducere formular = new FormularIntroducere();
                formular.Show();
            }

            else
            {
                MessageBox.Show("Date introduse greșit!");
            }
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
