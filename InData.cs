using System;
namespace MastermindV3
{
    /// <summary>
    /// Classe InData que la farem servir per crear mètodes només per rebre informació de l'usuari o per crear informació que necessitarem per fer les operacions.
    /// </summary>
    public class InData
    {
        /// <summary>
        /// Mètode d'inici del joc on tindrem writelines com a pantalla principal al començar el joc.
        /// </summary>
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
        /// <summary>
        /// Mètode on rebrem el nom del jugador que estarà jugant la partida corresponent.
        /// </summary>
        /// <returns>Retorna un string amb el nom del jugador.</returns>
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
        /// <summary>
        /// Mètode on tindrem writelines informant sobre les lletres amb les que juguem perque el jugador pugui tenir-ho com a orientació.
        /// </summary>
        public static void JocInici()
        {
            Console.WriteLine("Comença el joc! ");
            Console.WriteLine("");
            Console.WriteLine("Recorda que juguem amb A, B, C, D, E i F.");
            Console.WriteLine("");
        }
        /// <summary>
        /// Mètode on inicialitzem els intents que tindrà el jugador per intentar acertar la combinació.
        /// </summary>
        /// <returns>Retorna un int amb el intents inicials.</returns>
        public static int Intents()
        {
            int intents = 12;
            return intents;
        }
        /// <summary>
        /// Mètode on inicialitzem els intents que farà servir el jugador per intentar acertar la combinació.
        /// </summary>
        /// <returns>Retorna un int amb el intents que va fent el jugador.</returns>
        public static int IntentsJugador()
        {
            int intentsjugador = 0;
            return intentsjugador;
        }
        /// <summary>
        /// Mètode on es demana al jugador que insereixi la combinació que vol provar i es controlarà i comprovarà la combinació introduïda.
        /// </summary>
        /// <returns></returns>
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