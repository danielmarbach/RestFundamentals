namespace Backlog.Stories.Wip
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/wip/{Id}/progress")]
    [LinksFrom(typeof(WipStory), "/stories/wip/{Id}/progress", Rel = "move done")]
    public class MoveWipStory : IPut
    {
        public Status Put()
        {
            Story story = Stories.By(this.Id).Next();

            Stories.Save(story);

            return Status.SeeOther(WipUri.Wip);
        }

        public int Id { get; set; } 
    }
}