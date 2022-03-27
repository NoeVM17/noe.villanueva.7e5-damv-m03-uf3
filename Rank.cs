namespace MastermindV3
{
    public class Rank
    {
        public string RankName { get; set; }

        public int RankIntents { get; set; }
        
        /*public int CompareTo(Rank compareRank)
        {
            if (compareRank == null)
                return 0;
            else
                return this.RankIntents.CompareTo(compareRank.RankIntents);
        }*/
    }
}