namespace MidApp.Data
{
    public class DataStore
    {
        public List<Post> Posts { get; set; } = new List<Post>
        {
            new Post
            {
                Id = 1,
                AuthorName = "John Doe",
                Content = "This is the first post.",
                Likes = 10,
                Dislikes = 2
            },
            new Post
            {
                Id = 2,
                AuthorName = "Jane Smith",
                Content = "This is the second post.",
                Likes = 5,
                Dislikes = 1
            }
        };

        public Profile UserProfile { get; set; } = new Profile();
    }
}
