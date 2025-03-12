using UnityEngine;

public class TankTurret : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float turnInput = 0f;

        // Permitir que la torreta solo gire con las flechas ← y →
        if (Input.GetKey(KeyCode.LeftArrow)) turnInput = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) turnInput = 1f;

        // Aplicar la rotación
        transform.Rotate(Vector3.up, turnInput * rotationSpeed * Time.deltaTime);
    }
}
