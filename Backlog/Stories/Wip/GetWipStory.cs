namespace Backlog.Stories.Wip
{
    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/stories/wip/{Id}")]
    public class GetWipStory : IGet, IOutput<WipStory>
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

        public WipStory Output { get; private set; }
    }
}