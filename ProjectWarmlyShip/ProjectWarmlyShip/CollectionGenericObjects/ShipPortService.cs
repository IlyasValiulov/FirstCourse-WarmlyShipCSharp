using ProjectWarmlyShip.Drawnings;
using System.Drawing;

namespace ProjectWarmlyShip.CollectionGenericObjects;

public class ShipPortService : AbstractCompany
{
    public ShipPortService(int picWidth, int picHeight, ICollectionGenericObjects<DrawningShip> collection) : base(picWidth, picHeight, collection)
    {
    }
    protected override void DrawBackgound(Graphics g)
    {
        //рисуем пристань
        int width = _pictureWidth / _placeSizeWidth;
        int height = _pictureHeight / _placeSizeHeight;
        Pen pen = new(Color.Black, 3);
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height + 1; ++j)
            {
                g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth - 5, j * _placeSizeHeight);
            }
        }
    }
    protected override void SetObjectsPosition()
    {
        int width = _pictureWidth / _placeSizeWidth;
        int height = _pictureHeight / _placeSizeHeight;

        int curWidth = width - 1;
        int curHeight = 0;

        for (int i = 0; i < (_collection?.Count ?? 0); i++)
        {
            try
            {
                _collection.Get(i).SetPictureSize(_pictureWidth, _pictureHeight);
                _collection.Get(i).SetPosition(_placeSizeWidth * curWidth + 20, curHeight * _placeSizeHeight + 4);
            }
            catch (Exception) { }
            if (curWidth > 0)
                curWidth--;
            else
            {
                curWidth = width - 1;
                curHeight++;
            }
            if (curHeight > height)
            {
                return;
            }
        }
    }
}

