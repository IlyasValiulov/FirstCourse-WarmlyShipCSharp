namespace ProjectWarmlyShip.MovementStrategy;

public interface IMoveableObjects
{
    ObjectParameters? GetObjectPosition { get; }
    /// <summary>
    /// Шаг объекта
    /// </summary>
    int GetStep {  get; }
    /// <summary>
    /// Попытка переместить объект в указанном направлении
    /// </summary>
    /// <param name="direction"></param>
    /// <returns></returns>
    bool TryMoveObject(MovementDirection direction);
}
