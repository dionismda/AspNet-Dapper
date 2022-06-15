using AspNet_Dapper.Models;
using Microsoft.Data.SqlClient;

namespace AspNet_Dapper.Repositories
{
    public class TagRepository : BaseRepository<Tag>
    {
        private readonly SqlConnection _connection;

        public TagRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }
    }
}
