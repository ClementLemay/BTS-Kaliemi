using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace InterfaceUser
{
    class Model
    {
        public static ppe4Entities maConnexion;

        public static void init()
        {
            maConnexion = new ppe4Entities();
        }
        public static bool connexionWebService(string login, string mdp)
        {
            bool vretour = false;
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + mdp + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);


            try
            {
                string responseFromServer = reader.ReadToEnd();
                JObject JsonLogin = JObject.Parse(responseFromServer);

                string nom = JsonLogin["nom"].ToString();
                string prenom = JsonLogin["prenom"].ToString();

                if (nom != "" && prenom != "")
                {
                    vretour = true;

                    int id = int.Parse(JsonLogin["id"].ToString());
                    string sexe = JsonLogin["sexe"].ToString();
                    DateTime date_naiss = new DateTime();
                    date_naiss = Convert.ToDateTime(JsonLogin["date_naiss"].ToString());
                    string ad1 = JsonLogin["ad1"].ToString();
                    string ad2 = JsonLogin["ad2"].ToString();
                    int cp = int.Parse(JsonLogin["cp"].ToString());
                    string ville = JsonLogin["ville"].ToString();
                    string tel_fixe = JsonLogin["tel_fixe"].ToString();
                    string tel_port = JsonLogin["tel_port"].ToString();
                    string mail = JsonLogin["mail"].ToString();

                    insertPersonne(id, nom, prenom, sexe, date_naiss, ad1, ad2, cp, ville, tel_fixe, tel_port, mail);
                    insertPersonne_Login(id, login, mdp);
                    insertInfirmiere(id);
                }
            }
            catch (Exception) { }

            return vretour;
        }

        public static bool connexionLocal(string login, string mdp)
        {
            string mdpMD5 = toMD5(mdp);
            bool vretour = false;
            try
            {
                var LQuery = maConnexion.personne_login.ToList()
                                .Where(x => x.login == login)
                                .Where(x => x.mp == mdpMD5)
                                .Select(x => new { x.login });
                foreach (var v in LQuery)
                {
                    if(v.login == login)
                    {
                        vretour = true;
                    }
                    
                }
            }
            catch (Exception)
            {

            }
            return vretour;
        }
        /// 
        /// 
        /// Methodes de type GET
        /// 
        /// 

        public static string GetNomPersonneFromId(int id)
        {
            string vretour = "";
            var LQuery = maConnexion.personne.ToList()
                           .Where(x => x.id == id)
                           .Select(x => new { x.nom });
            foreach (var v in LQuery)
            {
                vretour = v.nom.ToString();
            }
            return vretour;
        }

        public static string GetPrenomPersonneFromId(int id)
        {
            string vretour = "";
            var LQuery = maConnexion.personne.ToList()
                           .Where(x => x.id == id)
                           .Select(x => new { x.prenom });
            foreach (var v in LQuery)
            {
                vretour = v.prenom.ToString();
            }
            return vretour;
        }

        public static string GetLoginPersonneFromId(int id)
        {
            string vretour = "";
            var LQuery = maConnexion.personne_login.ToList()
                           .Where(x => x.id == id)
                           .Select(x => new { x.login });
            foreach (var v in LQuery)
            {
                vretour = v.login.ToString();
            }
            return vretour;
        }
        public static List<patient> GetPatientFromId(int id)
        {
            List<patient> vretour = new List<patient>();
            var LQuery = maConnexion.patient.ToList()
                           .Where(x => x.id == id);

            return vretour;
        }

        public static List<personne> GetPersonneFromId(int id)
        {
            List<personne> vretour = new List<personne>();
            var LQuery = maConnexion.personne.ToList()
                           .Where(x => x.id == id);

            return vretour;
        }

        public static int GetIdPersonneFromLogin(string login)
        {
            int vretour = 0;
            var LQuery = maConnexion.personne_login.ToList()
                           .Where(x => x.login == login)
                           .Select(x => new { x.id });
            foreach (var v in LQuery)
            {
                vretour = int.Parse(v.id.ToString());
            }
            return vretour;
        }

        public static int GetIdVisite(int idInfirmiere)
        {
            int vretour = maConnexion.visite.ToList()
                            .Select(x => new { x.id })
                            .Count();
            vretour += 1;
            return vretour;
        }

        public static string GetAdresseComplete(string nom)
        {
            string vretour = "";
            var LQuery = maConnexion.personne.ToList()
                            .Where(x => x.nom == nom)
                            .Select(y => new { y.ad1, y.cp, y.ville });
            foreach (var x in LQuery)
            {
                vretour = x.cp + "+" + x.ad1 + "+" + x.ville;
                vretour = vretour.Replace(" ", "+");
            }
            return vretour;
        }
        public static string GetCodePostale(string nom)
        {
            string vretour = "";
            var LQuery = maConnexion.personne.ToList()
                            .Where(x => x.nom == nom)
                            .Select(y => new { y.cp });
            foreach (var x in LQuery)
            {
                vretour = x.cp.ToString();
            }
            return vretour;
        }
        public static string GetVille(string nom)
        {
            string vretour = "";
            var LQuery = maConnexion.personne.ToList()
                            .Where(x => x.nom == nom)
                            .Select(y => new { y.ville });
            foreach (var x in LQuery)
            {
                vretour = x.ville;
            }
            return vretour;
        }

        public static string GetAdresse(string nom)
        {
            string vretour = "";
            var LQuery = maConnexion.personne.ToList()
                            .Where(x => x.nom == nom)
                            .Select(y => new { y.ad1 });
            foreach (var x in LQuery)
            {
                vretour = x.ad1;
            }
            return vretour;
        }

        public static List<string> GetListNomPersonne()
        {
            List<string> vretour = new List<string>();
            var LQuery = maConnexion.personne.ToList()
                            .Select(x => new { x.nom });
            foreach (var v in LQuery)
            {
                vretour.Add(v.nom.ToString());
            }
            return vretour;
        }

        public static List<string> GetListIdVisite(int idInfirmiere)
        {
            List<string> vretour = new List<string>();
            var LQuery = maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == idInfirmiere)
                            .Select(x => new { x.id });
            foreach (var v in LQuery)
            {
                vretour.Add(v.id.ToString());
            }
            return vretour;
        }

        public static List<string> GetListLibelleSoins()
        {
            List<string> vretour = new List<string>();
            var LQuery = maConnexion.soins.ToList()
                            .Select(x => new { x.libel });
            foreach (var v in LQuery)
            {
                vretour.Add(v.libel);
            }
            return vretour;
        }

        /// 
        /// 
        /// Methodes de type UPDATE
        /// 
        /// 

        public static void upDateConnexion(string login)
        {
            try
            {
                var user = maConnexion.personne_login.Where(d => d.login == login).First();
                user.derniere_connexion = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                Model.maConnexion.SaveChanges();
            }catch(Exception) { }
        }
        public static void upDateCompteRenduFromInfirmiere(int id, string compteRendu, DateTime DateReel)
        {
            var user = maConnexion.visite.Where(d => d.id == id).First();
            user.compte_rendu_infirmiere = compteRendu;
            user.date_reelle = DateReel;
            Model.maConnexion.SaveChanges();
        }

        public static void upDateCompteRenduFromPatient(int id, string compteRendu)
        {
            var user = maConnexion.visite.Where(d => d.id == id).First();
            user.compte_rendu_patient = compteRendu;
            Model.maConnexion.SaveChanges();
        }

        /// 
        /// 
        /// Methodes de type IMPORT
        /// 
        /// 

        public static string importPersonne(int id)
        {
            string vretour = "Erreur";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/personne/" + id;
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            try
            {
                string responseFromServer = reader.ReadToEnd();
                JArray JObjectPersonne = JArray.Parse(responseFromServer);

                foreach (var unePersonne in JObjectPersonne)
                {
                    int unId = int.Parse(unePersonne["id"].ToString());
                    string nom = unePersonne["nom"].ToString();
                    string prenom = unePersonne["prenom"].ToString();
                    string sexe = unePersonne["sexe"].ToString();
                    DateTime date_naiss = new DateTime();
                    date_naiss = Convert.ToDateTime(unePersonne["date_naiss"].ToString());
                    string ad1 = unePersonne["ad1"].ToString();
                    string ad2 = unePersonne["ad2"].ToString();
                    int cp = int.Parse(unePersonne["cp"].ToString());
                    string ville = unePersonne["ville"].ToString();
                    string tel_fixe = unePersonne["tel_fixe"].ToString();
                    string tel_port = unePersonne["tel_port"].ToString();
                    string mail = unePersonne["mail"].ToString();

                    vretour = "Success";
                    insertPersonne(unId, nom, prenom, sexe, date_naiss, ad1, ad2, cp, ville, tel_fixe, tel_port, mail);
                }
            }
            catch (Exception) { }
            return vretour;
        }

        public static string ImportVisite(int id)
        {
            string vretour = "Erreur";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/mesvisites/" + id;
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            try
            {
                string responseFromServer = reader.ReadToEnd();
                JArray JArrayVisites = JArray.Parse(responseFromServer);

                foreach (var JObjectVisite in JArrayVisites)
                {
                    int idVisite = int.Parse(JObjectVisite["id"].ToString());
                    int idPatient = int.Parse(JObjectVisite["patient"].ToString());
                    int idInfirmiere = int.Parse(JObjectVisite["infirmiere"].ToString());
                    DateTime date_prevue = new DateTime();
                    date_prevue = Convert.ToDateTime(JObjectVisite["date_prevue"].ToString());
                    int duree = int.Parse(JObjectVisite["duree"].ToString());

                    importPersonne(idPatient);
                    insertPatient(idPatient);
                    insertVisite(idVisite, idPatient, idInfirmiere, date_prevue, duree);
                    importSoinsVisite(idVisite);
                }
            }
            catch (Exception)
            {
            }
            return vretour;
        }

        public static bool importSoinsVisite(int idVisite)
        {
            bool vretour = false;
            var url = "http://www.btssio-carcouet.fr/ppe4/public/visitesoins/" + idVisite;
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            try
            {
                string responseFromServer = reader.ReadToEnd();
                JArray JArraySoinsVisite = JArray.Parse(responseFromServer);

                foreach (var JObjectSoinsVisite in JArraySoinsVisite)
                {
                    int id_categ_soins = int.Parse(JObjectSoinsVisite["id_categ_soins"].ToString());
                    int id_type_soins = int.Parse(JObjectSoinsVisite["id_type_soins"].ToString());
                    int id_soins = int.Parse(JObjectSoinsVisite["id_soins"].ToString());
                    short prevu = short.Parse(JObjectSoinsVisite["prevu"].ToString());
                    short realise = short.Parse(JObjectSoinsVisite["realise"].ToString());

                    insertSoinsVisite(idVisite, id_categ_soins, id_type_soins, id_soins, prevu, realise);
                }
            }
            catch (Exception) { }
            return vretour;
        }

        /// 
        /// 
        /// Methodes de type INSERT
        /// 
        /// 

        public static bool insertPersonne(int id, string unNom, string unPrenom, string unSexe, DateTime uneDateNaiss, string ad1, string ad2, int cp, string ville, string tel_fixe, string tel_port, string mail)
        {
            if (GetPersonneFromId(id).Count() == 0)
            {
                personne newPersonne = new personne();
                newPersonne.id = id;
                newPersonne.nom = unNom;
                newPersonne.prenom = unPrenom;
                newPersonne.sexe = unSexe;
                newPersonne.date_naiss = uneDateNaiss;
                newPersonne.ad1 = ad1;
                newPersonne.ad2 = ad2;
                newPersonne.cp = cp;
                newPersonne.ville = ville;
                newPersonne.tel_fixe = tel_fixe;
                newPersonne.tel_port = tel_port;
                newPersonne.mail = mail;

                try
                {
                    maConnexion.personne.Add(newPersonne);
                    maConnexion.SaveChanges();
                }
                catch (Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.InnerException.Message + " PERSONNE ");
                    maConnexion.Dispose();
                    init();
                }
            }
            return true;
        }
        public static bool insertPersonne_Login(int id, string login, string mdp)
        {
            personne_login newLogin = new personne_login();
            newLogin.id = id;
            newLogin.login = login;
            newLogin.nb_tentative_erreur = 0;
            newLogin.mp = toMD5(mdp);

            try
            {
                maConnexion.personne_login.Add(newLogin);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
                //System.Windows.Forms.MessageBox.Show(ex.InnerException.Message + " PERSONNE_LOGIN ");

            }
            return true;
        }

        public static bool insertInfirmiere(int unId)
        {
            infirmiere newInfirmiere = new infirmiere();
            newInfirmiere.id = unId;

            try
            {
                maConnexion.infirmiere.Add(newInfirmiere);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
                //System.Windows.Forms.MessageBox.Show(ex.InnerException.Message + " INFIRMIERE ");
            }
            return true;
        }

        public static bool insertPatient(int id)
        {
            bool vretour = false;
            if (GetPatientFromId(id).Count() == 0)
            {
                patient newPatient = new patient();
                newPatient.id = id;
                newPatient.informations_medicales = "NULL";

                try
                {
                    maConnexion.patient.Add(newPatient);
                    maConnexion.SaveChanges();
                    vretour = true;
                }
                catch (Exception)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.InnerException.Message + " PATIENT ");
                    maConnexion.Dispose();
                    init();
                }
            }

            return vretour;
        }

        public static bool insertVisite(int idVisiste, int idPatient, int idInfirmiere, DateTime date_prevue, int duree)
        {
            bool vretour = false;
            try
            {
                visite newVisite = new visite();
                newVisite.patient = idPatient;
                newVisite.infirmiere = idInfirmiere;
                newVisite.date_prevue = date_prevue;
                newVisite.duree = duree;
                newVisite.id = idVisiste;

                maConnexion.visite.Add(newVisite);
                maConnexion.SaveChanges();
                vretour = true;
            }
            catch (Exception)
            {
                maConnexion.Dispose();
                init();
            }
            return vretour;
        }

        public static bool insertSoinsVisite(int idVisite, int id_categ_soins, int id_type_soins, int id_soins, short prevu, short realise)
        {
            bool vretour = false;
            soins_visite newSoinsVisite = new soins_visite();
            newSoinsVisite.visite = idVisite;
            newSoinsVisite.id_categ_soins = id_categ_soins;
            newSoinsVisite.id_type_soins = id_type_soins;
            newSoinsVisite.id_soins = id_soins;
            newSoinsVisite.prevu = prevu;
            newSoinsVisite.realise = realise;

            try
            {
                maConnexion.soins_visite.Add(newSoinsVisite);
                maConnexion.SaveChanges();
                vretour = true;
            }
            catch (Exception)
            {
                vretour = false;
                maConnexion.Dispose();
                init();
            }
            return vretour;
        }



        /// 
        /// 
        /// Methodes de type AUTRE
        /// 
        /// 

        public static bool existPatient(int id)
        {
            bool vretour = false;
            var LQuery = maConnexion.patient.ToList()
                           .Where(x => x.id == id)
                           .Select(x => new { x.id });
            foreach (var v in LQuery)
            {
                if (v.id == id)
                {
                    vretour = true;
                }
            }
            return vretour;
        }

        public static bool existLogin(string login)
        {
            bool vretour = false;
            var LQuery = maConnexion.personne_login.ToList()
                           .Where(x => x.login == login)
                           .Select(x => new { x.login });
            foreach (var v in LQuery)
            {
                if (v.login == login)
                {
                    vretour = true;
                }
            }
            return vretour;
        }
        public static bool addErrorCount(string login)
        {
            bool vretour = false;
            var LQuery = maConnexion.personne_login.ToList()
                            .Where(x => x.login == login)
                            .Select(x => new { x.id, x.login, x.mp, x.nb_tentative_erreur });
            foreach (var v in LQuery)
            {
                if (v.login == login)
                {
                    personne_login newPersonne_login = new personne_login();
                    newPersonne_login.id = v.id;
                    newPersonne_login.login = v.login;
                    newPersonne_login.mp = v.mp;
                    newPersonne_login.nb_tentative_erreur = v.nb_tentative_erreur;

                    Model.maConnexion.personne_login.Add(newPersonne_login);
                    Model.maConnexion.SaveChanges();
                    vretour = true;
                }
            }
            return vretour;
        }

        public static bool compareMdp(string login, string mdp)
        {
            bool vretour = false;
            var LQuery1 = maConnexion.personne_login.ToList()
                            .Where(x => x.login == login)
                            .Select(y => new { y.mp });
            foreach (var y in LQuery1)
            {
                if (y.mp == toMD5(mdp))
                {
                    vretour = true;
                }
            }
            return vretour;
        }

        public static bool changeMp(string login, string newMp)
        {
            var dep = maConnexion.personne_login.Where(d => d.login == login).First();
            dep.mp = toMD5(newMp);
            Model.maConnexion.SaveChanges();
            return true;
        }


        public static int nbErrorConnxionAdd(string login)
        {
            int vretour = 0;
            var LQuery = maConnexion.personne_login.ToList()
                            .Where(x => x.login == login)
                            .Select(x => new { x.nb_tentative_erreur });
            foreach (var v in LQuery)
            {
                vretour = v.nb_tentative_erreur;
            }
            var dep = maConnexion.personne_login.Where(d => d.login == login).First();
            dep.nb_tentative_erreur = vretour + 1;
            Model.maConnexion.SaveChanges();

            return vretour;
        }

        public static string toMD5(string strText)
        {
            Byte[] buffer;
            buffer = Encoding.Default.GetBytes(strText);
            try
            {
                MD5CryptoServiceProvider check = new MD5CryptoServiceProvider();
                Byte[] somme;
                somme = check.ComputeHash(buffer);
                string ret = "";

                foreach (byte a in somme)
                {
                    if (a < 16) ret += "0" + a.ToString("X");
                    else ret += a.ToString("X");
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool addSoinsVisite(int idVisite, int etatPrevu, int etatRealise, string labelleSoins)
        {
            bool vretour = true;
            var LQuery = maConnexion.soins.ToList()
                            .Where(x => x.libel == labelleSoins)
                            .Select(x => new { x.id_categ_soins, x.id_type_soins, x.id });
            foreach (var v in LQuery)
            {
                try
                {
                    return insertSoinsVisite(idVisite, v.id_categ_soins, v.id_type_soins, v.id, short.Parse(etatPrevu.ToString()), short.Parse(etatRealise.ToString()));
                }
                catch (Exception ex)
                {
                    vretour = false;
                    System.Windows.Forms.MessageBox.Show(ex.InnerException.Message + " SoinsVisite ");
                }
            }

            return vretour;
        }
    }
}
