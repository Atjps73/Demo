using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _armor;
    [SerializeField] private Death _death;

    private readonly Move _move = new Move();
    private float _speed = 0.2f;
	private bool _leftPosition = true;

	private void FixedUpdate()
    {
		if (_speed < 0.4f)
		{
			_speed += 0.00002f;
		}

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
