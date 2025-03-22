
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleLinearPlacer : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefab;
    [SerializeField][Range(0, 5)] private float randomVerticalDisplacemen = 1;
    [SerializeField][Range(0, 30)] private float distance;
    [SerializeField] private Vector3 displacement = Vector3.zero;
    [SerializeField] private Vector3 movementDirection = Vector3.right;
    private Vector3 _currentPosition = Vector3.zero;

    [SerializeField][Range(0.5f,10f)] private float repeatingRatio = 1;
    [SerializeField][Range(0.5f, 10f)] private float startDelay = 1;
    [SerializeField][Range(0.5f, 30f)] private float destroyDelay = 10;

    Vector3 _startPosition;

    void Start()
    {
        _startPosition = transform.position;
        _currentPosition = _startPosition;
        InvokeRepeating(nameof(PlaceObstacle),startDelay,repeatingRatio);
    }

    void PlaceObstacle()
    {
        GameObject prefab = obstaclePrefab[Random.Range(0, obstaclePrefab.Length)];

        GameObject obstacle = Instantiate(prefab, _currentPosition + distance*movementDirection + displacement + new Vector3(0,Random.Range(0,randomVerticalDisplacemen),0),prefab.transform.rotation,transform);

        _currentPosition = new Vector3(obstacle.transform.position.x,_startPosition.y,obstacle.transform.position.z);

        Destroy(obstacle,destroyDelay);
    }
}
