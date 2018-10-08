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
        public decimal FraisDePort { get; set; } = 10m;
        public List<LignePanier> Lignes { get; set; }
        public Decimal GetTotal()
        {
            var totalLignes = Lignes.Sum(x => x.Produit.Price * x.Quantity);
            return totalLignes + FraisDePort;
        }
    }
}
