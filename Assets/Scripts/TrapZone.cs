using UnityEngine;

public class TrapZone : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private bool _leftPosition = true;

    private readonly Move _move = new Move();

    private void Start()
    {
        if (_transform.position.x <= 0)
            _leftPosition = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            _move.ChangePosition(_transform, ref _leftPosition);
            Destroy(gameObject);
        }
    }
}
