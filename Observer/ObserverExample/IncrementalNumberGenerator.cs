namespace ObserverExample
{
    public class IncrementalNumberGenerator : NumberGenerator
    {
        private int _startNumber;
        private int _endNumber;
        private int _increaseSteps;
        private int _currentNumber;

        public IncrementalNumberGenerator(int startNumber, int endNumber, int increaseSteps)
        {
            _startNumber = startNumber;
            _endNumber = endNumber;
            _increaseSteps = increaseSteps;
            _currentNumber = _startNumber;
        }

        public override int GetNumber()
        {
            return _currentNumber;
        }

        public override void Execute()
        {
            while (_currentNumber < _endNumber)
            {
                NotifyObservers();
                _currentNumber = GetNextNumber();   
            }
        }

        private int GetNextNumber()
        {
            return _currentNumber + _increaseSteps;
        }
    }
}