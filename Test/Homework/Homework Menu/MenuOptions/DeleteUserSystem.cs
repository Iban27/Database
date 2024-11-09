using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu.MenuOptions
{
    public class DeleteUserSystem : IMenuSelectable
    {
        private readonly DataBase _dataBase;
        private readonly Menu _menu;

        public DeleteUserSystem(DataBase dataBase, Menu menu)
        {
            _dataBase = dataBase;
            _menu = menu;
        }

        public void Show()
        {
            TaskUtils.ShowText("___Удаление пользователя___");
            TaskUtils.ShowText("Укажите Имя пользователя");
            string userName = TaskUtils.GetInputString();
            DeleteUser(userName);

            Back();
        }

        private void DeleteUser(string userName)
        {
            User user = _dataBase.FindUserByName(userName);

            _dataBase.RemoveUser(user);

            TaskUtils.ShowText("Пользователь удалён");
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
