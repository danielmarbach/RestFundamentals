namespace Backlog.Stories
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}")]
    [LinksFrom(typeof(Story), "/stories/{Id}", Rel = "story update")]
    public class PutStory : IPut<UpdateStoryModel>
    {
        public Status Put(UpdateStoryModel input)
        {
            var story = Stories.By(this.Id);

            if (story == null)
            {
                return 404;
            }

            Stories.Save(story.From(input));

            return 200;
        }

        public int Id { get; set; }
    }
}