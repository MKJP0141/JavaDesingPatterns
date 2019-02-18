namespace Decorator
{
    public abstract class Border : Display
    {
        protected Display _display;

        protected Border(Display display)
        {
            _display = display;
        }
    }
}