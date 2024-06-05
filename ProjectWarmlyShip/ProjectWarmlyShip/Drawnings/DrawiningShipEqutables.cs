using ProjectWarmlyShip.Entities;
using System.Diagnostics.CodeAnalysis;

namespace ProjectWarmlyShip.Drawnings;

public class DrawiningShipEqutables : IEqualityComparer<DrawningShip?>
{
    public bool Equals(DrawningShip? x, DrawningShip? y)
    {
        if (x == null || x.EntityShip == null)
        {
            return false;
        }
        if (y == null || y.EntityShip == null)
        {
            return false;
        }
        if (x.GetType().Name != y.GetType().Name)
        {
            return false;
        }
        if (x.EntityShip.Speed != y.EntityShip.Speed)
        {
            return false;
        }
        if (x.EntityShip.Weight != y.EntityShip.Weight)
        {
            return false;
        }
        if (x.EntityShip.BodyColor != y.EntityShip.BodyColor)
        {
            return false;
        }
        if (x is DrawningWarmlyShip && y is DrawningWarmlyShip)
        {
            EntityWarmlyShip _x = (EntityWarmlyShip)x.EntityShip;
            EntityWarmlyShip _y = (EntityWarmlyShip)x.EntityShip;
            if (_x.AdditionalColor != _y.AdditionalColor)
            {
                return false;
            }
            if (_x.ShipPipes != _y.ShipPipes)
            {
                return false;
            }
            if (_x.FuelTank != _y.FuelTank)
            {
                return false;
            }
        }
        return true;
    }
    public int GetHashCode([DisallowNull] DrawningShip obj)
    {
        return obj.GetHashCode();
    }
}
