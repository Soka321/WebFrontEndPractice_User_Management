using WebFrontEndPractice.Models;

namespace WebFrontEndPractice.Repositories
{
    public interface IUserRepo
    {
        public Task<List<User>> GetUsers();
        public void AddUser(User user);
    }
}
