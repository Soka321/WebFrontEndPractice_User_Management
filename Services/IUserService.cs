using Microsoft.AspNetCore.Authentication.BearerToken;
using WebFrontEndPractice.Models;
using WebFrontEndPractice.Models.DTOs;

namespace WebFrontEndPractice.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
        public void AddSingleUser(User user);

        public  Task<AccessTokenResponse> LoginUser(LoginDto user);
    }
}
