using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Metier;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation
{
    public partial class FormVille : Form
    {
        private unSite unSite;
        
        /// <summary>
        /// Méthode qui permet d'initialiser les éléments de la page
        /// </summary>
        /// <param name="leSite"></param>
        public FormVille(unSite leSite)
        {
            unSite = leSite;
            InitializeComponent();
            Bdd bdd = new Bdd();
            BindingSource bs = new BindingSource();
            bs.DataSource = bdd.GenererCB();
            cb_Dep.DataSource = bs;
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

        /// <summary>
        /// Bouton qui permet de générer une page affichant d'inverse contenu en fonction des informations saisies dans le formulaire
        /// et de gérer les liens en fonction du site et du département choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generer_Click(object sender, EventArgs e)
        {
           
            //Saisie des données pour la Classe unSite
            String tampon;
            tampon = txt_Ville.Text;
            unSite.Ville = tampon;
            tampon = txt_Region.Text;
            unSite.Region = tampon;
            tampon = txt_CodePostal.Text;
            unSite.CodePostal = tampon;
            tampon = txt_TelFixe.Text;
            unSite.TelFix = tampon;
            tampon = txt_Port1.Text;
            unSite.Portable1 = tampon;
            tampon = txt_Port2.Text;
            unSite.Portable2 = tampon;
            tampon = txt_Email.Text;
            unSite.Email = tampon;
            tampon = txt_UrlP.Text;
            unSite.UrlP = tampon;
            tampon = txt_UrlE.Text;
            unSite.UrlE = tampon;
            
            unSite.Departement = cb_Dep.Text;

            AffichagePageVille unAffichage = new AffichagePageVille(unSite);
            unAffichage.Show();
        }

        private void SaisieLyonIndicia_Load(object sender, EventArgs e)
        {


        }
        
        /// <summary>
        /// Bouton qui permet de vider toutes les textbox du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Ville.Clear();
            txt_CodePostal.Clear();
            txt_TelFixe.Clear();
            txt_Port1.Clear();
            txt_Port2.Clear(); 
            txt_Email.Clear();           
            txt_UrlE.Clear();
            txt_UrlP.Clear();
            
        }



        }     
    }

