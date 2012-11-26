namespace Backlog.Stories.Backlog.Modification
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate(BacklogUri.Backlog + "/{Id}")]
    [LinksFrom(typeof(BacklogStory), BacklogUri.Backlog + "/{Id}", Rel = "story update")]
    public class ModifyBacklogStory : IPut<BacklogUpdate>
    {
        public Status Put(BacklogUpdate input)
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