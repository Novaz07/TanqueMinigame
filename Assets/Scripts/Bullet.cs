using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Si choca contra un objeto con la etiqueta "Obstacle", lo destruye
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject); // Destruir obstáculo
            Destroy(gameObject); // Destruir proyectil
        }
    }
}
