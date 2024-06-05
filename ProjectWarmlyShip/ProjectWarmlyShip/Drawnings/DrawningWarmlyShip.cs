using ProjectWarmlyShip.Entities;

namespace ProjectWarmlyShip.Drawnings;

public class DrawningWarmlyShip : DrawningShip
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="additionalcolor"></param>
    /// <param name="shpipipes"></param>
    /// <param name="fueltank"></param>
    public DrawningWarmlyShip(int speed, double weight, Color bodycolor, Color additionalcolor, bool shpipipes, bool fueltank) : base(150,80)
    {
        EntityShip = new EntityWarmlyShip(speed, weight, bodycolor, additionalcolor, shpipipes, fueltank); //дописать конструктор
    }
    public DrawningWarmlyShip(EntityWarmlyShip ship) : base(150, 80)
    {
        EntityShip = new EntityWarmlyShip(ship.Speed, ship.Weight, ship.BodyColor, ship.AdditionalColor, ship.ShipPipes, ship.FuelTank);
    }
    public override void DrawTransport(Graphics g)
    {
        //оператор is совместимость объекта с заданным типом
        if (EntityShip == null || EntityShip is not EntityWarmlyShip warmlyship || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }
        Brush brush = new SolidBrush(warmlyship.AdditionalColor);
        if (warmlyship.ShipPipes)
        {
            _drawningShipHeight = 140;
            g.FillRectangle(brush, _startPosX.Value + 70, _startPosY.Value, 12, 60);
            g.FillRectangle(brush, _startPosX.Value + 90, _startPosY.Value, 12, 60);
            _startPosY += 60;
        }       
        base.DrawTransport(g);
        if (warmlyship.FuelTank)
        {
            g.FillRectangle(brush, _startPosX.Value + 40, _startPosY.Value + 60, 70, 10);
        }
        if (warmlyship.ShipPipes) _startPosY -= 60;
    }
}
