namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories")]
    [LinksFrom(typeof(StoryOperations), "/stories", Rel = "new story")]
    public class PostStory : IPost<NewStoryModel>
    {
        public Status Post(NewStoryModel input)
        {
            Story story = Stories.New().From(input);

            Stories.Save(story);

            return Status.Created;
        }
    }
}