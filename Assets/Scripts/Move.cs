using UnityEngine;

public class Move
{
    public void ChangePosition(Transform transform, ref bool leftPosition)
    {
        if (leftPosition == true)
            NewVector(transform, 2, ref leftPosition);
        else
            NewVector(transform, -2, ref leftPosition);
    }

    private void NewVector(Transform transform, int x, ref bool leftPosition)
    {
        transform.position += new Vector3(x, 0, 0);
        leftPosition = !leftPosition;
    }
}
