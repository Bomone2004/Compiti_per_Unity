using Unity.Mathematics;
using UnityEngine;

public class FloatingAnimation : MonoBehaviour
{
    [SerializeField] Vector3 direction = Vector3.up;
    [SerializeField] float speed = 0.1f;
    [SerializeField] float delta = 1;
    public float moveSpeed = 5f;

    private Vector3 _startPosition;
    void Start()
    {
        _startPosition = transform.position;
        
    }

    void Update()
    {
        _startPosition += new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime;
        transform.position = _startPosition + delta*Mathf.Sin(speed*Time.time)* direction;
    }
}
