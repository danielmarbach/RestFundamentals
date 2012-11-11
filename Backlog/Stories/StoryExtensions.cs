namespace Backlog.Stories
{
    using System;

    using Simple.Web.Links;

    public static class StoryExtensions
    {
        public static Story Next(this Story story)
        {
            switch (story.State)
            {
                case StoryState.Backlog:
                    story.State = StoryState.Wip;
                    break;
                case StoryState.Wip:
                    story.State = StoryState.Done;
                    break;
                case StoryState.Done:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

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