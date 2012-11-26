namespace Backlog.Stories.Backlog.Estimation
{
    public static class EstimationExtensions
    {
        public static Story Estimate(this Story story, int points)
        {
            story.Points = points;

            return story;
        }
    }
}