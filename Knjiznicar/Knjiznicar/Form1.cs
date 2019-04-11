using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznicar
{
    public partial class Form1 : Form
    {
        public string formatListe= "{0,-30}{1,-15}";
        public class knjiga
        {
            public string nazivKnjige;
            public string iznajmljeno;
        }
        public List<knjiga> popisKnjiga = new List<knjiga>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPopis.Items.Add(String.Format(formatListe, "Knjiga", "Iznajmljena"));
            cmbIznajmljena.Items.Add("Da");
            cmbIznajmljena.Items.Add("Ne");

            cmbFilter.Items.Add("Iznajmljena");
            cmbFilter.Items.Add("Nije iznajmljena");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            knjiga trenutniUnos = new knjiga();
            trenutniUnos.nazivKnjige = txtKnjiga.Text;
            trenutniUnos.iznajmljeno = cmbIznajmljena.Text;
            popisKnjiga.Add(trenutniUnos);
            lstPopis.Items.Add(String.Format(formatListe, trenutniUnos.nazivKnjige, trenutniUnos.iznajmljeno));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int brojac = 0; brojac < popisKnjiga.Count; brojac++)
            {
                if (txtIznajmi.Text == popisKnjiga[brojac].nazivKnjige)
                {
                   if (popisKnjiga[brojac].iznajmljeno != "Da")
                    {
                        popisKnjiga[brojac].iznajmljeno = "Da";
                    }
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPopis.Items.Clear();
            if (cmbFilter.Text == "Iznajmljena") {
                for (int brojac = 0; brojac < popisKnjiga.Count; brojac++)
                {
                    if (popisKnjiga[brojac].iznajmljeno == "Da")
                    {
                        lstPopis.Items.Add(string.Format(formatListe, popisKnjiga[brojac].nazivKnjige, popisKnjiga[brojac].iznajmljeno));
                    }
                }
            }
            else
            {
                for (int brojac = 0; brojac < popisKnjiga.Count; brojac++)
                {
                    if (popisKnjiga[brojac].iznajmljeno == "Ne")
                    {
                        lstPopis.Items.Add(string.Format(formatListe, popisKnjiga[brojac].nazivKnjige, popisKnjiga[brojac].iznajmljeno));
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int brojac = 0; brojac < popisKnjiga.Count; brojac++)
            {
                if (txtIznajmi.Text == popisKnjiga[brojac].nazivKnjige)
                {
                    if (popisKnjiga[brojac].iznajmljeno == "Da")
                    {
                        popisKnjiga[brojac].iznajmljeno = "Ne";
                    }
                }
            }
        }
    }
}
