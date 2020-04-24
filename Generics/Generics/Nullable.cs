namespace Generics
{
    //trying value type constraint
    public class Nullable<T> where T: struct
    {
        private readonly object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);

        }
    }
}
