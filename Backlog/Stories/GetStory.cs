namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}")]
    // Note that in 0.6, the Canonical UriTemplate argument will be optional,
    // and you won't have to specify it if it's the same as the UriTemplate attribute value.
    [Canonical(typeof(Story), "/stories/{Id}")]
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