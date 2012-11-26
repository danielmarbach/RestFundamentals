namespace Backlog.Stories.Wip.Next
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories/wip/{Id}/progress")]
    [LinksFrom(typeof(WipStory), "/stories/wip/{Id}/progress", Rel = "move done")]
    [LinksFrom(typeof(MoveWipOperations), "/stories/done", Rel = "stories done")]
    [Canonical(typeof(MoveWipOperations), "/stories/done/{Id}")]
    public class MoveWipStory : IPut, IOutput<MoveWipOperations>
    {
        public Status Put()
        {
            Story story = Stories.By(this.Id).Next();

            Stories.Save(story);

            this.Output = new MoveWipOperations { Id = this.Id };

            return 200;
        }

        public int Id { get; set; }

        public MoveWipOperations Output { get; private set; }
    }
}