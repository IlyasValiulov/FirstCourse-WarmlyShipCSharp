namespace ProjectWarmlyShip.Drawnings;

public class DrawningShipCompareByColor : IComparer<DrawningShip?>
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
        var bodycolorCompare = x.EntityShip.BodyColor.Name.CompareTo(y.EntityShip.BodyColor.Name);
        if (bodycolorCompare != 0)
        {
            return bodycolorCompare;
        }
        var speedCompare = x.EntityShip.Speed.CompareTo(y.EntityShip.Speed);
        if (speedCompare != 0)
        {
            return speedCompare;
        }
        return x.EntityShip.Weight.CompareTo(y.EntityShip.Weight);
    }
}
