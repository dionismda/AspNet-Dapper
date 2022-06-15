using Dapper.Contrib.Extensions;

namespace AspNet_Dapper.Models
{
    [Table("[Tag]")]
    public class Tag
    {

        public Tag()
        {
            Posts = new List<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;

        [Write(false)]
        public List<Post> Posts { get; set; }
    }
}
