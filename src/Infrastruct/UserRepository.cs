using BackEndRu.src.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace BackEndRu.src.Infrastruct;
public class UserRepository : IUserRepository
{
    public string ConnString { get; set; } = "Server=db;Port=3307;Database=software_ru;Uid=root;Pwd=root;";

    public IEnumerable<User> GetUsers()
    {
        List<User> users;
        using (var conn = new MySqlConnection(ConnString))
        {
            var query = "SELECT * FROM user";
            conn.Open();
            users = conn.Query<User>(query).ToList();
        }
        return users.AsEnumerable();
    }

}

