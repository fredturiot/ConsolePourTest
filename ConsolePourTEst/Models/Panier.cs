using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTEst.Models
{

    public class Panier
    {
        //public static int ID { get; set; }   
        //pas d'id car pas d'enregistrement en base
        public Panier()
        {
            Lignes = new List<LignePanier>();
        }
        public decimal FraisDePort { get; set; } = 10m;
        public List<LignePanier> Lignes { get; set; }
        public Decimal GetTotal()
        {
            if (!Lignes.Any())// si Lignes est vide
            {
                return 0; 
            }
            var totalLignes = Lignes.Sum(x => x.Produit.Prix * x.Quantity);
            return totalLignes > 100 ? totalLignes : totalLignes + FraisDePort; 
            // frais de port offert a partir de 100€
        }
        public void Valider() // valide la ligne
        {
            foreach (var ligne in Lignes)
            {
                ligne.Valider();
            }
        }
    }
}
