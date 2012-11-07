namespace Backlog.Stories
{
    using System.Collections.Generic;
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories")]
    // This doesn't work yet, but it will in 0.6
    [LinksFrom(typeof(ICollection<Story>), "/stories", Rel = "post")]
    public class NewStory : IPost<Story>
    {
        public Status Post(Story input)
        {
            return Status.Created;
        }
    }
}