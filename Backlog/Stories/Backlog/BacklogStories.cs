namespace Backlog.Stories.Backlog
{
    using System.Collections.Generic;

    public class BacklogStories : List<BacklogStory>
    {
        public BacklogStories(IEnumerable<BacklogStory> collection)
            : base(collection)
        {
        }

        public BacklogStories()
        {
        }

        public BacklogStories(int capacity)
            : base(capacity)
        {
        }
    }
}