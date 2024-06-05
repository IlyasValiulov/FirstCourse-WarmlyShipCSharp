namespace ProjectWarmlyShip.Entities;

public class EntityShip
{
    /// <summary>
    /// Скорость
    /// </summary>
    public int Speed { get; private set; }
    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; private set; }
    /// <summary>
    /// Основной цвет
    /// </summary>
    public Color BodyColor { get; private set; }
    public void setBodyColor(Color color)
    {
        BodyColor = color;
    }
    /// <summary>
    /// Шаг перемещения судна
    /// </summary>
    public double Step => Speed * 100 / Weight;
    /// <summary>
    /// Конструктор сущности
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="weight"></param>
    /// <param name="bodycolor"></param>
    public EntityShip(int speed, double weight, Color bodycolor)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodycolor;
    }
    /// <summary>
    /// Получение строк со значениями свойств объекта класса-сущности
    /// </summary>
    /// <returns></returns>
    public virtual string[] GetStringRepresentation()
    {
        return new[] { nameof(EntityShip), Speed.ToString(), Weight.ToString(), BodyColor.Name };
    }
    /// <summary>
    /// Создание объекта из массива строк
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public static EntityShip? CreateEntityShip(string[] strs)
    {
        if (strs.Length != 4 || strs[0] != nameof(EntityShip))
        {
            return null;
        }
        return new EntityShip(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]));
    }
}


