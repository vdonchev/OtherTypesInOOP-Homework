namespace _03.GenericList
{
    public interface IGenericList<T>
    {
        int Capacity { get; }

        int Size { get; }

        void Add(T item);

        void RemoveAt(int index);

        void AddRange(params T[] items);

        void Clear();

        int GetIndex(T item);

        bool Contains(T item);

        T this[int index] { get; set; }

        string Version();
    }
}