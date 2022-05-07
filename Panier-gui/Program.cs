using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panier_gui
{
    class Program
    {
        static void Main(string[] args)
        {
            Panier panier = new Panier();

            while (true)
            {
                int choix = Menu();
                switch (choix)
                {
                    case 0:
                        return;

                    case 1:
                        panier.AjouterProduit(CreerProduit());
                        break;
                    case 2:
                        panier.EnleverProduit(NumeroProduit());
                        break;

                    case 3:
                        Console.WriteLine("--------------------");
                        panier.Imprimer();
                        Console.WriteLine("Remise:" + panier.Remise);
                        Console.WriteLine("Total:" + panier.Total);
                        Console.WriteLine("--------------------");
                        break;

                    default:

                        break;
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("*****  Menu du Panier  *****");
            Console.WriteLine("1) Ajouter un produit");
            Console.WriteLine("2) Enlever un produit");
            Console.WriteLine("3) Imprimer");
            Console.WriteLine("0) Quitter");
            Console.WriteLine("--------------------");

            Console.Write("Tapez votre choix :");
            int choix = Convert.ToInt32(Console.ReadLine());
            return choix;
        }

        static Produit CreerProduit()
        {
            Console.WriteLine("--------------------");
            Console.Write("Désignation:");
            string designation = Console.ReadLine();
            Console.Write("Prix:");
            int prix = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantité:");
            int quantite = Convert.ToInt32(Console.ReadLine());
            Produit p = new Produit(designation, prix, quantite);
            return p;

        }

        static int NumeroProduit()
        {
            Console.WriteLine("--------------------");
            Console.Write("Numéro de la ligne à supprimer:");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
