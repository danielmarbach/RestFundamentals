namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/stories/{Id}")]
    public class GetStory : IGet, IOutput<Story>
    {
        public Status Get()
        {
            this.Output = Stories.By(this.Id);

            return this.Output == null ? 404 : 200;
        }

        public Story Output { get; private set; }

        public int Id { get; set; }
    }
}