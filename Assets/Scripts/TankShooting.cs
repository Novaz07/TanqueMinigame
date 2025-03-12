using UnityEngine;
using System.Collections;

public class TankShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab del proyectil
    public Transform firePoint; // Lugar desde donde se dispara
    public float bulletSpeed = 15f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar la Bullet en la posición del FirePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Obtener el Rigidbody y aplicar velocidad
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;

        // Destruir la Bullet después de 3 segundos
        Destroy(bullet, 3f);
    }
}
