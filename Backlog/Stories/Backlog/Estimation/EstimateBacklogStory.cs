namespace Backlog.Stories.Backlog.Estimation
{
    using Simple.Web;
    using Simple.Web.Links;

    [UriTemplate("/stories/{Id}/estimation")]
    [LinksFrom(typeof(BacklogStory), "/stories/{Id}/estimation", Rel = "story estimation")]
    public class EstimateBacklogStory : IPut<Estimation>
    {
        public Status Put(Estimation input)
        {
            var story = Stories.By(this.Id);

            if (story == null)
            {
                return 404;
            }

            Stories.Save(story.Estimate(input.Points));

            return Status.SeeOther(BacklogUri.Backlog);
        }

        public int Id { get; set; }
    }
}