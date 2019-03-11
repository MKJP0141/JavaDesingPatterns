using System.Collections.Generic;

namespace ObserverExample
{
    public abstract class NumberGenerator
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DeleteObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public virtual void NotifyObservers()
        {
            var it = _observers.GetEnumerator();
            while (it.MoveNext())
            {
                var observer = it.Current;
                observer.Update(this);
            }
        }

        public abstract int GetNumber();

        public abstract void Execute();
    }
}