using ProjectWarmlyShip.Drawnings;
using ProjectWarmlyShip.Exceptions;

namespace ProjectWarmlyShip.CollectionGenericObjects;

public class MassiveGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Массив объектов, которые храним
    /// </summary>
    private T?[] _collection;
    public int Count => _collection.Length;
    public CollectionType GetCollectionType => CollectionType.Massive;
    public int MaxCount
    {
        get
        {
            return _collection.Length;
        }
        set
        {
            if (value > 0)
            {
                if (_collection.Length > 0)
                {
                    Array.Resize(ref _collection, value);
                }
                else
                {
                    _collection = new T?[value];
                }
            }
        }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    public MassiveGenericObjects()
    {
        _collection = Array.Empty<T?>();
    }
    public T Get(int position)
    {
        if (position >= _collection.Length || position < 0) throw new PositionOutOfCollectionException(position);
        if (_collection[position] == null) throw new ObjectNotFoundException(position);
        return _collection[position];
    }
    public int Insert(T obj, IEqualityComparer<T?>? comparer = null)
    {
        if (comparer != null)
        {
            foreach (T? item in _collection )
            {
                if ((comparer as IEqualityComparer<DrawningShip>).Equals(obj as DrawningShip, item as DrawningShip)) 
                    throw new ObjectIsEqualException();
            }
        }
        int index = 0;
        while (index < _collection.Length)
        {
            if (_collection[index] == null)
            {
                _collection[index] = obj;
                return index;
            }
            ++index;
        }
        throw new CollectionOverflowException(Count);
    }
    public int Insert(T obj, int position, IEqualityComparer<T?>? comparer = null)
    {
        if (comparer != null)
        {
            foreach (T? item in _collection)
            {
                if ((comparer as IEqualityComparer<DrawningShip>).Equals(obj as DrawningShip, item as DrawningShip)) 
                    throw new ObjectIsEqualException();
            }
        }
        if (position >= _collection.Length || position < 0) throw new PositionOutOfCollectionException(position);
        if (_collection[position] == null) {
            _collection[position] = obj;
            return position;
        }
        int index = position + 1;
        while (index < _collection.Length)
        {
            if (_collection[index] == null)
            {
                _collection[index] = obj;
                return index;
            }
            ++index;
        }
        index = position - 1;
        while (index >= 0)
        {
            if (_collection[index] == null)
            {
                _collection[index] = obj;
                return index;
            }
            --index;
        }
        throw new CollectionOverflowException(Count);
    }
    public T Remove(int position)
    {
        if (position >= _collection.Length || position < 0) throw new PositionOutOfCollectionException(position);
        if (_collection[position] == null) throw new ObjectNotFoundException(position);
        T obj = _collection[position];  
        _collection[position] = null;
        return obj;
    }
    public IEnumerable<T?> GetItems()
    {
        for (int i = 0; i < _collection.Length; ++i)
        {
            yield return _collection[i];
        }
    }
    void ICollectionGenericObjects<T>.CollectionSort(IComparer<T?> comparer)
    {
       Array.Sort(_collection, comparer);
    }
}