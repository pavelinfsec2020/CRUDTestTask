using System.Xml.Serialization;

public class XmlUserRepository : IUserRepository
{
    private readonly string _filePath;
    private List<User> _users;

    public XmlUserRepository(string filePath)
    {
        _filePath = filePath;
        LoadUsers();
    }

    private void LoadUsers()
    {
        if (File.Exists(_filePath))
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var stream = File.OpenRead(_filePath))
            {
                _users = (List<User>)serializer.Deserialize(stream);
            }
        }
        else
        {
            _users = new List<User>();
        }
    }

    private void SaveUsers()
    {
        var serializer = new XmlSerializer(typeof(List<User>));
        using (var stream = File.Create(_filePath))
        {
            serializer.Serialize(stream, _users);
        }
    }

    public IEnumerable<User> GetAll() => _users;

    public User GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id);

    public void Add(User user)
    {
        if (_users.Any(u => u.Login == user.Login))
            throw new InvalidOperationException("Пользователь с данным логином уже существует!");

        if (string.IsNullOrEmpty(user.Login))
            throw new ArgumentException("Логин не может быть пустым!");

        _users.Add(user);
        SaveUsers();
    }

    public void Update(User user)
    {
        if (_users.Any(u => u.Id == user.Id))
            throw new InvalidOperationException("Не найден пользователь с данным id!");

        var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
        existingUser.Login = user.Login;
        existingUser.FirstName = user.FirstName;
        existingUser.LastName = user.LastName;
        
        SaveUsers();
    }

    public void Delete(Guid id)
    {
        if (_users.Any(u => u.Id == id))
            throw new InvalidOperationException("Не найден пользователь с данным id!");
       
        var user = _users.FirstOrDefault(u => u.Id == id);
        _users.Remove(user);
        SaveUsers();
    }
}