namespace Backlog.Stories
{
    using System.Collections.Generic;

    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/stories")]
    public class GetStories : IGet, IOutput<List<Story>>
    {
        public GetStories()
        {
            this.Output = new List<Story>(Stories.All());
        }

        public Status Get()
        {
            return Status.OK;
        }

        public List<Story> Output { get; private set; }
    }
}