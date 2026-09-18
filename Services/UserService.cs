using Microsoft.AspNetCore.Authentication.BearerToken;
using WebFrontEndPractice.Models;
using WebFrontEndPractice.Models.DTOs;
using WebFrontEndPractice.Repositories;

namespace WebFrontEndPractice.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _repo;

        public UserService(IUserRepo repo)
        {
            _repo = repo;
        }

        public  void AddSingleUser(User user)
        {
           _repo.AddUser(user);
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        

       public Task<AccessTokenResponse> LoginUser(LoginDto user)
        {
          return _repo.login(user);
        }
    }
}
