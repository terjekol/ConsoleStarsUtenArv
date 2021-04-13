using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStars
{
    class StarPhaseChanger:IStarUpdater
    {
        public void Update(Star star)
        {
            star.NextPhase();
        }
    }
}
