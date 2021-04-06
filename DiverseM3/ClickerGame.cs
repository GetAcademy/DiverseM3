namespace DiverseM3
{
    class ClickerGame
    {
        public int Count { get; private set; }
        private IHandler _program;

        public ClickerGame(IHandler program)
        {
            _program = program;
        }

        public void Click()
        {
            Count++;
            if (Count == 10)
            {
                _program.Show10();
            }
        }
    }
}
