namespace Backlog.Stories.Backlog.Modification
{
    public static class ModificationExtensions
    {
        public static Story From(this Story story, BacklogUpdate backlogUpdate)
        {
            story.Text = backlogUpdate.Text;

            return story;
        }
    }
}