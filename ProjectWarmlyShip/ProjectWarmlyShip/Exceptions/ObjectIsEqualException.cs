using System.Runtime.Serialization;

namespace ProjectWarmlyShip.Exceptions;

/// <summary>
/// Класс, описывающий ошибку переполнения коллекции
/// </summary>
[Serializable]
public class ObjectIsEqualException : ApplicationException
{
    public ObjectIsEqualException(int count) : base("В коллекции содержится равный элемент: " + count) { }
    public ObjectIsEqualException() : base() { }
    public ObjectIsEqualException(string message) : base(message) { }
    public ObjectIsEqualException(string message, Exception exception) : base(message, exception) { }
    protected ObjectIsEqualException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
}
