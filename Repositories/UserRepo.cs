using System.Net.Http.Json;
using WebFrontEndPractice.Models;

namespace WebFrontEndPractice.Repositories
{
    public class UserRepo : IUserRepo
    {
        private HttpClient _client;
        public UserRepo(HttpClient client) { 
            _client = client;
        }
        public async void AddUser(User user)
        {
             await _client.PostAsJsonAsync($"https://localhost:7115/AddUser",user);
            
        }

        public async Task<List<User>> GetUsers()
        {
            return await _client.GetFromJsonAsync<List<User>>($"https://localhost:7115/Users");
        }
    }
}
