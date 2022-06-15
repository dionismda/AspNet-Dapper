using AspNet_Dapper.Models;
using Microsoft.Data.SqlClient;

namespace AspNet_Dapper.Repositories
{
    public class PostRepository : BaseRepository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }
    }
}
