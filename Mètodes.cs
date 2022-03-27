using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MastermindV3
{
    public class Mètodes
    {
        public static string Combinacio()
        {
            string comb = "";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                char repetida = Convert.ToChar(rnd.Next(65, 71));

                if (comb.Contains(repetida))
                    i--;
                else
                {
                    comb += repetida;
                }
            }

            return comb;
        }
        public static void ComprovarComb(string intent, string comb, ref int intents, ref bool final,
            ref int intentsjugador)
        {
            int rightposition = 0;
            int wrongposition = 0;
            
            for (int j = 0; j < 4; j++)
            {
                if (intent.Contains(comb[j]))
                {
                    if (intent[j] == comb[j])
                    {
                        rightposition = rightposition + 1;
                    }
                    else
                    {
                        wrongposition = wrongposition + 1;
                    }
                }
            }

            if (rightposition != 4 && intents != 0)
            {
                intents--;
                intentsjugador++;
                OutData.IntentsRestants(rightposition,wrongposition,intents);
            }
            
            if (rightposition == 4)
            {
                intentsjugador++;
                final = !final;
                OutData.Victoria();
                OutData.SortirPrograma(comb);
            }

            if (intents == 0 && rightposition != 4)
            {
                intentsjugador = 12;
                final = !final;
                OutData.Derrota();
                OutData.SortirPrograma(comb);
            }
        }

        public static void ActMatriu(ref string[] nomsRanking, ref int[] intentsRanking, string nom, int intentsjugador)
        {
            for (int i = 0; i < nomsRanking.Length; i++)
            {
                /*nomsRanking[i] = nom;
                intentsRanking[i] = intentsjugador;*/
            }
        }
        public static void NomRanking(string path, string nom, int intentsjugador)
        {
            /*List<Rank> ranks = new List<Rank>();
            List<Rank> ranks2 = new List<Rank>();
            ranks.Add(new Rank(){RankName = nom, RankIntents = intentsjugador});
            foreach (Rank aRank in ranks)
            {
                Console.WriteLine(aRank);
                ranks2.Add(aRank);
            }
            ranks2.Sort(Comparer<Rank>.Default);
            foreach (Rank aRank in ranks2)
            {
                Console.WriteLine(aRank);
            }*/
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("---RANKING DE POSICIONS---");
                    sw.WriteLine("");
                }
            }
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(nom + " - " + intentsjugador + " intents");
                }
            }
        }
    }
}