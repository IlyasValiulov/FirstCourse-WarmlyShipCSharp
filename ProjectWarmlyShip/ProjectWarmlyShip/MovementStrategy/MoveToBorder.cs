namespace ProjectWarmlyShip.MovementStrategy;

public class MoveToBorder : AbstractStrategy
{
    protected override bool IsTargetDestinaion()
    {
        ObjectParameters? objParams = GetObjectParameters;
        if (objParams == null)
        {
            return false;
        }
        return objParams.LeftBorder - GetStep() <= 0 ||
            objParams.RightBorder + GetStep() >= FieldWidth ||
            objParams.TopBorder - GetStep() <= 0
            || objParams.ObjectMiddleVertical + GetStep() >= FieldHeight;
    }

    protected override void MoveToTarget()
    {
        ObjectParameters? objParams = GetObjectParameters;
        if (objParams == null)
        {
            return;
        }
        //реализация в правый нижний угол
        int x = objParams.RightBorder;
        if (x + GetStep() < FieldWidth) MoveRight();
        int y = objParams.DownBorder;
        if (y + GetStep() < FieldHeight) MoveDown();
    }
}
