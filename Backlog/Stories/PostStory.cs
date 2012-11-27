namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Links;

    [UriTemplate("/stories")]
    [LinksFrom(typeof(StoryOperations), "/stories", Rel = "new story")]
    [LinksFrom(typeof(PostStoryOperations), "/stories/backlog", Rel = "stories backlog")]
    [Canonical(typeof(PostStoryOperations), "/stories/backlog/{Id}")]
    public class PostStory : IPost<NewStoryModel>, IOutput<PostStoryOperations>
    {
        public Status Post(NewStoryModel input)
        {
            Story story = Stories.New().From(input);

            Stories.Save(story);

            this.Output = new PostStoryOperations { Id = story.Id };

            return Status.Created;
        }

        public PostStoryOperations Output { get; private set; }
    }
}