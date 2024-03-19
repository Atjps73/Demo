using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(gameObject, 4);
    }
}