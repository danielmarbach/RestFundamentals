namespace Backlog.Stories.Done
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate(DoneUri.Done)]
    [LinksFrom(typeof(StoryOperations), DoneUri.Done, Rel = "stories done")]
    public class GetDoneStories : IGet, IOutput<DoneStories>
    {
        public GetDoneStories()
        {
            this.Output = new DoneStories(Stories.In(StoryState.Done));
        }

        public Status Get()
        {
            return 200;
        }

        public DoneStories Output { get; private set; }
    }
}