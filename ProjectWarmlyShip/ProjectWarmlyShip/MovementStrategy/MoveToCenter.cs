namespace ProjectWarmlyShip.MovementStrategy;

public class MoveToCenter : AbstractStrategy
{
    protected override bool IsTargetDestinaion()
    {
        ObjectParameters? objParams = GetObjectParameters;
        if (objParams == null)
        {
            return false;
        }
        return objParams.ObjectMiddleHorizontal - GetStep() <= FieldWidth / 2 && 
            objParams.ObjectMiddleHorizontal + GetStep() >= FieldWidth / 2 &&
            objParams.ObjectMiddleVertical - GetStep() <= FieldHeight / 2
            && objParams.ObjectMiddleVertical + GetStep() >= FieldHeight / 2;
    }
    protected override void MoveToTarget()
    {
        ObjectParameters? objParams = GetObjectParameters;
        if (objParams == null)
        {
            return;
        }
        int diffX = objParams.ObjectMiddleHorizontal - FieldWidth / 2;
        if (Math.Abs(diffX) > GetStep())
        {
            if (diffX > 0)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }
        int diffY = objParams.ObjectMiddleVertical - FieldHeight / 2;
        if (Math.Abs(diffY) > GetStep())
        {
            if (diffY > 0)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }
        }
    }
}
