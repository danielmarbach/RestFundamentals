namespace Backlog.Stories.Backlog.Ranking
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}/rank")]
    [LinksFrom(typeof(BacklogStory), "/stories/{Id}/rank", Rel = "story reset rank")]
    public class ResetRank : IDelete
    {
        public Status Delete()
        {
            var story = Stories.By(this.Id);

            if (story == null)
            {
                return 404;
            }

            Stories.Save(story.Rank(100));

            return Status.SeeOther(BacklogUri.Backlog); ;
        }

        public int Id { get; set; }
    }
}