using Dapper.Contrib.Extensions;

namespace AspNet_Dapper.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
        {
            Tags = new List<Tag>();
            Author = new User();
            Category = new Category();
        }

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int AuthorId { get; set; }
        [Write(false)]
        public User Author { get; set; }

        public int CategoryId { get; set; }
        [Write(false)]
        public Category Category { get; set; }
        [Write(false)]
        public List<Tag> Tags { get; set; }
    }
}
