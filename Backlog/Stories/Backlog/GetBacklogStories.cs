namespace Backlog.Stories.Backlog
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate(BacklogUri.Backlog)]
    [LinksFrom(typeof(StoryOperations), BacklogUri.Backlog, Rel = "stories backlog")]
    public class GetBacklogStories : IGet, IOutput<BacklogStories>
    {
        public GetBacklogStories()
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