using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panier_gui
{
    class Panier
    {
        /*private int tauxRemise;*/
        public int TauxRemise { get; set; }
        private List<Produit> produits;

        public Panier(int taux = 0)
        {
            this.TauxRemise = taux;
            this.produits = new List<Produit>();
        }

        public void AjouterProduit(Produit p)
        {
            this.produits.Add(p);
        }

        public void EnleverProduit(int indice)
        {
            this.produits.RemoveAt(indice);
        }

        /*public int Remise()
        {
            int total = 0;
            foreach (Produit p in this.produits)
            {
                total += p.Montant();
            }
            return (total * this.tauxRemise) / 100;
        }*/
        public int Remise
        {
            get
            {
                int total = 0;
                foreach (Produit p in this.produits)
                {
                    total += p.Montant;
                }
                return (total * this.TauxRemise) / 100;
            }
        }

        /*public int Total()
        {
            int total = 0;
            foreach (Produit p in this.produits)
            {
                total += p.Montant();
            }

            return total - this.Remise();
        }*/

        public int Total
        {
            get
            {
                int total = 0;
                foreach (Produit p in this.produits)
                {
                    total += p.Montant;
                }

                return total - this.Remise;
            }
        }

        public void Imprimer()
        {
            Console.WriteLine("Designation\tPrix\tQte\tMontant");
            foreach (Produit p in this.produits)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", p.Designation,
                    p.Prix, p.Quantite, p.Montant);
            }
        }
    }
}
