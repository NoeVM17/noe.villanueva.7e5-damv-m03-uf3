using System;
namespace MastermindV3
{
    public class InData
    {
        public static void IniciJoc()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Benvingut a Mastermind!");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Prem una tecla per començar!");
            Console.ReadKey();
            Console.Clear();
        }
        public static string Nom()
        {
            string nom;
            do
            {
                Console.WriteLine("Introdueix el teu nom:");
                nom = Console.ReadLine();
            } while (nom == null || nom == "");
            return nom;
        }
        public static void JocInici()
        {
            Console.WriteLine("Comença el joc! ");
            Console.WriteLine("");
            Console.WriteLine("Recorda que juguem amb A, B, C, D, E i F.");
            Console.WriteLine("");
        }
        public static int Intents()
        {
            int intents = 12;
            return intents;
        }

        public static int IntentsJugador()
        {
            int intentsjugador = 0;
            return intentsjugador;
        }
        public static string[] RankName()
        {
            string[] nomsRanking = new string[10];
            return nomsRanking;
        }
        public static int[] RankInts()
        {
            int[] intentsRanking = new int[10];
            return intentsRanking;
        }
        public static string CombInicial()
        {
            string intent;
            bool lletrescorrectes;
            do
            {
                do
                {
                    lletrescorrectes = true;
                    Console.WriteLine("Introdueixi la combinació: ");
                    intent = Console.ReadLine();
                } while (intent == null || intent == "");
                
                for (int k = 0; k < 4; k++)
                {
                    if (intent[k] < 'A' || intent[k] > 'F')
                    {
                        lletrescorrectes = false;
                    }
                }

            } while (intent.Length != 4 || lletrescorrectes == false);
                
            return intent;
        }
    }
}