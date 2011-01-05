namespace Refuctobation
{
    public abstract class Handler<T> : IHandler
    {
        public abstract void Do(T message);
    }
}