using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu.MenuOptions
{
    public class SearchUserSystem : IMenuSelectable
    {
        private readonly DataBase _dataBase;
        private readonly Menu _menu;

        public SearchUserSystem(DataBase dataBase, Menu menu)
        {
            _dataBase = dataBase;
            _menu = menu;
        }

        public void Show()
        {
            TaskUtils.ShowText("___Поиск пользователя___");
            TaskUtils.ShowText("Укажите Имя пользователя");
            string userName = TaskUtils.GetInputString();

            SearchUser(userName);

            Back();
        }

        public void SearchUser(string userName)
        {
            User user = _dataBase.FindUserByName(userName);

            _dataBase.DisplayUser(user);

            //TaskUtils.ShowText($"Имя - {user.name}, Возраст - {user.age}, Вес - {user.weight}");
        }

        public void Back()
        {
            TaskUtils.ShowText("Нажмите 0 чтобы выйти в главное меню");

            if (TaskUtils.GetInputInt() == 0)
            {
                Console.Clear();
                _menu.ShowWelcomeText();
            }
        }
    }
}
