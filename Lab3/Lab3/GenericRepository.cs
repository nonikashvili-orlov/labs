namespace Lab3
{
    public interface IRepository<T>
    {
    }
    public class GenericRepository<T> : IRepository<T>
    {
        public override string ToString()
        {
            return "Репозиторий с типом : " + typeof(T).Name;
        }
    }
}