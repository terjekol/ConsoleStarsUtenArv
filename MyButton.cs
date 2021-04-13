using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStars
{
    class MyButton
    {
        public IClickHandler ClickHandler { get; set; }

        public void DoWork()
        {
            // if button is clicked
            ClickHandler.HandleClick();
        }
    }
}
