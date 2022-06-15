using AspNet_Dapper.Models;
using AspNet_Dapper.Repositories;
using Microsoft.Data.SqlClient;

namespace AspNet_Dapper
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Futur@1313;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            BaseRepository<User> repository = new BaseRepository<User>(connection);

            CreateUser(repository);
            UpdateUser(repository);
            DeleteUser(repository);
            ReadUser(repository);
            ReadUsers(repository);
            ReadWithRoles(connection);
        }

        private static void CreateUser(BaseRepository<User> repository)
        {
            User user = new User
            {
                Bio = "teste bio",
                Email = "teste@teste.com.br",
                Image = "https://teste.jpg",
                Name = "User teste",
                Slug = "User-Teste",
                PasswordHash = Guid.NewGuid().ToString()
            };

            repository.Create(user);
        }

        private static void ReadUsers(BaseRepository<User> repository)
        {
            List<User> users = repository.Read();
            foreach (var item in users)
                Console.WriteLine(item.Email);
        }

        private static void ReadUser(BaseRepository<User> repository)
        {
            User user = repository.Read(2);
            Console.WriteLine(user?.Email);
        }

        private static void UpdateUser(BaseRepository<User> repository)
        {
            User user = repository.Read(2);
            user.Email = "teste2@teste.com.br";
            repository.Update(user);

            Console.WriteLine(user?.Email);
        }

        private static void DeleteUser(BaseRepository<User> repository)
        {
            User user = repository.Read(2);
            repository.Delete(user);
        }

        private static void ReadWithRoles(SqlConnection connection)
        {
            UserRepository repository = new UserRepository(connection);
            List<User> users = repository.ReadWithRole();

            foreach (var user in users)
            {
                Console.WriteLine(user.Email);
                foreach (var role in user.Roles) Console.WriteLine($" - {role.Slug}");
            }
        }

    }
}