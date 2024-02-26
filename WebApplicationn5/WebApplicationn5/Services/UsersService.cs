using System.Text.Json;

namespace WebApplicationn5.Services
{
    public class UsersService : IUsersService
    {
        public string GetCurrentUser()
        {
            string jsonString = File.ReadAllText("currentUserInfo.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var user = JsonSerializer.Deserialize<UserInfo>(jsonString, options);

            return user.ToString();
        }

        public string GetUserByID(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("The ID must be equal to or greater than 0.", nameof(id));
            }

            string jsonString = File.ReadAllText("usersInfo.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var usersResponse = JsonSerializer.Deserialize<UsersResponse>(jsonString, options);

            foreach (var user in usersResponse.Users)
            {
                if (user.IdUser == id)
                {
                    return user.ToString();
                }
            }

            return GetCurrentUser();
        }
    }
}
