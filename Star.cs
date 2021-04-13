using System;

namespace ConsoleStars
{
    public class Star
    {
        private const string _phaseChars = " .x*x.";
        protected int _x;
        protected int _y;
        private int _phase;
        private IStarUpdater[] _starUpdaters;
        public bool IsOnEdgeX => _x <= 1 || _x >= Console.WindowWidth - 1;
        public bool IsOnEdgeY => _y <= 1 || _y >= Console.WindowHeight - 1;

        public Star(int x, int y, int phase)
        {
            _x = x;
            _y = y;
            _phase = phase;
        }

        public Star(Random random, params IStarUpdater[] starUpdaters)
        {
            _starUpdaters = starUpdaters;
            _x = random.Next(1, Console.WindowWidth - 1);
            _y = random.Next(1, Console.WindowHeight - 1);
            _phase = random.Next(0, _phaseChars.Length);
        }



        public void Show()
        {
            Console.CursorLeft = _x;
            Console.CursorTop = _y;
            Console.Write(_phaseChars[_phase]);
        }

        public void NextPhase()
        {
            _phase++;
            if (_phase == _phaseChars.Length) _phase = 0;
        }

        public virtual void Update()
        {
            if (_starUpdaters != null)
            {
                foreach (var starUpdater in _starUpdaters)
                {
                    starUpdater.Update(this);
                }
            }

        }

        internal void Move(int speedX, int speedY)
        {
            _x += speedX;
            _y += speedY;
        }
    }
}
