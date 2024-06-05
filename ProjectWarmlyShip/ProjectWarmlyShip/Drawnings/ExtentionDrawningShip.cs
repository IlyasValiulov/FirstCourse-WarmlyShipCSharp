using ProjectWarmlyShip.Entities;

namespace ProjectWarmlyShip.Drawnings;

/// <summary>
/// Расширение для класса EntityCar
/// </summary>
public static class ExtentionDrawningShip
{
    /// <summary>
    /// Разделитель для записи информации по объекту в файл
    /// </summary>
    private static readonly string _separatorForObject = ":";
    /// <summary>
    /// Создание объекта из строки
    /// </summary>
    /// <param name="info">Строка с данными для создания объекта</param>
    /// <returns>Объект</returns>
    public static DrawningShip? CreateDrawningShip(this string info)
    {
        string[] strs = info.Split(_separatorForObject);
        EntityShip? ship = EntityWarmlyShip.CreateEntityWarmlyShip(strs);
        if (ship != null)
        {
            return new DrawningWarmlyShip((EntityWarmlyShip)ship);
        }
        ship = EntityShip.CreateEntityShip(strs);
        if (ship != null)
        {
            return new DrawningShip(ship);
        }
        return null;
    }
    /// <summary>
    /// Получение данных для сохранения в файл
    /// </summary>
    /// <param name="drawningCar">Сохраняемый объект</param>
    /// <returns>Строка с данными по объекту</returns>
    public static string GetDataForSave(this DrawningShip drawningCar)
    {
        string[]? array = drawningCar?.EntityShip?.GetStringRepresentation();
        if (array == null)
        {
            return string.Empty;
        }
        return string.Join(_separatorForObject, array);
    }
}
