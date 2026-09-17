using WebFrontEndPractice.Models;

namespace WebFrontEndPractice.Services
{
    public interface IUserService
    {
        public  Task<List<User>> GetAllUsers();
        public  Task<User> AddSingleUser(User user);
    }
}
