namespace Backlog.Stories.Backlog
{
    using System.Collections.Generic;
    using System.Linq;

    public static class BacklogExtensions
    {
        public static BacklogStories To(this IEnumerable<Story> stories)
        {
            return new BacklogStories(stories.Select(To));
        }

        public static BacklogStory To(this Story story)
        {
            return new BacklogStory
                {
                    Id = story.Id,
                    Points = story.Points,
                    Rank = story.Rank,
                    Text = story.Text,
                };
        }
    }
}