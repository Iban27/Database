﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Homework.Homework_Menu
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();

            Menu menu = new Menu(dataBase);
            menu.ShowWelcomeText();
        }
    }
}