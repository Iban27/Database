using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test.Homework.Homework_Menu
{
    public interface IMenuSelectable
    {
        void Show();
        void Back();
    }
}
