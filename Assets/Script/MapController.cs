using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField]public float spawnInterval = 170f;

    public float spawnX = 170f;        
    private float timer = 0f;
    public float moveSpeed = 5f;

    void Update()
    {
        timer += (moveSpeed * Time.deltaTime);
        if (timer >= spawnInterval)
        {
            SpawnTile();
            timer = 0f;
        }
        Debug.Log(timer);
    }

    void SpawnTile()
    {
        GameObject tile = ObjectPool.Instance.GetObject();
        tile.transform.position = new Vector3(spawnX, 0, 0);
        tile.GetComponent<MovingTile>().moveSpeed = 5f; 
    }
}
