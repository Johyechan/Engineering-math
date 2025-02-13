using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    [SerializeField] private float _bulletSpeed;

    public void Fire()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet1 = Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody bulletRigidbody = bullet1.GetComponent<Rigidbody>();
            bulletRigidbody.linearVelocity = transform.forward * _bulletSpeed;
        }
    }
}
