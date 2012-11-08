namespace Backlog.Stories
{
    public class Story
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }

    public class UpdateStoryModel
    {
        public string Text { get; set; }
    }

    public class NewStoryModel
    {
        public string Text { get; set; }
    }

    public static class StoryExtensions
    {
        public static Story From(this Story story, UpdateStoryModel update)
        {
            story.Text = update.Text;

            return story;
        }

        public static Story From(this Story story, NewStoryModel update)
        {
            story.Text = update.Text;

            return story;
        }
    }
}