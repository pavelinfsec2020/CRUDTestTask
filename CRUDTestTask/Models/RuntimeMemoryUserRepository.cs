namespace CRUDTestTask.Models
{
    internal class RuntimeMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public IEnumerable<User> GetAll() => _users;

        public User GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            if (_users.Any(u => u.Login == user.Login))
                throw new InvalidOperationException("Пользователь с таким логином уже присутствует в системе!");

            if (string.IsNullOrEmpty(user.Login))
                throw new ArgumentException("Логин не может быть пустой строкой!");

            //Тут можно добавить множество проверок на валидацию добавляемого пользователя.

            _users.Add(user);
        }

        public void Update(User user)
        {
            if (!_users.Any(u => u.Id == user.Id))
                throw new ArgumentException("Пользователя с данным id не существует!");

            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            existingUser.Login = user.Login;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
        }

        public void Delete(Guid id)
        {
            if (!_users.Any(u => u.Id == id))
                throw new ArgumentException("Пользователя с данным id не существует!");

            var user = _users.FirstOrDefault(u => u.Id == id);
            _users.Remove(user);
        }
    }
}
