using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu.MenuOptions
{
    public class ShowInfoSystem : IMenuSelectable
    {
        private readonly Menu _menu;

        public ShowInfoSystem(Menu menu)
        {
            this._menu = menu;
        }

        public void Show()
        {
            TaskUtils.ShowText("___О программе___");
            TaskUtils.ShowText("Программа для хранения информации о пользователях в базе данных\n" +
                "Автор: Ибрагимов Имран\n" +
                "Дата релиза: 03.11.2024");
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
