using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUser
{
    public class ClassPersonne
    {
        int id;
        string nom;
        string prenom;
        string login;

        public ClassPersonne(int id)
        {
            this.id = id;
            this.login = Model.GetLoginPersonneFromId(id);
            this.nom = Model.GetNomPersonneFromId(id);
            this.prenom = Model.GetPrenomPersonneFromId(id);
        }

        public int getId()
        {
            return this.id;
        }

        public string getLogin()
        {
            return this.login;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }
    }
}
