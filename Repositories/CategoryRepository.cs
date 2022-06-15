using AspNet_Dapper.Models;
using Microsoft.Data.SqlClient;

namespace AspNet_Dapper.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        private readonly SqlConnection _connection;

        public CategoryRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }
    }
}
