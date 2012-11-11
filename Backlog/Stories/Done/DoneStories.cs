namespace Backlog.Stories.Done
{
    using System.Collections.Generic;

    public class DoneStories : List<Story>
    {
        public DoneStories()
        {
        }

        public DoneStories(int capacity)
            : base(capacity)
        {
        }

        public DoneStories(IEnumerable<Story> collection)
            : base(collection)
        {
        }
    }
}