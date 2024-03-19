using UnityEngine;

public class Deactivator : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;

    private void OnEnable()
    {
        Invoke(nameof(Deactivate), _delay);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
