using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Transform _transform;
	[SerializeField] private Complexity _complexity;

	private float _maxSpeed = 0.4f;
	private float _speed = 0.2f;

	private void FixedUpdate()
    {
		_complexity.Increasing(ref _speed, _maxSpeed);
		_transform.Translate(0, _speed, 0 * Time.deltaTime);
    }
}
