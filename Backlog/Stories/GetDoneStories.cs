namespace Backlog.Stories
{
    using System.Collections.Generic;

    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/stories/done")]
    public class GetDoneStories : IGet, IOutput<List<Story>>
    {
        public GetDoneStories()
        {
            this.Output = new List<Story>(Stories.In(State.Done));
        }

        public Status Get()
        {
            return 200;
        }

        public List<Story> Output { get; private set; }
    }
}