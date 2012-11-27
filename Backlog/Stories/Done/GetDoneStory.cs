namespace Backlog.Stories.Done
{
    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/stories/done/{Id}")]
    public class GetDoneStory : IGet, IOutput<Story>
    {
        public Status Get()
        {
            var story = Stories.By(this.Id, StoryState.Done);

            if (story == null)
            {
                return 404;
            }

            this.Output = story;

            return 200;
        }

        public int Id { get; set; }

        public Story Output { get; private set; }
    }
}