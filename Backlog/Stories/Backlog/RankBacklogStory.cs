namespace Backlog.Stories.Backlog
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}/rank")]
    [LinksFrom(typeof(BacklogStory), "/stories/{Id}/rank", Rel = "story rank")]
    public class RankBacklogStory : IPut<Ranking>
    {
        public Status Put(Ranking input)
        {
            var story = Stories.By(this.Id).Rank(input.Rank);

            Stories.Save(story);

            return Status.SeeOther(BacklogUri.Backlog); ;
        }

        public int Id { get; set; }
    }

    [UriTemplate("/stories/{Id}/rank")]
    [LinksFrom(typeof(BacklogStory), "/stories/{Id}/rank", Rel = "story reset rank")]
    public class ResetRank : IDelete
    {
        public Status Delete()
        {
            var story = Stories.By(this.Id).Rank(100);

            Stories.Save(story);

            return Status.SeeOther(BacklogUri.Backlog); ;
        }

        public int Id { get; set; }
    }
}