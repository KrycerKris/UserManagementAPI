
using UserManagementAPI.Models;

namespace UserManagementAPI.Services {

    public class UserService
    {
        private readonly List<User> users = new List<User>();

        public User CreateUser(User user)
        {
            user.Id = users.Count + 1; // Simple ID assignment
            users.Add(user);
            return user;
        }

        public User GetUser(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User UpdateUser(int id, User updatedUser)
        {
            var user = GetUser(id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password; // Consider hashing passwords in a real application
            }
            return user;
        }

        public bool DeleteUser(int id)
        {
            var user = GetUser(id);
            if (user != null)
            {
                users.Remove(user);
                return true;
            }
            return false;
        }
    }

}