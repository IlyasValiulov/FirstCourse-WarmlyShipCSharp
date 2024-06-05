using System.Runtime.Serialization;

namespace ProjectWarmlyShip.Exceptions;

/// <summary>
/// Класс, описывающий ошибку, что по указанной позиции нет элемента
/// </summary>
[Serializable]
internal class ObjectNotFoundException : ApplicationException
{
    public ObjectNotFoundException(int i) : base("Не найден объект по позиции " + i) { }
    public ObjectNotFoundException() : base() { }
    public ObjectNotFoundException(string message) : base(message) { }
    public ObjectNotFoundException(string message, Exception exception) : base(message, exception) { }
    protected ObjectNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
}
