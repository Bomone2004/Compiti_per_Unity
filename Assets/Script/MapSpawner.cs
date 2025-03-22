using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] float spawnX = 170f;

    [SerializeField] float destroyX = -170f;

    public float moveSpeed = 5f;  

    public GameObject tilePrefab1;
    public GameObject tilePrefab2;

    void Update()
    {
        if (tilePrefab1.transform.position.x < destroyX || tilePrefab2.transform.position.x < destroyX)
        {
            SpawnTile();
        }
    }

    void SpawnTile()
    {
        GameObject tile = ObjectPool.Instance.GetObject();
        tile.transform.position = new Vector3(spawnX, 0, 0);
        tile.GetComponent<MovingTile>().moveSpeed = 5f; 
    }
}
