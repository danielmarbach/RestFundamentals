namespace Backlog
{
    using Simple.Web;

    [UriTemplate("/")]
    public class Index : IGet
    {
        public Status Get()
        {
            return Status.OK;
        }
    }
}