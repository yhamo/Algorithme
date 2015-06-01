using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace presentation
{
    public partial class AffichagePageVille : Form
    {
        private unSite unSiteWeb;
        
        /// <summary>
        /// Methode qui permet de générer la fenêtre affichage
        /// </summary>
        /// <param name="unSite"></param>
        public AffichagePageVille(unSite unSite)
        {
            unSiteWeb = unSite; 
            InitializeComponent();
            rtb_html.Text = unSiteWeb.GenererTexteAixMarseille();
            tb_Titre.Text = unSiteWeb.GenererTitreAixMarseille();
            tb_motClé.Text = unSiteWeb.GenererMotCle();
            tb_titreSEO.Text = unSiteWeb.GenererTitreSEOInvestipole();
            tb_metaDesc.Text = unSiteWeb.GenererMetaDesc();
            tb_LienInt.Text = unSiteWeb.GenererLienInt();
               
          
        }    


        /// <summary>
        /// Bouton qui permet d'ajouter une nouvelle page à la base de données en local suivant les informations rentrées dans le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EnvoyerBdd_Click(object sender, EventArgs e)
        {
            // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            Bdd bdd = new Bdd();

            // Saisie pour la classe unePage
            // Création d'une page à ajouter
            unePage laPage = new unePage();

            laPage.Author = "1";
            laPage.Date = DateTime.Now;
            laPage.DateGmt = DateTime.Now;
            laPage.Content = rtb_html.Text;
            laPage.Title = tb_Titre.Text;
            laPage.Excerpt = "";
            laPage.Status = "publish";
            laPage.CommentStatus = "open";
            laPage.PingStatus = "open";
            laPage.Name = unSiteWeb.GenererLienName(tb_Titre.Text);
            laPage.Password = "";
            laPage.ToPing = "open";
            laPage.Pinged = "";
            laPage.Modified = DateTime.Now;
            laPage.ModifiedGtm = DateTime.Now;

            laPage.ContentFiltered = "";
            // Par Rapport au numero affilé a la page parent
            // C'est une variable qui change !!!
            laPage.Parent = bdd.GenrerIdParentVille(unSiteWeb.Departement);
            //Par rapport au lien du site
            // C'est une variable qui change !!!
            laPage.Guid = unSiteWeb.GenererLienVille(bdd.GenrerIdTitreSite());
            laPage.MenuOrder = 0;
            laPage.Type = "page";
            laPage.MineType = "";
            laPage.Count = "0";

            //Creation d'une balise SEO
            Seo unSeo = new Seo();
            // Echange des données avec Bdd
            bdd.AddPage(laPage);
            bdd.SearchPostId(unSeo,unSiteWeb);
            unSeo.Meta_key = "_yoast_wpseo_focuskw";
            unSeo.Meta_value = unSiteWeb.GenererMotCle();
            bdd.AddSeo(unSeo);
            unSeo.Meta_key = "_yoast_wpseo_title";
            unSeo.Meta_value = unSiteWeb.GenererTitreSEOInvestipole();
            bdd.AddSeo(unSeo);
            unSeo.Meta_key = "_yoast_wpseo_metadesc";
            unSeo.Meta_value = unSiteWeb.GenererMetaDesc();
            bdd.AddSeo(unSeo);
            bdd.AddBalise(bdd.GenrerIdParentVille(unSiteWeb.Departement),unSiteWeb.GenererLienInt());
            MessageBox.Show("Cette page à été Rajouté");
        }


        /// <summary>
        /// Bouton qui permet de fermer la fenêtre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
