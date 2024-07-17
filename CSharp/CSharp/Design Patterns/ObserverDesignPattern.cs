using System.Drawing;

namespace CSharp
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void ColorChanged(Color newColor);
    }

    public class ColorSubject : ISubject
    {
        private Color _Color = Color.Blue;

        public Color Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                Notify();
            }
        }

        private HashSet<IObserver> _observers = new HashSet<IObserver>();

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ToList().ForEach(o => o.ColorChanged(Color));
        }

    }
}