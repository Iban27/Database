using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Homework.Homework_Menu.MenuOptions;

namespace Test.Homework.Homework_Menu
{
    public class Menu
    {
        private readonly IMenuSelectable[] _menuSelectables;

        public Menu(DataBase dataBase)
        {
            _menuSelectables = new IMenuSelectable[]
            {
                new AddUserSystem(dataBase, this),
                new DeleteUserSystem(dataBase, this),
                new SearchUserSystem(dataBase, this),
                new DisplayUserSystem(dataBase, this)
            };
        }

        public void ShowWelcomeText()
        {
            TaskUtils.ShowText("Добро Пожаловать!", bottom:true);
            TaskUtils.ShowText("Нажмите 1, чтобы добавить пользователя");
            TaskUtils.ShowText("Нажмите 2, чтобы удалить пользователя");
            TaskUtils.ShowText("Нажмите 3, чтобы найти пользователя");
            TaskUtils.ShowText("Нажмите 4, чтобы отобразить пользователя");
            TaskUtils.ShowText("Нажмите 5, чтобы вывести информацию о программе");

            int input = TaskUtils.GetInputInt();

            _menuSelectables[input - 1].Show();
        }
    }
}
