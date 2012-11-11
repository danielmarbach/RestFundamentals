namespace Backlog
{
    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/")]
    public class Index : IGet, IOutput<IndexOperations>
    {
        public Index()
        {
            this.Output = new IndexOperations();
        }

        public Status Get()
        {
            return Status.OK;
        }

        public IndexOperations Output { get; private set; }
    }

    public class IndexOperations
    {
    }
}