using ProjectWarmlyShip.Entities;

namespace ProjectWarmlyShip.Drawnings;

public class DrawningShip
{
    /// <summary>
    /// Класс-сущность
    /// </summary>
    public EntityShip? EntityShip { get; protected set; }
    /// <summary>
    /// Ширина окна
    /// </summary>
    private int? _pictureWidth;
    /// <summary>
    /// Высота окна
    /// </summary>
    private int? _pictureHeight;
    /// <summary>
    /// Левая координата прорисовки 
    /// </summary>
    protected int? _startPosX;
    /// <summary>
    /// Верхняя кооридната прорисовки
    /// </summary>
    protected int? _startPosY;
    /// <summary>
    /// Ширина прорисовки
    /// </summary>
    private readonly int _drawningShipWidth = 150;
    /// <summary>
    /// Высота прорисовки
    /// </summary>
    protected int _drawningShipHeight = 80;
    /// <summary>
    /// Координаты Х
    /// </summary>
    public int? GetPosX => _startPosX;
    /// <summary>
    /// Координтаы У
    /// </summary>
    public int? GetPosY => _startPosY;
    /// <summary>
    /// Ширина объекта
    /// </summary>
    public int GetWidht => _drawningShipWidth;
    /// <summary>
    /// Высота объекта
    /// </summary>
    public int GetHeight => _drawningShipHeight;
    /// <summary>
    /// Пустой конструктор
    /// </summary>
    private DrawningShip()
    {
        _pictureWidth = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="weight"></param>
    /// <param name="bodycolor"></param>
    public DrawningShip(int speed, double weight, Color bodycolor) : this()
    {
        EntityShip = new EntityShip(speed, weight, bodycolor);
    }
    /// <summary>
    /// Конструктор для наследования
    /// </summary>
    /// <param name="_drawningShipWidth"></param>
    /// <param name="_drawnShipHeight"></param>
    protected DrawningShip(int _drawningShipWidth, int _drawnShipHeight) : this()
    {
        this._drawningShipWidth= _drawningShipWidth;
        this._drawningShipHeight = _drawnShipHeight;
    }
    public DrawningShip(EntityShip ship) : this()
    {
        EntityShip = new EntityShip(ship.Speed, ship.Weight, ship.BodyColor);
    }
    public bool SetPictureSize(int width, int height)
    {
        // TODO проверка, что объект "влезает" в размеры поля 
        // если влезает, сохраняем границы и корректируем позицию объекта,если она была уже установлена
        if (width < _drawningShipWidth || height < _drawningShipHeight) return false;
        _pictureWidth = width;
        _pictureHeight = height;
        if (_startPosX != null || _startPosY != null)
        {
            if (_startPosX + _drawningShipWidth > _pictureWidth)
            {
                _startPosX = _startPosX - (_startPosX + _drawningShipWidth - _pictureWidth);
            }
            else if (_startPosX < 0) _startPosX = 0;
            if (_startPosY + _drawningShipHeight > _pictureHeight)
            {
                _startPosY = _startPosY - (_startPosY + _drawningShipHeight - _pictureHeight);
            }
            else if (_startPosY < 0) _startPosY = 0;
        }
        return true;
    }
    /// <summary>
    /// Установка позиций
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void SetPosition(int x, int y)
    {
        if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
        {
            return;
        }
        // TODO если при установке объекта в эти координаты, он будет "выходить" за границы формы
        // то надо изменить координаты, чтобы он оставался в этих границах
        if (x + _drawningShipWidth > _pictureWidth)
        {
            _startPosX = x - (x + _drawningShipWidth - _pictureWidth);
        }
        else if (x < 0) _startPosX = 0;
        else _startPosX = x;
        if (y + _drawningShipHeight > _pictureHeight)
        {
            _startPosY = y - (y + _drawningShipHeight - _pictureHeight);
        }
        else if (y < 0) _startPosY = 0;
        else _startPosY = y;
    }
    public bool MoveTransport(DirectionType direction)
    {
        if (EntityShip == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }
        switch (direction)
        {
            //влево
            case DirectionType.Left:
                if (_startPosX.Value - EntityShip.Step > 0)
                {
                    _startPosX -= (int)EntityShip.Step;
                }
                return true;
            //вверх
            case DirectionType.Up:
                if (_startPosY.Value - EntityShip.Step > 0)
                {
                    _startPosY -= (int)EntityShip.Step;
                }
                return true;
            // вправо
            case DirectionType.Right:
                if (_startPosX.Value + _drawningShipWidth + EntityShip.Step < _pictureWidth)
                {
                    _startPosX += (int)EntityShip.Step;
                }
                return true;
            //вниз
            case DirectionType.Down:
                if (_startPosY.Value + _drawningShipHeight + EntityShip.Step < _pictureHeight)
                {
                    _startPosY += (int)EntityShip.Step;
                }
                return true;
            default:
                return false;
        }
    }
    /// <summary>
    /// Отрисовка объекта
    /// </summary>
    /// <param name="g"></param>
    public virtual void DrawTransport(Graphics g)
    {
        if (EntityShip == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }
        Pen pen = new(Color.Black, 5);
        //надстройка
        Brush brush = new SolidBrush(EntityShip.BodyColor);
        g.FillRectangle(brush, _startPosX.Value + 30, _startPosY.Value, 100, 30);
        //корпус
        g.FillPolygon(brush, new Point[]
        {
        new Point(_startPosX.Value,_startPosY.Value + 30), new Point(_startPosX.Value + 150, _startPosY.Value + 30),
        new Point(_startPosX.Value + 150, _startPosY.Value + 30), new Point(_startPosX.Value + 120,_startPosY.Value + 80),
        new Point(_startPosX.Value + 120,_startPosY.Value + 80), new Point(_startPosX.Value + 30,_startPosY.Value + 80),
        new Point(_startPosX.Value + 30,_startPosY.Value + 80), new Point(_startPosX.Value,_startPosY.Value + 30),
        });
    }
}

