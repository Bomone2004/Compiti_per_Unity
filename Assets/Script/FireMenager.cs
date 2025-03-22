using UnityEngine;

public class FireMenager : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float firePower = 100;
    [SerializeField] private float fireRate = 1;
    [SerializeField] private ForceMode fireMode = ForceMode.Impulse;
    [SerializeField] private Transform[] firePositions;
    [SerializeField] private Transform root;

    float _fireTime = 0;
    void Update()
    {
        _fireTime += Time.deltaTime;

        if (_fireTime < fireRate) return;

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log($"Fire1:{transform.eulerAngles}");

            for (int i = 0; i < firePositions.Length; i++)
            {
                GameObject bullet = Instantiate(_bulletPrefab, firePositions[i].position, _bulletPrefab.transform.rotation * root.rotation);

                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.AddRelativeForce(Vector3.down * fireRate* firePower, fireMode);
            }

            _fireTime = 0;
        }
    }
}
