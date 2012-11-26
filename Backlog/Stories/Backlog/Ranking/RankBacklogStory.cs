namespace Backlog.Stories.Backlog.Ranking
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}/rank")]
    [LinksFrom(typeof(BacklogStory), "/stories/{Id}/rank", Rel = "story rank")]
    public class RankBacklogStory : IPut<Ranking>
    {
        public Status Put(Ranking input)
        {
            var story = Stories.By(this.Id);

            if (story == null)
            {
                return 404;
            }

            Stories.Save(story.Rank(input.Rank));

            return Status.SeeOther(BacklogUri.Backlog); ;
        }

        public int Id { get; set; }
    }
}