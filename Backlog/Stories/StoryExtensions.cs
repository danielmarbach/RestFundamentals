namespace Backlog.Stories
{
    public static class StoryExtensions
    {
        public static Story From(this Story story, NewStoryModel @new)
        {
            story.Text = @new.Text;

            if (@new.Rank.HasValue)
                story.Rank = @new.Rank.Value;

            return story;
        }
    }
}