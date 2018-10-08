using System;
using ConsolePourTEst.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePour_TestTests
{
    [TestClass]
    public class ProduitTests
    {
        [DataTestMethod]
        [DataRow("0")]
        [DataRow("-1")]
        public void ValiderPrix(string rawPrix) // rawPrix  = DataRow Value 
            // ne prend que du string...
      
        {
            var prix = decimal.Parse(rawPrix); // ...donc conversion

            var exception = Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Name = "Bottle of Wine",
                    Prix = prix
                };
            });

            Assert.AreEqual("Prix ne peut pas etre negatif", exception.Message);
            //message comparé!!
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("      ")]
        public void ImpossibleDeMettreNomVide(string nomProduit)
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Name = nomProduit,
                    Prix = 10
                };
                produit.Valider();
            });
        }
    }
}
