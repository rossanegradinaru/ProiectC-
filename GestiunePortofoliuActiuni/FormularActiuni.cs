using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiunePortofoliuActiuni
{
    public partial class FormularActiuni : Form
    {
        List<Actiuni> actiuni;
        public FormularActiuni()
        {
            InitializeComponent();
            actiuni = new List<Actiuni>
            {
                new Actiuni("ALRO SA",10,1.11,1.49),
                new Actiuni("OMV Petrom",15,0.29,0.33),
                new Actiuni("BRD GROUPE SOCIETE GENERALE SA",20,11.00,11.12),
                new Actiuni("Digi Communications N.V.",21,33.00,33.50),
                new Actiuni("Sphera Franchise Group",20,15.00,15.30),
                new Actiuni("MedLife SA",19,31.50,32.20)


            };

            AfisareActiuni();
        }

        void AfisareActiuni()
        {
            lvActiuni.Items.Clear();
            foreach(var actiune in actiuni)
            {
                var item = new ListViewItem(new string[] { actiune.DenumireSocietate,actiune.NumarActiuni.ToString(),actiune.ValoareNominala.ToString(),actiune.PretVanzare.ToString()});
                item.Tag = actiune;
                lvActiuni.Items.Add(item);
            }
        }

        private void FormularActiuni_Load(object sender, EventArgs e)
        {
            lvActiuni.AllowDrop = true;
            //lvActiuni.DragDrop += new DragEventHandler(lvActiuni_DragDrop);
            //lvActiuni.DragEnter += new DragEventHandler(lvActiuni_DragEnter);
        }

        private void btAdaugare_Click(object sender, EventArgs e)
        {
            using (AdaugaActiune formular = new AdaugaActiune())
            {
                if(formular.ShowDialog(this)==DialogResult.OK)
                {
                    actiuni.Add(formular.Actiune);
                    AfisareActiuni();
                }

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btStergere_Click(object sender, EventArgs e)
        {
        
            if (lvActiuni.SelectedItems.Count < 0)
            {
                return;
            }

            try {
                Actiuni actiune = (Actiuni)lvActiuni.SelectedItems[0].Tag;
                var rezultat = MessageBox.Show(this,
                  $"Sunteți sigur că doriți ștergerea actiunii '{actiune.DenumireSocietate}'?",
                  "Ștergere Produs",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);

                if (rezultat == DialogResult.Yes)
                {
                    actiuni.Remove(actiune);
                    AfisareActiuni();
                }
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show(" Nu ati selectat nicio actiune");
            }
        }

        private void salveazaInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "(*.txt)|*.txt";
                save.ShowDialog();
                string fisier = save.FileName;
                StreamWriter sw = new StreamWriter(fisier);
                foreach(ListViewItem item in lvActiuni.Items)
                {
                    for(int i = 0; i < item.SubItems.Count; i++)
                    {
                        sw.Write(item.SubItems[i].Text);
                        if (i != item.SubItems.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }
                sw.Close();
                MessageBox.Show("Fișier creat!");

                                   
                
            }
            catch (ObjectDisposedException) { MessageBox.Show("Operatiunea nu este posibila!"); }
            catch (ArgumentOutOfRangeException){ MessageBox.Show("Nu ati selectat nicio actiune!"); }
        }

        private void InitializareDate(string numeFisier)
        {
            try
            {
                StreamReader sr=new StreamReader(numeFisier);
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    string denumire = linie.Split(',')[0];
                    int nrActiuni = Convert.ToInt32(linie.Split(',')[1]);
                    double valoare = Convert.ToDouble(linie.Split(',')[2]);
                    double pret = Convert.ToDouble(linie.Split(',')[3]);
                    actiuni.Add(new Actiuni(denumire, nrActiuni, valoare, pret));

                }
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializareLista()
        {
          
            foreach (Actiuni a in actiuni)
            {
                ListViewItem item = new ListViewItem(a.DenumireSocietate);
                item.SubItems.Add(a.NumarActiuni.ToString());
                item.SubItems.Add(a.ValoareNominala.ToString());
                item.SubItems.Add(a.PretVanzare.ToString());
                lvActiuni.Items.Add(item);
            }
        }
        private void scrieActiuneDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvActiuni.Items.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string fisier = op.FileName;
            InitializareDate(fisier);
            InitializareLista();
        }

        private void lvActiuni_DragDrop(object sender, DragEventArgs e)
        {
            //string text = e.Data.GetData(typeof(string)).ToString();

            //try
            //{

            //    string denumire = text.Split(',')[0];
            //    int nrActiuni = Convert.ToInt32(text.Split(',')[1]);
            //    double valoare = Convert.ToDouble(text.Split(',')[2]);
            //    double pret = Convert.ToDouble(text.Split(',')[3]);
            //    Actiuni a = new Actiuni(denumire, nrActiuni, valoare, pret);
            //    actiuni.Add(a);
            //    lvActiuni.Items.Add(a.ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //if (e.Effect == DragDropEffects.Move)
            //    lvActiuni.Clear();

           
        }

        private void lvActiuni_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.None;
            //if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            //    e.Effect = DragDropEffects.Copy;
            //else
            //    if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            //    e.Effect = DragDropEffects.Move;

            //e.Effect = DragDropEffects.Copy;
        }

        private void lvActiuni_MouseDown(object sender, MouseEventArgs e)
        {
            //if (lvActiuni.Items.Count > 0)
            //    lvActiuni.DoDragDrop(lvActiuni.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);
        }
    }
}

