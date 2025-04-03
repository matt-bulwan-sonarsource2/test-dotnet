namespace Miniblog.Core
{
    public class BlogSettings
    {
        public int CommentsCloseAfterDays { get; set; } = 10;

        public bool DisplayComments { get; set; } = false;

        public bool DisplayOwners6 { get; set; } = false;

        public PostListView ListView { get; set; } = PostListView.TitlesAndExcerpts;

        public string Owner { get; set; } = "The Matt";

        public int PostsPerPage { get; set; } = 4;
    }
}
