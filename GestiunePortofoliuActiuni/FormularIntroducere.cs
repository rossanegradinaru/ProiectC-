using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiunePortofoliuActiuni
{
    public partial class FormularIntroducere : Form
    {
        public FormularIntroducere()
        {
            InitializeComponent();
        }

        private void FormularIntroducere_Load(object sender, EventArgs e)
        {

        }
        int t1 = 45;


        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(this.panel1.Size.Width, t1);
            timer1.Start();

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            t1 = 45;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1 > 225)
            {
                timer1.Stop();
            }
            else
            {
                this.panel1.Size = new Size(this.panel1.Size.Width, t1);
                t1 += 5;
            }
        }

        private void FormularIntroducere_MouseHover(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(this.panel1.Size.Width, t1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FormularActiuni formular = new FormularActiuni();
            formular.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            FormularIntrare formular = new FormularIntrare();
            formular.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            FormularActionari formular = new FormularActionari();
            formular.Show();
        }

        private void btGrafic_Click(object sender, EventArgs e)
        {
          
            FormularGrafic formular = new FormularGrafic();
            formular.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
