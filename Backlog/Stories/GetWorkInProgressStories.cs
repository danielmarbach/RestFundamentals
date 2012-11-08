namespace Backlog.Stories
{
    using System.Collections.Generic;

    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/stories/progress")]
    public class GetWorkInProgressStories : IGet, IOutput<List<Story>>
    {
        public GetWorkInProgressStories()
        {
            this.Output = new List<Story>(Stories.In(State.WorkInProgress));
        }

        public Status Get()
        {
            return 200;
        }

        public List<Story> Output { get; private set; }
    }
}