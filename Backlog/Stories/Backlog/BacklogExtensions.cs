namespace Backlog.Stories.Backlog
{
    using System.Collections.Generic;
    using System.Linq;

    public static class BacklogExtensions
    {
        public static BacklogStories To(this IEnumerable<Story> stories)
        {
            return new BacklogStories(stories.Select(story => To((Story)story)));
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

        public static Story Next(this Story story)
        {
            story.State = StoryState.Wip;

            return story;
        }

        public static Story Rank(this Story story, int rank)
        {
            story.Rank = rank;

            return story;
        }

        public static Story Estimate(this Story story, int points)
        {
            story.Points = points;

            return story;
        }

        public static Story From(this Story story, BacklogUpdate backlogUpdate)
        {
            story.Text = backlogUpdate.Text;

            return story;
        }
    }
}