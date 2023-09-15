using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Quali_Dev.Classe
{
    internal class Media
{
        public string titre { get; set; }

        public int numRef { get; set; }

        public int nbExemplaire { get; set; }


        public Media(string Titre, int numeroReference, int nombreExemplaires)
        {
            titre =Titre;
            numRef = numeroReference;
            nbExemplaire = nombreExemplaires;
        }




        public virtual void AfficherInfos()
        {
            Console.Out.Write("Titre: " + titre + "Numéro Référence: " + numRef + "Nombre Exemplaire: " + nbExemplaire);
        }

        public static Media operator +(Media media, int exemplairesAjoutes)
        {
            if (exemplairesAjoutes > 0)
            {
                media.nbExemplaire += exemplairesAjoutes;
            }
            else
            {
                Console.WriteLine("Erreur : Le nombre d'exemplaires ajoutés doit être positif.");
            }

            return media;
        }

        public static Media operator -(Media media, int exemplairesRetires)
        {
            if (exemplairesRetires > 0)
            {
                if (media.nbExemplaire >= exemplairesRetires)
                {
                    media.nbExemplaire -= exemplairesRetires;
                }
                else
                {
                    throw new InvalidOperationException("Le nombre d'exemplaires disponibles est insuffisant.");
                }
            }
            else
            {
                throw new InvalidOperationException("Le nombre d'exemplaires retirés doit être positif.");
            }

            return media;
        }
    }
}
