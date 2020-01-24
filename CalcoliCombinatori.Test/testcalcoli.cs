using EquazioniLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class testcalcoli
    {
        [TestMethod]
        public void TestFattoriale1()
        {
            long n = 1;
            long numero_attuale = CalcoliEquazioniClass.Fattoriale(n);
            long risposta_aspettato = 1;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestFattoriale2()
        {
            long n = 0;
            long numero_attuale = CalcoliEquazioniClass.Fattoriale(n);
            long risposta_aspettato = 1;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestFattoriale3()
        {
            long n = 5;
            long numero_attuale = CalcoliEquazioniClass.Fattoriale(n);
            long risposta_aspettato = 120;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestFattoriale4()
        {
            long n = 10;
            long numero_attuale = CalcoliEquazioniClass.Fattoriale(n);
            long risposta_aspettato = 3628800;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestFattoriale5()
        {
            long n = 50;
            long numero_attuale = CalcoliEquazioniClass.Fattoriale(n);
            long risposta_aspettato = ;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
    }
}
