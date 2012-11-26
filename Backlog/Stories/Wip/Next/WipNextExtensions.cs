namespace Backlog.Stories.Wip.Next
{
    public static class WipNextExtensions
    {
        public static Story Next(this Story story)
        {
            story.State = StoryState.Done;

            return story;
        }
    }
}