using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStars
{
    class MyApp : IClickHandler
    {
        private MyButton _myButton;
        int _counter;

        public MyApp()
        {
            _myButton = new MyButton();
            _myButton.ClickHandler = this;
        }

        public void HandleClick()
        {
            _counter++;
        }
    }
}
