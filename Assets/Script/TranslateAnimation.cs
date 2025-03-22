using UnityEngine;

public class TranslateAnimation : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction = Vector3.right;
    void Update()
    {
        transform.Translate(direction * (speed * Time.deltaTime));

        if (transform.position.x > 25)
        {
            transform.position = new Vector3(-25f,0.5f,20f);
        }
    }
}
