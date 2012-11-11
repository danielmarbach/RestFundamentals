namespace Backlog.Stories.Backlog
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}/estimation")]
    [LinksFrom(typeof(BacklogStory), "/stories/{Id}/estimation", Rel = "story estimation")]
    public class EstimateBacklogStory : IPut<Estimation>
    {
        public Status Put(Estimation input)
        {
            var story = Stories.By(this.Id).Estimate(input.Points);

            Stories.Save(story);

            return Status.SeeOther(BacklogUri.Backlog); ;
        }

        public int Id { get; set; }
    }
}