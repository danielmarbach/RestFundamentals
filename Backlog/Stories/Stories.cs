namespace Backlog.Stories
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Threading;

    using Simple.Web;

    using System.Linq;

    public class Stories : IStartupTask
    {
        private static int currentStoryId;

        private static readonly ConcurrentDictionary<int, Story> stories = new ConcurrentDictionary<int, Story>();

        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            Save(new Story { Id = 1, Text = "As a user..."});
            Save(new Story { Id = 2, Text = "As a operator...", State = StoryState.Wip });
            Save(new Story { Id = 3, Text = "As a administrator..." });
        }

        public static IEnumerable<Story> In(StoryState state)
        {
            return All()
                .Where(s => s.State == state);
        }

        public static IEnumerable<Story> All()
        {
            return stories.Values;
        }

        public static Story New()
        {
            return new Story { Id = Interlocked.Add(ref currentStoryId, 1) };
        }

        public static Story By(int id)
        {
            Story value;
            stories.TryGetValue(id, out value);
            return value;
        }

        public static void Save(Story story)
        {
            stories.AddOrUpdate(story.Id, story, (id, old) => story);
        }

        public static void Delete(int id)
        {
            Story story;
            stories.TryRemove(id, out story);
        }
    }
}