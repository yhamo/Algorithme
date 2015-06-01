using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;

namespace Metier
{
    public class Bdd
    {
        private MySqlConnection connection;
        

        // Constructeur
        public Bdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=detectivemarseille; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        // Méthode pour ajouter un contact
        public void AddPage(unePage unePage)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO wp_posts ( post_author, post_date,post_date_gmt,post_content,post_title,post_excerpt,post_status,comment_status,ping_status,post_password,post_name,to_ping,pinged,post_modified,post_modified_gmt,post_content_filtered,post_parent,guid,menu_order,post_type,post_mime_type,comment_count) VALUES (@author,@date,@dateGmt,@content,@title,@excerpt,@status,@commentStatus,@pingStatus,@passWord,@name,@toPing,@pinged,@modified,@modifiedsGmt,@contentFiltered,@parent,@guid,@menuOrder,@type,@mimeType,@count);";
                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@author", unePage.Author);
                cmd.Parameters.AddWithValue("@date", unePage.Date);
                cmd.Parameters.AddWithValue("@dateGmt", unePage.DateGmt);
                cmd.Parameters.AddWithValue("@content", unePage.Content);
                cmd.Parameters.AddWithValue("@title", unePage.Title);
                cmd.Parameters.AddWithValue("@excerpt", unePage.Excerpt);
                cmd.Parameters.AddWithValue("@status", unePage.Status);
                cmd.Parameters.AddWithValue("@commentStatus", unePage.CommentStatus);
                cmd.Parameters.AddWithValue("@pingStatus", unePage.PingStatus);
                cmd.Parameters.AddWithValue("@passWord", unePage.Password);
                cmd.Parameters.AddWithValue("@name", unePage.Name);
                cmd.Parameters.AddWithValue("@toPing", unePage.ToPing);
                cmd.Parameters.AddWithValue("@pinged", unePage.Pinged);
                cmd.Parameters.AddWithValue("@modified", unePage.Modified);
                cmd.Parameters.AddWithValue("@modifiedsGmt", unePage.ModifiedGtm);
                cmd.Parameters.AddWithValue("@contentFiltered", unePage.ContentFiltered);
                cmd.Parameters.AddWithValue("@parent", unePage.Parent);
                cmd.Parameters.AddWithValue("@guid", unePage.Guid);
                cmd.Parameters.AddWithValue("@menuOrder", unePage.MenuOrder);
                cmd.Parameters.AddWithValue("@type", unePage.Type);
                cmd.Parameters.AddWithValue("@mimeType", unePage.MineType);
                cmd.Parameters.AddWithValue("@count", unePage.Count);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();
            }

            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si la page à été ajouté correctement.
            }
        }
        public void SearchPostId(Seo unSeo, unSite unsite)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();
                
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();
                
                // Requête SQL
                cmd.CommandText = "SELECT id FROM wp_posts WHERE post_title='" + unsite.GenererTitreAixMarseille() + "' AND post_status =  'publish'; ";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    unSeo.Post_id = (reader["ID"].ToString());

                }

                reader.Close();
                connection.Close();


            }
            catch
            {

            }
        }
        public void SearchPostIdDep(Seo unSeo, string TitreDep)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT id FROM wp_posts WHERE post_title='" + TitreDep + "' AND post_status =  'publish'; ";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    unSeo.Post_id = (reader["ID"].ToString());

                }

                reader.Close();
                connection.Close();


            }
            catch
            {

            }
        }
        public void AddSeo(Seo unSeo)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();
                // Requête SQL
                cmd.CommandText = "INSERT INTO wp_postmeta (post_id, meta_key ,meta_value ) VALUES (@post,@key,@value) ";
               
                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@post", unSeo.Post_id);
                cmd.Parameters.AddWithValue("@key", unSeo.Meta_key);
                cmd.Parameters.AddWithValue("@value", unSeo.Meta_value);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();
            }

            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si la page à été ajouté correctement.
            }
        }
        public void AddBalise(String parametre,String Balise )
        {
            try
            {
                string valeur = "";
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();
                // Requête SQL
                cmd.CommandText = "SELECT post_content FROM wp_posts WHERE ID='"+parametre+"'";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    valeur=((reader["post_content"].ToString()));

                }
                // Fermeture de la connexion
                this.connection.Close();
                addinsertBAlise(valeur,parametre,Balise);
                
            }

            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si la page à été ajouté correctement.
            }
        }
        public void addinsertBAlise(String valeur, String parametre, string Balise)
        {
            try
            {

                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();
                valeur=valeur.Replace("</ul>","");
                cmd.CommandText = "UPDATE wp_posts SET post_content='" + valeur + " " + Balise + "' WHERE  ID='" + parametre + "'";



                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                // Fermeture de la connexion
                this.connection.Close();
            }
            catch { }
        }

        
        public List<Object> GenererCB()
        {
            try
            {
                List<Object> Departement = new List<Object>();
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();
                // Requête SQL
                cmd.CommandText = "SELECT post_title FROM wp_posts WHERE id NOT  IN ( SELECT id FROM wp_posts WHERE post_title LIKE  '%privé%' )AND post_title LIKE  'Détective%' AND post_status='publish' ";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    Departement.Add((reader["post_title"].ToString()));

                }

                reader.Close();
                connection.Close();
                return Departement;
            }
            catch
            {
                 List < Object > vide = new List<Object>();
                return vide;
            }
            
            
        }
        public string GenrerIdParentZoneIntervention()
        {
            try
            {
                string valeur = "";
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT id FROM wp_posts WHERE post_title='Zone d\\'intervention' AND post_status =  'publish'; ";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    valeur = (reader["ID"].ToString());

                }
                
                reader.Close();
                connection.Close();
                return valeur;

            }
            catch
            {
               return "Une erreur c'est produite lors de la methode GenrerIdParent()";
            }
        }
        public string GenrerIdParentVille(string nomDep)
        {
            try
            {
                string valeur = "";
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT id FROM wp_posts WHERE post_title='" + nomDep + "' AND post_status =  'publish'; ";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    valeur = (reader["ID"].ToString());

                }

                reader.Close();
                connection.Close();
                return valeur;

            }
            catch
            {
                return "Une erreur c'est produite lors de la methode GenrerIdParent()";
            }
        }
        public string GenrerIdTitreSite()
        {
            try
            {
                string valeur = "";
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT post_title FROM wp_posts WHERE post_title LIKE  'Détective privé%' AND post_parent='0' ";
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // If you're expecting only one line, change this to if(reader.Read()).
                {


                    valeur = (reader["post_title"].ToString());

                }

                reader.Close();
                connection.Close();
                return valeur;

            }
            catch
            {
                return "Une erreur c'est produite lors de la methode GenrerIdParent()";
            }
        }
    }
}
