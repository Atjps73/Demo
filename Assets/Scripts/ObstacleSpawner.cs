using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _point = new Transform[1];
    [SerializeField] private GameObject[] _obstacle = new GameObject[1];

    private float _delay = 1.5f;

    private int _indexPoint;
    private int _indexObstacle;

    private void Start()
    {
        Invoke(nameof(Spawn), _delay);
    }

    private void Spawn()
    {
        _indexObstacle = Random.Range(0, 2);
        _indexPoint = Random.Range(0, 2);

        ChangePosition(_point[_indexPoint]);
        Instantiate(_obstacle[_indexObstacle]);

        if (_delay > 0.7f)
			_delay -= 0.005f;

        Start();
    }

    private void ChangePosition(Transform point)
    {
        foreach (var obstacle in _obstacle)
        {
            obstacle.transform.position = point.position;
        } 
    }
}
