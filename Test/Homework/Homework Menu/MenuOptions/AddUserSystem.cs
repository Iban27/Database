using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu.MenuOptions
{
    public class AddUserSystem : IMenuSelectable
    {
        
        private readonly DataBase _dataBase;
        private readonly Menu _menu;

        public AddUserSystem(DataBase dataBase, Menu menu)
        {
            _dataBase = dataBase;
            _menu = menu;
        }

        public void Show()
        {
            TaskUtils.ShowText("___Добавление нового пользователя___");
            TaskUtils.ShowText("Укажите Имя пользователя");
            string userName = TaskUtils.GetInputString();
            TaskUtils.ShowText("Укажите Возраст пользователя");
            int userAge = TaskUtils.GetInputInt();
            TaskUtils.ShowText("Укажите Вес пользователя");
            float userWeight = TaskUtils.GetInputFloat();
            AddUser(userName, userAge, userWeight);
        }

        private void AddUser(string userName, int userAge, float userWeight)
        {
            User user = new User(userName, userAge, userWeight);

            _dataBase.AddUser(user);

            TaskUtils.ShowText("Пользователь добавлен");
            Back();
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

