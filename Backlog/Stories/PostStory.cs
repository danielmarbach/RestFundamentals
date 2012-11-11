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
            Stories.Save(Stories.New().From(input));

            return Status.Created;
        }
    }
}