using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panier_gui
{
    class Produit
    {
        /*private string designation;
        private int prix;
        private int quantite;*/
        public string Designation { get; set; }
        public int Prix { get; set; }
        public int Quantite { get; set; }

        

        public Produit(string designation, int prix, int quantite)
        {
            /*this.designation = designation;
            this.prix = prix;
            this.quantite = quantite;*/
            this.Designation = designation;
            this.Prix = prix;
            this.Quantite = quantite;
        }

        /*public int Montant()
        {
            return this.prix * this.quantite;
        }*/

        public int Montant {
            get { return this.Prix * this.Quantite; }
        }

        /*
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
        */
    }
}
