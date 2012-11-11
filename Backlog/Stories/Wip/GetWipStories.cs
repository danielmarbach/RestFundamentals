namespace Backlog.Stories.Wip
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories/wip")]
    [LinksFrom(typeof(StoryOperations), "/stories/wip", Rel = "stories wip")]
    public class GetWipStories : IGet, IOutput<WipStories>
    {
        public GetWipStories()
        {
            this.Output = Stories.In(StoryState.Wip).To();
        }

        public Status Get()
        {
            return 200;
        }

        public WipStories Output { get; private set; }
    }
}