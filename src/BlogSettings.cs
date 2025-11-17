namespace Miniblog.Core
{
    public class BlogSettings
    {
        public int CommentsCloseAfterDays { get; set; } = 45;

        public bool DisplayComments { get; set; } = true;

        public bool DisplayOwners3 { get; set; } = false;

        public PostListView ListView { get; set; } = PostListView.TitlesAndExcerpts;

        public string Owner { get; set; } = "The Matt!!!";

        public int PostsPerPage { get; set; } = 4;
    }
}
