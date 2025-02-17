namespace CRUDTestTask.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers() => _userRepository.GetAll();

        public User GetUserById(Guid id) => _userRepository.GetById(id);

        public void AddUser(User user) => _userRepository.Add(user);

        public void UpdateUser(User user) => _userRepository.Update(user);

        public void DeleteUser(Guid id) => _userRepository.Delete(id);
    }
}
