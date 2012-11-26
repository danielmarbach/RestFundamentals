namespace Backlog.Stories.Backlog.Modification
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate(BacklogUri.Backlog + "/{Id}")]
    [LinksFrom(typeof(BacklogStory), BacklogUri.Backlog + "/{Id}", Rel = "story remove")]
    public class DeleteBacklogStory : IDelete
    {
        public Status Delete()
        {
            Stories.Delete(this.Id);

            return Status.SeeOther(BacklogUri.Backlog);
        }

        public int Id { get; set; }
    }
}