namespace Backlog.Stories.Wip
{
    using System.Collections.Generic;
    using System.Linq;

    public static class WipExtensions
    {
        public static WipStories To(this IEnumerable<Story> stories)
        {
            return new WipStories(stories.Select(story => story.To()));
        }

        public static WipStory To(this Story story)
        {
            return new WipStory
            {
                Id = story.Id,
                Points = story.Points,
                Rank = story.Rank,
                Text = story.Text,
            };
        }

        public static Story Next(this Story story)
        {
            story.State = StoryState.Done;

            return story;
        }
    }
}