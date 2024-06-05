namespace ProjectWarmlyShip.CollectionGenericObjects;

public class CollectionInfo : IEquatable<CollectionInfo>
{
    public string Name { get; private set; }
    public CollectionType CollectionType { get; private set; }
    public string Description { get; private set; }
    private static readonly string _separator = "-";
    public CollectionInfo(string name, CollectionType collectionType, string description)
    {
        Name = name;
        CollectionType = collectionType;
        Description = description;
    }
    public static CollectionInfo? GetCollectionInfo(string data)
    {
        string[] strs = data.Split(_separator,
        StringSplitOptions.RemoveEmptyEntries);
        if (strs.Length < 1 || strs.Length > 3)
        {
            return null;
        }
        return new CollectionInfo(strs[0],
        (CollectionType)Enum.Parse(typeof(CollectionType), strs[1]), strs.Length > 2 ?
        strs[2] : string.Empty);
    }
    public override string ToString()
    {
        return Name + _separator + CollectionType + _separator + Description;
    }
    public bool Equals(CollectionInfo? other)
    {
        return Name == other?.Name;
    }
    public override bool Equals(object? obj)
    {
        return Equals(obj as CollectionInfo);
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
