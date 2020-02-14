using System;

namespace CardioLibrary
{
    public class dataCardio
    {
        
        public static double Cardio(double anni)
        {
            if (anni <= 75)
            {
                double bpm = 220 - anni;
                return bpm;

            }
            else
            {
                double bpm = 220 - anni;
                return bpm;

            }
        }
        public static int frequenzaCardiomax(int bpm)
        {
            int max = (90 * bpm / 100);
            return max;
        }
        public static int frequenzaCardiomin(int bpm)
        {

            int min = (70 * bpm / 100);
            return min;
        }
        public static int frequenzaCardio(int bpm)
        {
            int calcolo = (70 * bpm / 100) + (90 * bpm / 100);
            
            int frequenza = calcolo / 2;
            return frequenza;
        }
        public static double ConsumoCalorieUomo(double peso, double media, double anni, double esercizio)
        {
            double Calorie = (anni * 0.2017) + (peso * 0.199) + (media * 0.6309) - 55.0969;
            double calorie_bruciate = Calorie * esercizio / 4.184;
            return calorie_bruciate;
        }
        public static double ConsumoCalorieDonna(double peso, double media, double anni, double esercizio)
        {
            double Calorie = (anni * 0.074) + (peso * 0.126) + (media * 0.4472) - 20.4022;
            double calorie_bruciate = Calorie * esercizio / 4.184;
            return calorie_bruciate;
        }
    }
}
