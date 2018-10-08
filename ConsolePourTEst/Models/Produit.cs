using System;

namespace ConsolePourTEst.Models
{
    public class Produit
    {
        //methode 1
        private decimal prix;
        public decimal Prix
        {
            get { return this.prix; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prix ne peut pas etre negatif");
                prix = value;
            }

        }

        //methode 2
        public void Valider()
        {
            if (Prix<=0)
                throw new Exception("Prix ne peut pas etre negatif");
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Nom est Requis");
        }


        public int ID { get; set; }
        public string Name { get; set; }
        //public decimal Price { get; set; }
    }
}
