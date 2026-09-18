using Microsoft.AspNetCore.Authentication.BearerToken;
using WebFrontEndPractice.Models;
using WebFrontEndPractice.Models.DTOs;

namespace WebFrontEndPractice.Repositories
{
    public interface IUserRepo
    {
        public Task<List<User>> GetUsers();
        public void AddUser(User user);

        public Task<AccessTokenResponse> login(LoginDto user);
    }
}
