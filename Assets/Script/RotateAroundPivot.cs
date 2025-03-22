using UnityEngine;

public class RotateAroundPivot : MonoBehaviour
{
    [SerializeField] private float speed = 15;
    [SerializeField] private Vector3 axis = Vector3.down;
    [SerializeField] private bool randomAngle = false;
    [SerializeField] private Space rotationSpace = Space.Self;
    private bool _animate;

    void Start()
    {
        if (randomAngle)
        {
            transform.Rotate(axis,Random.Range(0,360),rotationSpace);
        }
    }

    void Update()
    {
        if (_animate)
        {
            transform.Rotate(axis,Time.deltaTime * speed,rotationSpace);
        }
    }

    private void OnBecameVisible()
    {
        _animate = true;
    }

    private void OnBecameInvisible()
    {
        _animate = false;
    }
}
