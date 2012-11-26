namespace Backlog.Stories.Backlog
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate(BacklogUri.Backlog)]
    [LinksFrom(typeof(StoryOperations), BacklogUri.Backlog, Rel = "stories backlog")]
    public class BacklogIndex : IGet, IOutput<BacklogStories>
    {
        public BacklogIndex()
        {
            this.Output = Stories.In(StoryState.Backlog).To();
        }

        public Status Get()
        {
            return Status.OK;
        }

        public BacklogStories Output { get; private set; }
    }
}