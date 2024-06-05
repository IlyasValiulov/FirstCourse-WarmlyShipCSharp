namespace ProjectWarmlyShip.Entities;

public class EntityWarmlyShip : EntityShip
{
    /// <summary>
    /// Дополнительтный цвет
    /// </summary>
    public Color AdditionalColor { get; private set; }
    public void setAdditionalColor(Color color)
    {
        AdditionalColor = color;
    }
    /// <summary>
    /// Признак наличия труб
    /// </summary>
    public bool ShipPipes { get; private set; }
    /// <summary>
    /// Признак наличия топливного бака
    /// </summary>
    public bool FuelTank { get; private set; }
    /// <summary>
    /// Инициализация полей класса EntityWarmlyShip
    /// </summary>
    /// <param name="additionalcolor"></param>
    /// <param name="shpipipes"></param>
    /// <param name="fueltank"></param>
    public EntityWarmlyShip(int speed, double weight, Color bodycolor, Color additionalcolor, bool shpipipes, bool fueltank) : base(speed, weight, bodycolor)
    {
        AdditionalColor = additionalcolor;
        ShipPipes = shpipipes;
        FuelTank = fueltank;
    }
    /// <summary>
    /// Получение строк со значениями свойств продвинутого объекта класса-сущности
    /// </summary>
    /// <returns></returns>
    public override string[] GetStringRepresentation()
    {
        return new[] { nameof(EntityWarmlyShip), Speed.ToString(), Weight.ToString(), BodyColor.Name, AdditionalColor.Name, 
                        ShipPipes.ToString(), FuelTank.ToString()};
    }
    /// <summary>
    /// Создание продвинутого объекта из массива строк
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public static EntityWarmlyShip? CreateEntityWarmlyShip(string[] strs)
    {
        if (strs.Length != 7 || strs[0] != nameof(EntityWarmlyShip))
        {
            return null;
        }
        return new EntityWarmlyShip(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]),
                                    Color.FromName(strs[4]), Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6]));
    }
}
