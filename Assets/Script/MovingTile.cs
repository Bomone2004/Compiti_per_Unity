using System;
using UnityEngine;

public class MovingTile : MonoBehaviour
{
    public float moveSpeed = 3f;     
    public float destroyX = -170f;
    public bool useObjectPool = true;

    public float spawnX = 170f;

    void Update()
    {
        transform.Translate(new Vector3(-1,0,0) * moveSpeed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            if (useObjectPool)
            {
                ObjectPool.Instance.ReturnObject(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }
}

