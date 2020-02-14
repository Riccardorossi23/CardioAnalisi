using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.test
{
    [TestClass]
    public class TestCardio
    {
        [TestMethod]
        public void Cardio1()
        {
            int bpm = 197;
            double frequenza = CardioLibrary.dataCardio.Cardio(23);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio2()
        {

            int bpm = 149;
            double frequenza = CardioLibrary.dataCardio.Cardio(71);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio3()
        {
            int bpm = 180;
            double frequenza = CardioLibrary.dataCardio.Cardio(40);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio4()
        {
            int bpm = 185;
            double frequenza = CardioLibrary.dataCardio.Cardio(35);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio5()
        {
            int bpm = 170;
            double frequenza = CardioLibrary.dataCardio.Cardio(50);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void FrequenzaCardio1()
        {
            int frequenzaGinnastica = 157;
            double bpm = CardioLibrary.dataCardio.frequenzaCardio(197);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio2()
        {
            int frequenzaGinnastica = 119;
            double bpm = CardioLibrary.dataCardio.frequenzaCardio(149);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio3()
        {
            int frequenzaGinnastica = 144;
            double bpm = CardioLibrary.dataCardio.frequenzaCardio(180);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio4()
        {
            int frequenzaGinnastica = 148;
            double bpm = CardioLibrary.dataCardio.frequenzaCardio(186);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio5()
        {
            int frequenzaGinnastica = 136;
            double bpm = CardioLibrary.dataCardio.frequenzaCardio(170);
            Assert.AreEqual(frequenzaGinnastica, bpm);
        }

        [TestMethod]
        public void Calorie()
        {
            double calorie = 2303.1319311663483;
            double frequenza = CardioLibrary.dataCardio.ConsumoCalorieUomo(78, 147, 35, 160);
            Assert.AreEqual(calorie, frequenza);

        }
   
    }
}
