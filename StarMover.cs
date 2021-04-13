using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStars
{
    class StarMover:IStarUpdater
    {
        private int _speedX;
        private int _speedY;

        public StarMover(Random random) 
        {
            _speedX = random.Next(-1, 2);
            _speedY = random.Next(-1, 2);
        }

        public void Update(Star star)
        {
            if (star.IsOnEdgeX) _speedX = -_speedX;
            if (star.IsOnEdgeY) _speedY = -_speedY;
            star.Move(_speedX, _speedY);
        }
    }
}
