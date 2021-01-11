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
    public partial class AdaugaActiune : Form
    { 
        Actiuni actiune;
    
        public AdaugaActiune(Actiuni actiune=null)
        {
            InitializeComponent();
            this.actiune = actiune;
            if (actiune == null)
            {
                Text = "Adaugare actiune";
                tbNumar.Text = "0";
                tbVal.Text = "0.00";
                tbPret.Text = "0.00";
            }

            else
            {
                Text = "Modificare actiune";
                tbDenumire.Text = actiune.DenumireSocietate;
                tbNumar.Text = actiune.NumarActiuni.ToString();
                tbVal.Text = actiune.ValoareNominala.ToString();
                tbPret.Text = actiune.PretVanzare.ToString();

            }
        }

        public Actiuni Actiune { get { return actiune; } }

        public bool EsteValid()
        {
            return EsteValidDenumire() && EsteValidNumarActiuni() && EsteValidValoareNominala() && EsteValidPretVanzare();
        }

        public bool EsteValidDenumire()
        {if (tbDenumire.Text.Length > 2)
                return true;
            else return false;
        }

        public bool EsteValidNumarActiuni()
        { if (Convert.ToInt32(tbNumar.Text) > 2)
                return true;
            else return false;
        }

        public bool EsteValidValoareNominala()
        {if (Convert.ToDouble(tbVal) > 0.00)
                return true;
            else return false;
        }

        public bool EsteValidPretVanzare()
        {
            if (Convert.ToDouble(tbPret) > 0.00)
                return true;
            else return false;
        }

        private void AdaugaActiune_Load(object sender, EventArgs e)
        {

        }

        private void tbDenumire_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            EsteValidDenumire();
        }

        private void tbNumar_Validated(object sender, EventArgs e)
        {
            EsteValidNumarActiuni();
        }

        private void tbVal_Validated(object sender, EventArgs e)
        {
            EsteValidValoareNominala();
        }

        private void tbPret_Validated(object sender, EventArgs e)
        {
            EsteValidPretVanzare();
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            if (!EsteValid())
            {
                return;
            }

            if (actiune == null)
            {
                actiune = new Actiuni(tbDenumire.Text,int.Parse(tbNumar.Text),double.Parse(tbVal.Text),double.Parse(tbPret.Text));
            }

            else
            {
                actiune.DenumireSocietate = tbDenumire.Text;
                actiune.NumarActiuni = int.Parse(tbNumar.Text);
                actiune.ValoareNominala = double.Parse(tbVal.Text);
                actiune.PretVanzare = double.Parse(tbPret.Text);
            }

            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Click(object sender, EventArgs e)
        {

       
        }
    }
}
