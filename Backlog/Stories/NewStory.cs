namespace Backlog.Stories
{
    using Simple.Web;

    [UriTemplate("/stories")]
    public class NewStory : IPost<Story>
    {
        public Status Post(Story input)
        {
            return Status.Created;
        }
    }
}