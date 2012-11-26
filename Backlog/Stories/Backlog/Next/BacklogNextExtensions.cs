namespace Backlog.Stories.Backlog.Next
{
    public static class BacklogNextExtensions
    {
        public static Story Next(this Story story)
        {
            story.State = StoryState.Wip;

            return story;
        }
    }
}