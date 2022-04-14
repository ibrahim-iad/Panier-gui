using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panier_gui
{
    class Produit
    {
        private string designation;
        private int prix;
        private int quantite;

        public Produit(string designation, int prix, int quantite)
        {
            this.designation = designation;
            this.prix = prix;
            this.quantite = quantite;
        }

        public int Montant()
        {
            return this.prix * this.quantite;
        }

        public string getDesignation()
        {
            return this.designation;
        }
        public int getPrix()
        {
            return this.prix;
        }
        public int getQuantite()
        {
            return this.quantite;
        }
    }
}
