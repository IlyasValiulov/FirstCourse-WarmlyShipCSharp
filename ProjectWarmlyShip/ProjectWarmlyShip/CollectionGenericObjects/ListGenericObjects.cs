using ProjectWarmlyShip.Exceptions;

namespace ProjectWarmlyShip.CollectionGenericObjects;

public class ListGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Список объектов, которые храним
    /// </summary>
    private readonly List<T?> _collection;
    public CollectionType GetCollectionType => CollectionType.List;
    /// <summary>
    /// Максимально допустимое число объектов в списке
    /// </summary>
    private int _maxCount;
    public int Count => _collection.Count;
    public int MaxCount {
        get
        {
            return Count;
        }
        set 
        { 
            if (value > 0) 
            { 
                _maxCount = value; 
            } 
        } 
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    public ListGenericObjects()
    {
        _collection = new();
    }
    public T? Get(int position)
    {
        if (position >= Count || position < 0) throw new PositionOutOfCollectionException(position);
        return _collection[position];
    }
    public int Insert(T obj, IEqualityComparer<T?>? comparer = null)
    {
        if (comparer != null)
        {
            if (_collection.Contains(obj, comparer))
            {
                throw new ObjectIsEqualException();
            }
        }
        if (Count == _maxCount) throw new CollectionOverflowException(Count);
        _collection.Add(obj);
        return Count;
    }
    public int Insert(T obj, int position, IEqualityComparer<T?>? comparer = null)  
    {
        if (comparer != null)
        {
            if (_collection.Contains(obj, comparer))
            {
                throw new ObjectIsEqualException();
            }
        }
        if (Count == _maxCount) throw new CollectionOverflowException(Count);
        if (position >= Count || position < 0) throw new PositionOutOfCollectionException(position);
        _collection.Insert(position, obj);
        return position;
    }
    public T Remove(int position)
    {
        if (position >= Count || position < 0) throw new PositionOutOfCollectionException(position);
        T obj = _collection[position];
        _collection.RemoveAt(position);
        return obj;
    }
    public IEnumerable<T?> GetItems()
    {
        for (int i = 0; i < Count; ++i)
        {
            yield return _collection[i];
        }
    }
    void ICollectionGenericObjects<T>.CollectionSort(IComparer<T?> comparer)
    {
        _collection.Sort(comparer);
    }
}
