using ProjectWarmlyShip.Drawnings;

namespace ProjectWarmlyShip.MovementStrategy;

public class MoveableShip : IMoveableObjects
{
    private DrawningShip? _drawningship;
    public MoveableShip(DrawningShip? drawningship)
    {
        _drawningship = drawningship;
    }
    public ObjectParameters? GetObjectPosition
    {
        get
        {
            if (_drawningship == null || _drawningship.EntityShip == null || !_drawningship.GetPosX.HasValue || !_drawningship.GetPosY.HasValue)
            {
                return null;
            }
            return new ObjectParameters(_drawningship.GetPosX.Value, _drawningship.GetPosY.Value, _drawningship.GetWidht, _drawningship.GetHeight);
        }
    }
    public int GetStep => (int)(_drawningship?.EntityShip?.Step ?? 0);
    public bool TryMoveObject(MovementDirection direction)
    {
        if (_drawningship == null || _drawningship.EntityShip == null)
        {
            return false;
        }
        return _drawningship.MoveTransport(GetDirectionType(direction));
    }
    /// <summary>
    /// Конвертация из MovementDirection в DirectionType
    /// </summary>
    /// <param name="direction">MovementDirection</param>
    /// <returns>DirectionType</returns>
    private static DirectionType GetDirectionType(MovementDirection direction)
    {
        return direction switch
        {
            MovementDirection.Left => DirectionType.Left,
            MovementDirection.Right => DirectionType.Right,
            MovementDirection.Up => DirectionType.Up,
            MovementDirection.Down => DirectionType.Down,
            _ => DirectionType.Unknow,
        };
    }
}
