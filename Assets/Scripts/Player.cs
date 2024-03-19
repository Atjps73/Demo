using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _armor;
    [SerializeField] private Complexity _complexity;
    [SerializeField] private Death _death;

    private readonly Move _move = new Move();
    private float _maxSpeed = 0.4f;
    private float _speed = 0.2f;
	private bool _leftPosition = true;

	private void FixedUpdate()
    {
		_complexity.Increasing(ref _speed, _maxSpeed);
		transform.Translate(0, _speed, 0 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Obstacle>())
            _death.Die(gameObject, _armor, collision);
    }

    public void ChangeDirection()
    {
        _move.ChangePosition(transform, ref _leftPosition);
    }
}
