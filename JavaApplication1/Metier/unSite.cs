using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;
using System.IO;
using System.Globalization; 

namespace Metier
{
    public class unSite
    {
        #region Déclaration des variables + Setter / Getter + Constructeurs
        private string urlDep;
        private string codePostal;

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        
        public string UrlDep
        {
            get { return urlDep; }
            set { urlDep = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string region;
        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        private string departement;
        public string Departement
        {
            get { return departement; }
            set { departement = value; }
        }

        private string telFix;
        public string TelFix
        {
            get { return telFix; }
            set { telFix = value; }
        }

        private string portable1;
        public string Portable1
        {
            get { return portable1; }
            set { portable1 = value; }
        }

        private string portable2;
        public string Portable2
        {
            get { return portable2; }
            set { portable2 = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string urlP;
        public string UrlP
        {
            get { return urlP; }
            set { urlP = value; }
        }

        private string urlE;
        public string UrlE
        {
            get { return urlE; }
            set { urlE = value; }
        }        

        /// <summary>
        /// Constructeur vide la classe unSite
        /// </summary>
        public unSite()
        {

        }
        
        /// <summary>
        /// Constructeur de la classe unSite
        /// </summary>
        /// <param name="uneville"></param>
        /// <param name="region"></param>
        /// <param name="departement"></param>
        /// <param name="tf"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="email"></param>
        /// <param name="urlP"></param>
        /// <param name="urlE"></param>
        /// <param name="type"></param>
        public unSite(string uneville, string region, string departement, string telFix, string p1, string p2, string email,
            string urlP, string urlE, string type, string urlDep,string codepostal)
        {
            this.ville = uneville;
            this.region = region;
            this.departement = departement;
            this.telFix = telFix;
            this.portable1 = p1;
            this.portable2 = p2;
            this.email = email;
            this.urlP = urlP;
            this.urlE = urlE;
            this.type = type;
            this.urlDep = urlDep;
            this.codePostal = codepostal;
        }
        #endregion

        

        /// <summary>
        /// Méthode qui permet de générer un texte en prenant des synonymes aléatoirement et en insérant les données rentrées dans le formulaire
        /// </summary>
        /// <returns></returns>
        public String GenererTexteAixMarseille()
        {
            #region Synonymes et méthode aléatoire
            Random rand = new Random();
            int rndNumber = 0, rneffectuera = 0, rnenquête = 0, rnprivée = 0, rnprofessionnelle = 0, rninterets = 0, rnagisse = 0, rnjuridique = 0, rndunbesoin = 0, rnanalysera = 0,
            rndemande = 0, rnproposer = 0, rninvestigation = 0, rnjudicieuses = 0, rnquestion = 0, rnrenommée = 0, rnluioblige = 0, rnrecruter = 0, rnprofessionnels = 0, rnenquete = 0, rnpossédant = 0,
            rnminimum = 0, rnannee = 0, rnexpérience = 0, rnprofession = 0, rngérants = 0, rnSARL = 0, rnlicencié = 0, rnprestigieuse = 0, rnrecevront = 0, rnbureau = 0, rndeplaceron = 0, rnetudieront = 0,
            rnproposeront = 0, rnmandat = 0, rnbesoins = 0, rntiendra = 0, rnintervention = 0, rnrapport = 0, rnremis = 0, rnmandaaaaat = 0, rnfin = 0, rnrapporter = 0, rnentendu = 0, rnrecevable = 0,
            rnjustice = 0, rndefendre = 0, rnagggence = 0, rnpossédaant = 0, rnengager = 0, rnainsi = 0, rntout = 0, rnsibesoin = 0, rntentatives = 0, rndemandes = 0,
            rncouvrira = 0, rndemaaande = 0, rndroitfamilial = 0, rnadultere = 0, rnrecherchepersonne = 0, rnproceduredivorce = 0, rnoccuperont = 0, rnarret = 0, rntravailnoir = 0, rnaccident = 0,
            rnvol = 0, rndepuis = 0, rndeveloppe = 0, rnbeaucoupde = 0, rnmiseenrelation = 0, rnfiable = 0, rnpropose = 0,
            rnfilature = 0, rnenquete1 = 0, rnrealisee = 0, rnpourra = 0, rndenqueteur = 0, rnjuristes = 0, rninternationale = 0, rneffectue = 0, rnurgence = 0, rnclient = 0, rndinvestigation = 0;

            string[] agence =
            {
               "l'agence", "le cabinet", "la société", "la SARL"
            };
            string[] effectuera =
            {
               "effectuera", "accomplira", "realisera"
            };
            string[] enquête =
            {
               "enquête", "mission","investigation"

            };
            string[] privée =
            {
               "privée", "pour particulier", "particulier"

            };
            string[] professionnelle =
            {
               "professionnelle", "pour entreprise", "d'entreprise"

            };
            string[] interets =
            {
               "défendant ainsi vos intérêts", "afin de défendre vos intérêts", "préservant vos intérêts","afin de préserver vos droits","défendant vos droits"

            };
            string[] agisse =
            {
               "Qu’il s’agisse", "Que vous ayez besoin"
            };
            string[] juridique =
            {
               "pour la Justice", "pour les tribunaux","pour le tribunal"
            };
            string[] dunbesoin =
            {
               "d’un simple besoin ", "d’un unique manque","d’une simple nécessité","d’une unique nécessité"
            };
            string[] analysera =
            {
               "analysera", "traitera","étudiera","examinera"
            };
            string[] demande =
            {
               "demande", "requête","sollicitation"
            };
            string[] proposer =
            {
               "proposer", "offrir","conseiller","soumettre","suggérer"
            };
            string[] investigation =
            {
               "investigations", "enquêtes","interventions"
            };
            string[] judicieuses =
            {
               "appropriées", "adaptées","pertinentes"
            };
            string[] question =
            {
               "demande", "question","investigation","enquête"
            };
            string[] renommée =
            {
               "renommée", "notoriété","réputation"
            };
            string[] luioblige =
            {
               "lui oblige", "lui impose","la contraint"
            };
            string[] recruter =
            {
               "recruter", "embaucher","utiliser","engager","enrôler"
            };
            string[] professionnels =
            {
               "professionnels", "spécialistes","experts","agents"
            };
            string[] enquete =
            {
               "l'enquête", "l’investigation"
            };
            string[] possédant =
            {
               "possédant", "ayant acquis","détenant","disposant d'","titulaire d'"
            };
            string[] minimum =
            {
               "un minimum de", "au moins"
            };
            string[] annee =
            {
               "dix ans", "dix années"
            };
            string[] expérience =
            {
               "d’expérience", "de pratique","de connaissance"
            };
            string[] profession =
            {
               "profession ", "fonction d’agent de recherche","fonction d’agent de recherche privée"
            };
            string[] gérants =
            {
               "gérants", "dirigeants","directeurs"
            };
            string[] SARL =
            {
               " de la SARL ", " de la société "," de l’agence "," du cabinet "," du bureau d’investigations "
            };
            string[] licencié =
            {
               "licenciés", "titulaires d’une licence","détenteurs d’une licence"
            };
            string[] prestigieuse =
            {
               "prestigieuse", "célèbre"
            };
            string[] recevront =
            {
               "inviteront", "convieront","accueilleront","réceptionneront"
            };
            string[] bureau =
            {
               "bureau", "cabinet","établissement"
            };
            string[] deplaceron =
            {
               "ou se déplaceront pour vous rencontrer", "ou viendront à votre rencontre","ou vous fixeront un rendez-vous extérieur"
            };
            string[] etudieront =
            {
               "étudieront", "analyseront","liront avec attention","approfondiront"
            };
            string[] proposeront =
            {
               "proposeront", "suggéreront","soumettront"
            };
            string[] mandat =
            {
               "mandat", "contrat","contrat de mandat","mandat d’investigations","mandat d’enquête","mandat d’intervention"
            };
            string[] besoins =
            {
               "vos besoins", "votre demande","votre requête"
            };
            string[] tiendra =
            {
               "vous tiendra informé ", "vous fera un bilan oral","effectuera avec vous un compte-rendu détaillé","vous communiquera un compte-rendu"
            };
            string[] intervention =
            {
               "intervention", "journée d’investigation","journée d’enquête","jour de mission"
            };
            string[] rapport =
            {
               "rapport de constatations écrites et photographiques", "compte-rendu écrit et photo","compte-rendu précis et photographiques","rapport circonstancié et photographiques","rapport écrit et photographique"
            };
            string[] remis =
            {
               "remis", "fournis","communiqué","transmis","confié","apporté"
            };
            string[] mandaaaaat =
            {
               "mandat", "client"
            };
            string[] fin =
            {
               "à la fin", "à l’issu","au terme","après l’aboutissement"
            };
            string[] rapporter =
            {
               "Ce rapport", "Ce compte-rendu","Ce bilan","Ce rapport de constatation","Ce compte-rendu circonstancié",
            };
            string[] entendu =
            {
               "bien entendu", "assurément","évidemment"
            };
            string[] recevable =
            {
               "recevable", "reçu","accepté","pris en compte"
            };
            string[] justice =
            {
               "devant tous les tribunaux de la Justice française ", "tout tribunal","le Tribunal","la Justice"
            };
            string[] defendre =
            {
               "défendre", "protéger","faire valoir", "préserver", "faire entendre"
            };
            string[] agggence =
            {
               "l’agence","le cabinet"," le bureau","la SARL"
            };
            string[] possédaant =
            {
               "possédant", "ayant acquis","détenant de","disposant de","jouissant de"
            };
            string[] engager =
            {
               "s’engagent à respecter le", "garantissent le respect  du","respecteront le"
            };
            string[] ainsi =
            {
               "ainsi que" ,"tout comme", "mais également"
            };
            string[] tout =
            {
               "Tout rapport d’enquête" ,"Toute constatation", "Tout rapport d’investigation", " constatation d’enquête, Toute preuve recueillie"
            };
            string[] sibesoin =
            {
               "si besoin", "si besoin est", "si nécessaire", "en cas de nécessité"
            };
            string[] tentatives =
            {
               "tentatives", "essais", "démarches"
            };
            string[] demandes =
            {
               "demandes" ,"procédures", "discussions", "négociations"
            };
            string[] couvrira =
            {
               "couvrira", "interviendra pour"
            };

            string[] demaaande =
            {
               "demande", "requête"
            };
            string[] droitfamilial =
            {
               "Droit famalial", "Droit de la famille"
            };
            string[] adultere =
            {
               "Adultère", "infifélité", "relation adultérine"
            };
            string[] recherchepersonne =
            {
               "de personne", "d'adresse", "d'individu"
            };
            string[] proceduredivorce =
            {
               "procédure de divorce", "divorces", "sépartion", "séparations"
            };
            string[] occuperont =
            {
               "s'occuperont", "traiteront"
            };
            string[] arret =
            {
               "arrêt", "arrêts"
            };
            string[] travailnoir =
            {
               "travail au noir", "travail clandestin", "travail dissimulé"
            };
            string[] accident =
            {
               "accident", "accidents"
            };
            string[] vol =
            {
               "vol", "cambriolage"
            };
            string[] depuis =
            {
               "Depuis", "Durant", "Pendant"
            };
            string[] developpe =
            {
               "développé", "engendré", "accumulé", "atteint"
            };
            string[] beaucoupde =
            {
               "beaucoup de", "nombres de", "de nombreux"
            };
            string[] miseenrelation =
            {
               "une mise en relation avec", "une mise en contact avec", "une présentation d'", "une mise en liaison avec"
            };
            string[] fiable =
            {
               "fiable", "reconnu", "sérieux", "partenaire"
            };
            string[] propose =
            {
               "proposés", "présentés", "soumis", "offerts", "suggérés"
            };
            string[] filature =
            {
               "filature", "surveillance"
            };
            string[] enquete1 =
            {
               "enquête", "investigation", "mission"
            };
            string[] realisee =
            {
               "réalisée", "traitée"
            };
            string[] pourra =
            {
               "pourra faire appel à", "appeler", "mandater", "mettre à contribution"
            };
            string[] denqueteur =
            {
               "d'enquêteurs", "d'agents de recherche", "d'agents", "de détectives", "de détectives privés"
            };
            string[] juristes =
            {
               "de juristes", "d'experts juridiques"
            };
            string[] internationale =
            {
               "internationale", "à l'étranger", "en dehors des frontières", "extérieures à la France"
            };
            string[] effectue =
            {
               "effectuer", "traiter"
            };
            string[] urgence =
            {
               "dans l'urgence", "urgemment"
            };
            string[] client =
            {
               "clients", "mandants"
            };
            string[] dinvestigation =
            {
               "d'investigation", "d'enquête", "de mission"
            };
            rndNumber = rand.Next(0, agence.Length);
            rneffectuera = rand.Next(0, effectuera.Length);
            rnenquête = rand.Next(0, enquête.Length);
            rnprofessionnelle = rand.Next(0, professionnelle.Length);
            rnprivée = rand.Next(0, privée.Length);
            rnagisse = rand.Next(0, agisse.Length);
            rnjuridique = rand.Next(0, juridique.Length);
            rndunbesoin = rand.Next(0, dunbesoin.Length);
            rnanalysera = rand.Next(0, analysera.Length);
            rndemande = rand.Next(0, demande.Length);
            rnproposer = rand.Next(0, proposer.Length);
            rninvestigation = rand.Next(0, investigation.Length);
            rnjudicieuses = rand.Next(0, judicieuses.Length);
            rnquestion = rand.Next(0, question.Length);
            rnrenommée = rand.Next(0, renommée.Length);
            rnluioblige = rand.Next(0, luioblige.Length);
            rninterets = rand.Next(0, interets.Length);
            rnrecruter = rand.Next(0, recruter.Length);
            rnprofessionnels = rand.Next(0, professionnels.Length);
            rnenquete = rand.Next(0, enquete.Length);
            rnpossédant = rand.Next(0, possédant.Length);
            rnminimum = rand.Next(0, minimum.Length);
            rnannee = rand.Next(0, annee.Length);
            rnexpérience = rand.Next(0, expérience.Length);
            rnprofession = rand.Next(0, profession.Length);
            rngérants = rand.Next(0, gérants.Length);
            rnSARL = rand.Next(0, SARL.Length);
            rnlicencié = rand.Next(0, licencié.Length);
            rnprestigieuse = rand.Next(0, prestigieuse.Length);
            rnrecevront = rand.Next(0, recevront.Length);
            rnbureau = rand.Next(0, bureau.Length);
            rndeplaceron = rand.Next(0, deplaceron.Length);
            rnetudieront = rand.Next(0, etudieront.Length);
            rnproposeront = rand.Next(0, proposeront.Length);
            rnbesoins = rand.Next(0, besoins.Length);
            rntiendra = rand.Next(0, tiendra.Length);
            rnintervention = rand.Next(0, intervention.Length);
            rnrapport = rand.Next(0, rapport.Length);
            rnremis = rand.Next(0, remis.Length);
            rnmandaaaaat = rand.Next(0, mandaaaaat.Length);
            rnfin = rand.Next(0, fin.Length);
            rndemandes = rand.Next(0, demandes.Length);
            rntentatives = rand.Next(0, tentatives.Length);
            rntentatives = rand.Next(0, tentatives.Length);
            rnsibesoin = rand.Next(0, sibesoin.Length);
            rntout = rand.Next(0, tout.Length);
            rnainsi = rand.Next(0, ainsi.Length);
            rnengager = rand.Next(0, engager.Length);
            rnfin = rand.Next(0, fin.Length);
            rnintervention = rand.Next(0, intervention.Length);
            rnrapporter = rand.Next(0, rapporter.Length);
            rnentendu = rand.Next(0, entendu.Length);
            rnrecevable = rand.Next(0, recevable.Length);
            rnjustice = rand.Next(0, justice.Length);
            rndefendre = rand.Next(0, defendre.Length);
            rnagggence = rand.Next(0, agggence.Length);
            rnpossédaant = rand.Next(0, possédaant.Length);
            rnmandat = rand.Next(0, mandat.Length);
            rncouvrira = rand.Next(0, couvrira.Length);
            rndemaaande = rand.Next(0, demaaande.Length);
            rndroitfamilial = rand.Next(0, droitfamilial.Length);
            rnadultere = rand.Next(0, adultere.Length);
            rnrecherchepersonne = rand.Next(0, recherchepersonne.Length);
            rnproceduredivorce = rand.Next(0, proceduredivorce.Length);
            rnoccuperont = rand.Next(0, occuperont.Length);
            rnarret = rand.Next(0, arret.Length);
            rntravailnoir = rand.Next(0, travailnoir.Length);
            rnaccident = rand.Next(0, accident.Length);
            rnvol = rand.Next(0, vol.Length);
            rndepuis = rand.Next(0, depuis.Length);
            rndeveloppe = rand.Next(0, developpe.Length);
            rnbeaucoupde = rand.Next(0, beaucoupde.Length);
            rnmiseenrelation = rand.Next(0, miseenrelation.Length);
            rnfiable = rand.Next(0, fiable.Length);
            rnpropose = rand.Next(0, propose.Length);
            rnfilature = rand.Next(0, filature.Length);
            rnenquete1 = rand.Next(0, enquete1.Length);
            rnrealisee = rand.Next(0, realisee.Length);
            rnpourra = rand.Next(0, pourra.Length);
            rndenqueteur = rand.Next(0, denqueteur.Length);
            rnjuristes = rand.Next(0, juristes.Length);
            rninternationale = rand.Next(0, internationale.Length);
            rneffectue = rand.Next(0, effectue.Length);
            rnurgence = rand.Next(0, urgence.Length);
            rnclient = rand.Next(0, client.Length);
            rndinvestigation = rand.Next(0, dinvestigation.Length);
            #endregion
            // zone de texte
            #region Texte à trou pour INVESTIPOLE
            string text = "\n";
            text = text + "<h1>Détective Privé à " + Ville + " (" + CodePostal + ")</h1>\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "Détective Privé à " + Ville + " (" + CodePostal + ") en " + region + ", " + agence[rndNumber] +
            " INVESTIPOLE " + effectuera[rneffectuera] + " pour vous toute " + enquête[rnenquête] + " <a href=\"" + urlE + "\">" + professionnelle[rnprofessionnelle] + "</a> et <a href=\"" + urlP + "\">"
            + privée[rnprivée] + "</a>" +
            ", " + interets[rninterets] + ". " + agisse[rnagisse] + " de preuves juridiques " + juridique[rnjuridique] + " ou " + dunbesoin[rndunbesoin] +
            " d'information, INVESTIPOLE détective " + ville + " (" + CodePostal + ") " + analysera[rnanalysera] + " toute " + demande[rndemande] +
            " morale, légale et légitime afin de vous " + proposer[rnproposer] + " les " + investigation[rninvestigation] + " les plus " + judicieuses[rnjudicieuses] + ".\n";
            text = text + "<br />\n";
            text = text + "Les détectives de l’Agence INVESTIPOLE interviendront à " + Ville + " (" + CodePostal + ") pour toute " + question[rnquestion] +
            " relative au droit de la famille, droit commercial et droit du travail, que vous soyez " + " <a href=\"" + urlE + "\">une entreprise</a> , <a href=\"" + UrlP + "\">un particulier</a> ou un avocat.";
            text = text + " La " + renommée[rnrenommée] + " d’INVESTIPOLE Détective à " + Ville + " (" + CodePostal + ") " + luioblige[rnluioblige] + " à avoir à " +
            recruter[rnrecruter] + " des " + professionnels[rnprofessionnels] + " de " + enquete[rnenquete] + " " + possédant[rnpossédant] + " " + minimum[rnminimum] + " " + annee[rnannee] + " " + expérience[rnexpérience] +
            " dans la " + profession[rnprofession] + ".";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "<div class=\"icone\"> \n"; text = text + "</div>\n";
            text = text + "<div class=\"htrois\">";
            text = text + "<h3>Déroulement.</h3>\n";
            text = text + "<span class=\"underline\"></span>\n";
            text = text + "</div>\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "Les deux " + gérants[rngérants] + SARL[rnSARL] + "INVESTIPOLE détective " + ville + " (" + CodePostal + "), " + licencié[rnlicencié] + " de Droit et diplômés de la " +
            prestigieuse[rnprestigieuse] + " IFAR (Institut de formation des Agents de Recherche) à Montpellier, vous " + recevront[rnrecevront] + " dans leur " + bureau[rnbureau] + " " + deplaceron[rndeplaceron] + "," +
            " " + etudieront[rnetudieront] + " votre dossier, et vous " + proposeront[rnproposeront] + " un " + mandat[rnmandat] + " adapté à " + besoins[rnbesoins] + ".\n";
            text = text + "<br />\n";
            text = text + "INVESTIPOLE " + tiendra[rntiendra] + " après chaque " + intervention[rnintervention] + ".\n";
            text = text + "<br />\n";
            text = text + "Un " + rapport[rnrapport] + " sera " + remis[rnremis] + " à chaque " + mandaaaaat[rnmandaaaaat] + " d'INVESTIPOLE Détective à " + Ville + " (" + CodePostal + "), " +
            fin[rnfin] + " des " + intervention[rnintervention] + ". " + rapporter[rnrapporter] + " sera " + entendu[rnentendu] + " " + recevable[rnrecevable] + " devant " + justice[rnjustice] + ", afin de " + defendre[rndefendre] +
            " vos droits, " + agggence[rnagggence] + " INVESTIPOLE " + possédaant[rnpossédaant] + " son agrément CNAPS.\n";
            text = text + "<br />\n";
            text = text + "Les détectives privés INVESTIPOLE à " + Ville + " (" + CodePostal + ") " + engager[rnengager] + " code de déontologie de la profession " + ainsi[rnainsi] + " leur secret professionnel.";
            text = text + "<br />\n";
            text = text + tout[rntout] + " pourra, " + sibesoin[rnsibesoin] + ", servir à vos " + tentatives[rntentatives] + " de conciliations, ou " + demandes[rndemandes] + " à l'amiable.\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "<div class=\"icone\"> \n";
            text = text + "</div>\n";
            text = text + "<div class=\"htrois\">";
            text = text + "<h3>Domaines d’intervention.</h3>\n";
            text = text + "<span class=\"underline\"></span>\n";
            text = text + "</div>\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "INVESTIPOLE " + couvrira[rncouvrira] + "<a href=\"" + urlP + "\"> toute " + demaaande[rndemaaande] + " privée et relative au " + droitfamilial[rndroitfamilial] + " </a>" +
            " (" + adultere[rnadultere] + ", recherche " + recherchepersonne[rnrecherchepersonne] + ", " + proceduredivorce[rnproceduredivorce] + " ...).\n";
            rndemaaande = rand.Next(0, demaaande.Length);
            text = text + "Les détectives " + occuperont[rnoccuperont] + " également" +
            "<a href=\"" + urlE + "\"> de toute " + demaaande[rndemaaande] + " professionnelle </a>" + arret[rnarret] + " maladie fauduleux, " +
            travailnoir[rntravailnoir] + ", " + accident[rnaccident] + " du travail, " + vol[rnvol] + ", concurrence déloyale...).\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "<div class=\"icone\"> \n";
            text = text + "</div>\n";
            text = text + "<div class=\"htrois\">";
            text = text + "<h3>Gage de fiabilité.</h3>\n";
            text = text + "<span class=\"underline\"></span>\n";
            text = text + "</div>\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            rndemaaande = rand.Next(0, demaaande.Length);
            text = text + depuis[rndepuis] + " plus de dix ans, INVESTIPOLE Détective à " + Ville + " (" + CodePostal + ") a " + developpe[rndeveloppe] +
            " une expérience reconnue sur la région " + Region + " par " + beaucoupde[rnbeaucoupde] + " juristes et avocats. Un suivi juridique, ainsi qu'" +
            miseenrelation[rnmiseenrelation] + " un avocat " + fiable[rnfiable] + " pourront être " + propose[rnpropose] + " pour tout dossier si le client en fait la " +
            demaaande[rndemaaande] + ".\n";
            text = text + "<br />\n";
            text = text + "<div class=\"icone\"> \n";
            text = text + "</div>\n";
            text = text + "<div class=\"htrois\">";
            text = text + "<h3>Disponibilités.</h3>\n";
            text = text + "<span class=\"underline\"></span>\n";
            text = text + "</div>\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "Toute " + filature[rnfilature] + " ou " + enquete1[rnenquete] + " pourra être " + realisee[rnrealisee] + " par un détective privé INVESTIPOLE à " + Ville + " (" + CodePostal + ") 7J/7J, 24H/24H.\n";
            text = text + "<br />\n";
            text = text + "La SARL INVESTIPOLE détective " + Ville + " (" + CodePostal + ") pourra " + pourra[rnpourra] + " son solide réseau " +
                denqueteur[rndenqueteur] + " et " + juristes[rnjuristes] + " pour toute demande " + internationale[rninternationale] + " à " +
                effectue[rneffectue] + " " + urgence[rnurgence] + ".\n";
            text = text + "<br />\n";
            text = text + "Enfin, INVESTIPOLE Détective " + Ville + " (" + CodePostal + ") demandera à tous ses " + client[rnclient] + " de respecter le cadre légal, moral et légitime dans leur demande " + dinvestigation[rndinvestigation] + ".\n";
            text = text + "<br />\n";
            text = text + "N’hésitez pas à nous joindre par téléphone, ou à nous laisser vos coordonnées par email, afin que l’un des deux gérants vous rappelle.\n";
            text = text + "<br />\n";
            text = text + "<br />\n";
            text = text + "<br />\n";

            return text;
            #endregion
        }
       
        

        /// <summary>
        /// Méthode permet de générer un Titre en fonction des données entrées précédement dans le formulaire (Ville + département)
        /// </summary>
        /// <returns></returns>
        public String GenererTitreAixMarseille()
        {
            String titre = "Détective privé ";
            titre = titre + Ville + " " + CodePostal;

            return titre;
        }


//METHODES CONCERNANT LA BALISE SEO

        /// <summary>
        /// Méthode permet de générer des mots clés en fonction des données entrées précédement dans le formulaire (Ville + département)
        /// </summary>
        /// <returns></returns>
        public String GenererMotCle()
        {
            string motClé = "détective " + Ville + " " + CodePostal + ", détective privé " + Ville + " " + CodePostal + ", détectives " + Ville + " " + CodePostal +
                ", détectives privés " + Ville + " " + CodePostal + ", adultère " + Ville + " " + CodePostal + ", arrêt maladie " + Ville + " " + CodePostal +
                ", détective " + Ville + " " + CodePostal + ", enquête à " + Ville + " " + CodePostal + ", divorce " + Ville + " " + CodePostal + ", avocat " + Ville + " " + CodePostal;
            return motClé;
        }

     
        /// <summary>
        /// Méthode permet de générer le titre google en fonction des données entrées précédement dans le formulaire (Ville + département)
        /// </summary>
        /// <returns></returns>
        public String GenererTitreSEOInvestipole()
        {
            string titreSeo = "Détective privé à " + Ville + " " + CodePostal + " - INVESTIPOLE";
            return titreSeo;
        }
        
        /// <summary>
        /// Méthode permet de générer la description google en fonction des données entrées précédement dans le formulaire (Ville + département)
        /// </summary>
        /// <returns></returns>
        public String GenererMetaDesc()
        {
            string metaDesc = "Cabinet de détective privé à " + Ville + " " + CodePostal + ". Enquêtes pour particuliers et entreprises. Devis et appel gratuit. Divorces, filatures, rapports juridiques...";
            return metaDesc;
        }
        
        /// <summary>
        /// Permet de générer un fichier stockant les balises liens
        /// </summary>
        /// <returns></returns>
        public static string RemoveDiacritics(string input)
        {
            string formD = input.Normalize(NormalizationForm.FormD);
            StringBuilder sbNoDiacritics = new StringBuilder();
            foreach (char c in formD)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sbNoDiacritics.Append(c);
            }
            string noDiacritics = sbNoDiacritics.ToString().Normalize(NormalizationForm.FormC);
            return noDiacritics;
        }
        
        /// <summary>
        /// Méthode permettant de supprimer les accents, apostrophes et majuscules et des remplacer les espaces par des tirés afin de créer le lien de la page en question.
        /// Ce lien s'ajoutera dans un fichier .txt (créer préalablement) lors de chaque méthode "Générer()"
        /// </summary>
        /// <returns></returns>
        public String GenererLienInt()
        {
            string lienInt = "";
            string villeLien = RemoveDiacritics(Ville);
            villeLien = villeLien.Replace(' ', '-');
            villeLien = villeLien.Replace("\'", "");
            villeLien = villeLien.ToLower();
            // Attention le liens pourrai changer
            lienInt = "<li><a title=\"Détective à " + Ville + " " + CodePostal + "\" href=\""+urlDep +"detective-prive-" + villeLien + "-" + CodePostal + "\">Détective à " + Ville + " " + CodePostal + "</a></li>";
            
            
            return (lienInt);
        }
        public String GenererLienVille(string titre)
        {
            string lienInt = "";
            string lienDep=RemoveDiacritics(Departement);
            string lienAccu=RemoveDiacritics(titre);
            string villeLien = RemoveDiacritics(Ville);
            villeLien = villeLien.Replace(' ', '-');
            villeLien = villeLien.Replace("\'", "");
            villeLien = villeLien.ToLower();
             lienDep = lienDep.Replace(' ', '-');
            lienDep = lienDep.Replace("\'", "");
            lienDep = lienDep.ToLower();
             lienAccu = lienAccu.Replace(' ', '-');
            lienAccu = lienAccu.Replace("\'", "");
            lienAccu = lienAccu.ToLower();
            lienInt = "http://localhost/www.detectivemarseille.fr/" + lienAccu + "/zone-dintervention/" + lienDep + "/detective-prive-" + villeLien + "-" + CodePostal;
            return (lienInt);
        }
        public String GenererLienName(string titre)
        {
            
            string lienAccu = RemoveDiacritics(titre);
            
            
            lienAccu = lienAccu.Replace(' ', '-');
            lienAccu = lienAccu.Replace("\'", "");
            lienAccu = lienAccu.ToLower();

            return (lienAccu);
        }
        public String GenererLienDep(string titre)
        {
            string lienInt = "";
            string lienDep = RemoveDiacritics(Departement);
            string lienAccu = RemoveDiacritics(titre);
            string villeLien = RemoveDiacritics(Ville);
            villeLien = villeLien.Replace(' ', '-');
            villeLien = villeLien.Replace("\'", "");
            villeLien = villeLien.ToLower();
            lienDep = lienDep.Replace(' ', '-');
            lienDep = lienDep.Replace("\'", "");
            lienDep = lienDep.ToLower();
            lienAccu = lienAccu.Replace(' ', '-');
            lienAccu = lienAccu.Replace("\'", "");
            lienAccu = lienAccu.ToLower();
            lienInt = "http://localhost/www.detectivemarseille.fr/" + lienAccu + "/zone-dintervention/" + lienDep;
            return (lienInt);
        }
    }
}
