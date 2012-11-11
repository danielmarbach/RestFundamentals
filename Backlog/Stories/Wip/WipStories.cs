namespace Backlog.Stories.Wip
{
    using System.Collections.Generic;

    public class WipStories : List<WipStory>
    {
        public WipStories()
        {
        }

        public WipStories(int capacity)
            : base(capacity)
        {
        }

        public WipStories(IEnumerable<WipStory> collection)
            : base(collection)
        {
        }
    }
}