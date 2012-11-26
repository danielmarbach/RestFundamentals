namespace Backlog.Stories.Backlog.Next
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories/backlog/{Id}/progress")]
    [LinksFrom(typeof(BacklogStory), "/stories/backlog/{Id}/progress", Rel = "move wip")]
    [LinksFrom(typeof(MoveBacklogOperations), "/stories/wip", Rel = "stories wip")]
    [Canonical(typeof(MoveBacklogOperations), "/stories/wip/{Id}")]
    public class MoveBacklogStory : IPut, IOutput<MoveBacklogOperations>
    {
        public Status Put()
        {
            Story story = Stories.By(this.Id).Next();

            Stories.Save(story);

            this.Output = new MoveBacklogOperations { Id = this.Id };

            return 200;
        }

        public int Id { get; set; }

        public MoveBacklogOperations Output { get; private set; }
    }
}