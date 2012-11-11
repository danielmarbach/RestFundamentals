namespace Backlog.Stories.Backlog
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/backlog/{Id}/progress")]
    [LinksFrom(typeof(BacklogStory), "/stories/backlog/{Id}/progress", Rel = "move wip")]
    public class MoveBacklogStory : IPut
    {
        public Status Put()
        {
            Story story = Stories.By(this.Id).Next();

            Stories.Save(story);

            return Status.SeeOther(BacklogUri.Backlog);
        }

        public int Id { get; set; }
    }
}