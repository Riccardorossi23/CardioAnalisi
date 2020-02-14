using System;

namespace Cardio
{
    class terminale
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la tua frequenza cardiaca?");
            int frequenza = int.Parse(Console.ReadLine());
            if(frequenza<60)
            {
                Console.WriteLine("il tuo battito è bradicardico");
            }
            else if(frequenza>60&&frequenza<100)
            {
                Console.WriteLine("il tuo battito è normale");
            }
            else
            {
                Console.WriteLine("il tuo battito è Tachicardico");
            }
        }
    }
}
