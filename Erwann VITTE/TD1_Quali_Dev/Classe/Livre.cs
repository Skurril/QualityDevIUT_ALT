using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Quali_Dev.Classe
{
    internal class Livre : Media
    {
        public string Auteur { get; set; }
        public int NbPages { get; set; }

        public Livre(string Titre, int numeroReference, int nombreExemplaires, string auteur)
        : base(Titre, numeroReference, nombreExemplaires)
        {
            Auteur = auteur;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.Out.WriteLine("Auteur: "+Auteur+"Nombre de pages: "+NbPages);
        }
    }
}
