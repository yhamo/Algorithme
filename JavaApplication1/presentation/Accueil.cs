using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
using System.Windows.Forms;

namespace presentation
{
    public partial class Accueil : Form
    {
        private unSite unS;
        private unSite unSi;
        public Accueil()
        {
            InitializeComponent();
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unS = new unSite();
            FormVille unsaisie = new FormVille(unS);
            unsaisie.Show();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saisieDesDepartementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unSi = new unSite();
            FormDepartement unDep = new FormDepartement(unSi);
            unDep.Show();
        }
    }
}
