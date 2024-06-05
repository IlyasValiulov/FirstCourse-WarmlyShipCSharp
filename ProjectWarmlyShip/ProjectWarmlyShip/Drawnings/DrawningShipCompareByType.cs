namespace ProjectWarmlyShip.Drawnings;

public class DrawningShipCompareByType : IComparer<DrawningShip?>
{
    public int Compare(DrawningShip? x, DrawningShip? y)
    {
        if (x == null || x.EntityShip == null)
        {
            return 1;
        }

        if (y == null || y.EntityShip == null)
        {
            return -1;
        }

        if (x.GetType().Name != y.GetType().Name)
        {
            return x.GetType().Name.CompareTo(y.GetType().Name);
        }

        var speedCompare = x.EntityShip.Speed.CompareTo(y.EntityShip.Speed);
        if (speedCompare != 0)
        {
            return speedCompare;
        }
        return x.EntityShip.Weight.CompareTo(y.EntityShip.Weight);
    }
}
