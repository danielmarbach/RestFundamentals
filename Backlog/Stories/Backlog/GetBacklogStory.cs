namespace Backlog.Stories.Backlog
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories/backlog/{Id}")]
    [Canonical(typeof(BacklogStory), "/stories/backlog/{Id}")]
    public class GetBacklogStory : IGet, IOutput<BacklogStory>
    {
        public Status Get()
        {
            var story = Stories.By(this.Id);

            if (story == null)
            {
                return 404;
            }

            this.Output = story.To();

            return 200;
        }

        public int Id { get; set; }

        public BacklogStory Output { get; private set; }
    }
}