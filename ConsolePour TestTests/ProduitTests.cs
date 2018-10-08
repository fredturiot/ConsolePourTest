using System;
using ConsolePourTEst.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePour_TestTests
{
    [TestClass]
    public class ProduitTests
    {
        [TestMethod]
        public void ImpossibleDeMettrePrixInfOuEgalZero()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Name = "Bottle of Wine",
                    Prix = 0
                };
            });
        }

        [TestMethod]
        public void ImpossibleDeMettreNomVide()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Name = "",
                    Prix = 10
                };
                produit.Valider();
            });
        }
    }
}
