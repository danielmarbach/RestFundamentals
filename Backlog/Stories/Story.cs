namespace Backlog.Stories
{
    public enum State
    {
        Backlog,
        WorkInProgress,
        Done,
    }

    public class Story
    {
        public int Id { get; set; }

        public int Rank { get; set; }

        public int Points { get; set; }

        public State State { get; set; }

        public string Text { get; set; }
    }

    public class UpdateStoryModel
    {
        public string Text { get; set; }

        public int? Points { get; set; }

        public int? Rank { get; set; }
    }

    public class NewStoryModel
    {
        public string Text { get; set; }

        public int? Rank { get; set; }
    }

    public static class StoryExtensions
    {
        public static Story From(this Story story, UpdateStoryModel update)
        {
            story.Text = update.Text;

            if(update.Points.HasValue)
                story.Points = update.Points.Value;

            if (update.Rank.HasValue)
                story.Rank = update.Rank.Value;

            return story;
        }

        public static Story From(this Story story, NewStoryModel @new)
        {
            story.Text = @new.Text;

            if (@new.Rank.HasValue)
                story.Rank = @new.Rank.Value;

            return story;
        }
    }
}