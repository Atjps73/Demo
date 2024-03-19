using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    private float _speed = 0.2f;

    private void FixedUpdate()
    {
		if (_speed < 0.6f)
		{
			_speed += 0.00002f;
		}

		_transform.Translate(0, _speed, 0 * Time.deltaTime);
    }
}
