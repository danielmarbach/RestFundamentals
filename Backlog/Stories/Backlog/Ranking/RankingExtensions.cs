namespace Backlog.Stories.Backlog.Ranking
{
    static internal class RankingExtensions
    {
        public static Story Rank(this Story story, int rank)
        {
            story.Rank = rank;

            return story;
        }
    }
}