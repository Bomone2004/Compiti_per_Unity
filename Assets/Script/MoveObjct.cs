using UnityEngine;

public class MoveObjct : MonoBehaviour
{
    public float moveSpeed = 5f;
    private void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);
    }
}
