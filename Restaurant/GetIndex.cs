namespace Restaurant
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/")]
    public class GetIndex : IGet
    {
        public Status Get()
        {
            return 200;
        }
    }
}