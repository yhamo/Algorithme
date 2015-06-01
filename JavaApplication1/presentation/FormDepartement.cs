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
    public partial class FormDepartement : Form
    {
        private unSite unSite;
        public FormDepartement(unSite leSite)
        {
            unSite = leSite;
            InitializeComponent();
            richTextBox2.Text="NVESTIPOLE Détective Privé à Lyon, des détectives à votre service \n en toute discrétion : l’assurance d’un travail de qualité \n dans toute la région Rhône-Alpes avec une garantie de confidentialité.\n Où intervenons-nous ? \n Entreprises et particuliers font régulièrement appel à INVESTIPOLE DÉTECTIVE \n pour toutes investigations dans les régions et villes ci-dessous :";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
           tb_NomDep.Clear();
           tb_NumeroDep.Clear();
            rtb_DescDep.Clear();

        }
        

        private void btn_generer_Click_1(object sender, EventArgs e)
        {
            try
            {

                // Saisie pour la classe unePage
                unSite.CodePostal = tb_NumeroDep.Text;
                unSite.Departement = tb_NomDep.Text;
                unSite.Ville = tb_NomDep.Text;
                Bdd bdd = new Bdd();
                string titre = "Détective " + tb_NomDep.Text + " " + tb_NumeroDep.Text;
                // Création d'une page à ajouter
                unePage laPage = new unePage();
                laPage.Author = "1";
                laPage.Date = DateTime.Now;
                laPage.DateGmt = DateTime.Now;
                laPage.Content = rtb_DescDep.Text+"<br /> <ul>";
                laPage.Title = titre;
                laPage.Excerpt = "";
                laPage.Status = "publish";
                laPage.CommentStatus = "open";
                laPage.PingStatus = "open";
                laPage.Name = unSite.GenererLienName(titre);
                laPage.Password = "";
                laPage.ToPing = "open";
                laPage.Pinged = "";
                laPage.Modified = DateTime.Now;
                laPage.ModifiedGtm = DateTime.Now;

                laPage.ContentFiltered = "";
                // Par Rapport au numero affilé a la page parent
                // C'est une variable qui change !!!
                laPage.Parent = bdd.GenrerIdParentZoneIntervention();
                //Par rapport au lien du site
                // C'est une variable qui change !!!
                laPage.Guid = unSite.GenererLienDep(bdd.GenrerIdTitreSite());
                laPage.MenuOrder = 0;
                laPage.Type = "page";
                laPage.MineType = "";
                laPage.Count = "0";
                bdd.AddPage(laPage);

                //Creation d'une balise SEO
                Seo unSeo = new Seo();
                // Echange des données avec Bdd

                bdd.SearchPostIdDep(unSeo, titre);
                unSeo.Meta_key = "_yoast_wpseo_focuskw";
                unSeo.Meta_value = unSite.GenererMotCle();
                bdd.AddSeo(unSeo);
                unSeo.Meta_key = "_yoast_wpseo_title";
                unSeo.Meta_value = unSite.GenererTitreSEOInvestipole();
                bdd.AddSeo(unSeo);
                unSeo.Meta_key = "_yoast_wpseo_metadesc";
                unSeo.Meta_value = unSite.GenererMetaDesc();
                bdd.AddSeo(unSeo);
                MessageBox.Show("Cette page vient d'être ajouté !!!");
            }
            catch
            {
                MessageBox.Show("Une erreur c'est produite lors de l'ajout vérifié la saisie");
            }
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
