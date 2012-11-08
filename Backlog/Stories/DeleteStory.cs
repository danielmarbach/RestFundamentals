namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}")]
    [LinksFrom(typeof(Story), "/stories/{Id}", Rel = "story remove")]
    public class DeleteStory : IDelete
    {
        public Status Delete()
        {
            Stories.Delete(this.Id);

            return Status.SeeOther("/stories");
        }

        public int Id { get; set; }
    }
}