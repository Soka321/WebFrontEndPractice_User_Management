using Microsoft.AspNetCore.Authentication.BearerToken;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebFrontEndPractice.Models;
using WebFrontEndPractice.Models.DTOs;

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

        public async Task<AccessTokenResponse> login(LoginDto user)
        {
            var response = await _client.PostAsJsonAsync($"https://localhost:7115/Login", user);
            response.EnsureSuccessStatusCode();
            var tokenResponse = await response.Content.ReadFromJsonAsync<AccessTokenResponse>();
            return tokenResponse!;
        }

        
    }
}
