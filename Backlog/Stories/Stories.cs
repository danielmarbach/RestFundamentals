namespace Backlog.Stories
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using Simple.Web;

    public class Stories : IStartupTask
    {
        private static readonly IDictionary<int, Story> stories = new ConcurrentDictionary<int, Story>();

        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            stories.Add(1, new Story { Id = 1, Text = "As a user..."});
            stories.Add(2, new Story { Id = 2, Text = "As a operator..." });
            stories.Add(3, new Story { Id = 3, Text = "As a administrator..."});
        }

        public static IEnumerable<Story> All()
        {
            return stories.Values;
        }

        public static Story By(int id)
        {
            Story value;
            stories.TryGetValue(id, out value);
            return value;
        }

        public static void Update(Story story)
        {
            stories[story.Id] = story;
        }
    }
}