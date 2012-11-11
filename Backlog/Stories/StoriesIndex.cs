namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories")]
    [LinksFrom(typeof(IndexOperations), "/stories", Rel = "stories")]
    public class StoriesIndex : IGet, IOutput<StoryOperations>
    {
        public StoriesIndex()
        {
            this.Output = new StoryOperations();
        }

        public Status Get()
        {
            return 200;
        }

        public StoryOperations Output { get; private set; }
    }

    public class StoryOperations
    {
    }
}