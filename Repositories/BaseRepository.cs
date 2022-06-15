using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace AspNet_Dapper.Repositories
{
    public class BaseRepository<TClass> where TClass : class
    {
        private readonly SqlConnection _connection;

        public BaseRepository(SqlConnection connection) => _connection = connection;

        public void Create(TClass model) => _connection.Insert(model);

        public List<TClass> Read() => _connection.GetAll<TClass>().ToList();

        public TClass Read(int id) => _connection.Get<TClass>(id);

        public void Update(TClass model) => _connection.Update(model);

        public void Delete(TClass model) => _connection.Delete(model);
    }
}
