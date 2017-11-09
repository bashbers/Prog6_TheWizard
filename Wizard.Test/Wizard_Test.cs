using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Wizard.Test
{
    [TestClass]
    public class Wizard_Test
    {
        #region Constructor

        private Wizard.Tovenaar tovenaar;
        private Wizard.Toverstaf staf;

        [TestInitialize]
        public void Init()
        {
            staf = new Toverstaf();
            tovenaar = new Tovenaar(staf);
        }

        #endregion

        #region ForamisForameur
        [TestMethod]
        public void Foramisforameur_goed()
        {
            //1. Arrange

            List<string> words = new List<string> { "Fora", "mis", "Forameur" };
            List<string> ingredients = new List<string> { "spinneweb", "oorlel", "slangegif" };

            //2. Act

            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert

            Assert.AreEqual(res, "doe open die poort");

        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeWoordenException))]
        public void Foramisforameur_fout_verkeerde_woorden()
        {
            //1. Arrange
            List<string> words = new List<string> { "oeps", "mis", "Forameur" };
            List<string> ingredients = new List<string> { "spinneweb", "oorlel", "slangegif" };

            //2. Act
            var res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert
            Assert.AreEqual(res, "doe open die poort");
        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeIngredientenException))]
        public void Foramisforameur_fout_verkeerde_ingredienten()
        {
            //1. Arrange
            List<string> words = new List<string> { "Fora", "mis", "Forameur" };
            List<string> ingredients = new List<string> { "spinneweb", "oorlel", "oepsiedasie" };

            //2. Act
            var res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert
            Assert.AreEqual(res, "doe open die poort");
        }

#endregion

        #region FlimFlamFluister
        [TestMethod]
        public void Flimflamfluister_goed()
        {
            //1. Arrange
            List<string> words = new List<string> { "Flim", "Flam", "Fluister" };
            List<string> ingredients = new List<string> { "Kikkerbil", "oorlel", "rattenstaart", "krokodillenoog" };

            //2. Act
            staf.Links();
            staf.Rechts();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert
            Assert.AreEqual(res, "Er was licht, en hij zag dat het goed was!");

        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeWoordenException))]

        public void Flimflamfluister_fout_verkeerde_woorden()
        {
            //1. Arrange
            List<string> words = new List<string> { "boeiend", "Flam", "Fluister" };
            List<string> ingredients = new List<string> { "Kikkerbil", "oorlel", "rattenstaart", "krokodillenoog" };

            //2. Act
            staf.Links();
            staf.Rechts();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert
            Assert.AreEqual(res, "Er was licht, en hij zag dat het goed was!");

        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeIngredientenException))]

        public void Flimflamfluister_fout_verkeerde_ingredienten()
        {
            //1. Arrange
            List<string> words = new List<string> { "Flim", "Flam", "Fluister" };
            List<string> ingredients = new List<string> { "boi", "oorlel", "rattenstaart", "krokodillenoog" };

            //2. Act
            staf.Links();
            staf.Rechts();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert
            Assert.AreEqual(res, "Er was licht, en hij zag dat het goed was!");

        }

        #endregion

        #region Bandalik

        [TestMethod]
        public void Bandalik_goed()
        {
            //1. Arrange

            List<string> words = new List<string> { "Ban", "da", "ladik" };
            List<string> ingredients = new List<string> { "Kikkerbil", "oorlel", "slangegif", "rattenstaart" };

            //2. Act

            staf.Omhoog();
            staf.Omlaag();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert

            Assert.AreEqual(res, "best friends for life");

        }
        [TestMethod]
        [ExpectedException(typeof(VerkeerdeWoordenException))]
        public void Bandalik_fout_verkeerde_woorden()
        {
            //1. Arrange

            List<string> words = new List<string> { "Ban", "da", "dalik" };
            List<string> ingredients = new List<string> { "Kikkerbil", "oorlel", "slangegif", "rattenstaart" };

            //2. Act

            staf.Omhoog();
            staf.Omlaag();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert

            Assert.AreEqual(res, "best friends for life");

        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeIngredientenException))]
        public void Bandalik_fout_verkeerde_ingredienten()
        {
            //1. Arrange

            List<string> words = new List<string> { "Ban", "da", "ladik" };
            List<string> ingredients = new List<string> { "nibba", "oorlel", "slangegif", "rattenstaart" };

            //2. Act

            staf.Omhoog();
            staf.Omlaag();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert

            Assert.AreEqual(res, "best friends for life");

        }
        #endregion

        #region ArmaKroDilt


        /// <summary>
        /// Niet testbaar vanwege het feit dat de tovenaar geen mogelijkheid heeft om zijn kookpot te verwisselen.
        /// </summary>
        [TestMethod]
        public void Armakrodilt_goed()
        {

            //1. Arrange

            List<string> words = new List<string> { "Arma", "kro", "dilt" };
            List<string> ingredients = new List<string> { "Kikkerbil", "spinneweb", "oorlel", "rattenstaart", "slangegif", "mensenhaar", "krokodillenoog" };

            //2. Act
            Kookpot kookpot = new Kookpot("zilver");
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert

            Assert.AreEqual(res, "upgrades");

        }

        #endregion

        #region Balsamsalabond

        [TestMethod]
        public void Balsamsalabond_goed()
        {
            //1. Arrange

            List<string> words = new List<string> { "Bal", "sam", "sala", "bond" };
            List<string> ingredients = new List<string> { "Kikkerbil", "spinneweb", "mensenhaar", "krokodillenoog" };

            //2. Act

            staf.Links();
            staf.Omhoog();
            staf.Rechts();
            staf.Omlaag();
            string res = tovenaar.Toverspreuk(ingredients, words);

            //3. Assert

            Assert.AreEqual(res, "Je bent genezen met " + staf.HoeveelheidEnergie +" energiepunten");

        }

        #endregion
    }
}
