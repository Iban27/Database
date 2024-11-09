using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu
{
    public class DataBase
    {
        private List<User> _users = new List<User>();
        public IReadOnlyList<User> Users => _users;

        public DataBase()
        {
            _users = SaveSystem.Load();
        }

        public void AddUser(User user)
        {
            if (_users.Contains(user))
            {
                throw new Exception("Такой пользователь уже есть!");
            }
            else
            {
                _users.Add(user);
            }
            SaveSystem.Save(_users);
        }

        public void RemoveUser(User user)
        {
            if (_users.Contains(user))
            {
                _users.Remove(user);
                SaveSystem.Save(_users);
            }
            else
            {
                throw new Exception("Такого пользователя не существует!");
            }
        }

        public void DisplayUser(User user)
        {
            if (_users.Contains(user))
            {
                TaskUtils.ShowText($"Имя: {user.GetName}\nВозраст: {user.GetAge}\nВес: {user.GetWeight}");
            }
            else
            {
                throw new Exception("Такого пользователя не существует!");
            }
        }

        public User FindUserByName(string name)
        {
            foreach (var user in _users)
            {
                if (user.name == name)
                {
                    return user;
                }
            }
            throw new Exception("Такого пользователя не существует!");
        }
    }
}
