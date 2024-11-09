using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu.MenuOptions
{
    public class DisplayUserSystem : IMenuSelectable
    {
        private readonly DataBase _dataBase;
        private readonly Menu _menu;

        public DisplayUserSystem(DataBase dataBase, Menu menu)
        {
            _dataBase = dataBase;
            _menu = menu;
        }

        public void Show()
        {
            TaskUtils.ShowText("___Отобразить пользователей___");
            
            DisplayUsers();

            Back();
        }

        public void DisplayUsers()
        {
            int i = 0;
            foreach (var user in _dataBase.Users)
            {
                TaskUtils.ShowText($"Имя пользователя: {user.name}; ID пользователя: {i}");
                i++;
            }
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
