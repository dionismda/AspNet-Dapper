using AspNet_Dapper.Models;
using Microsoft.Data.SqlClient;

namespace AspNet_Dapper.Repositories
{
    public class RoleRepository : BaseRepository<Role>
    {
        private readonly SqlConnection _connection;

        public RoleRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }
    }
}
