using System.Runtime.Serialization;

namespace ProjectWarmlyShip.Exceptions;

/// <summary>
/// Класс, описывающий ошибку выхода за границы коллекции
/// </summary>
[Serializable]
internal class PositionOutOfCollectionException : ApplicationException
{
    public PositionOutOfCollectionException(int i) : base("Выход за границы коллекции.Позиция " + i) { }
    public PositionOutOfCollectionException() : base() { }
    public PositionOutOfCollectionException(string message) : base(message) { }
    public PositionOutOfCollectionException(string message, Exception exception) : base(message, exception) { }
    protected PositionOutOfCollectionException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
}