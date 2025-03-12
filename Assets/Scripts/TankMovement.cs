using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveForce = 1500f;
    public float turnForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveInput = 0f;

        // Permitir solo W y S para moverse
        if (Input.GetKey(KeyCode.W)) moveInput = 1f;
        if (Input.GetKey(KeyCode.S)) moveInput = -1f;

        Vector3 move = transform.forward * moveInput * moveForce * Time.fixedDeltaTime;
        rb.AddForce(move, ForceMode.Acceleration);

        float turnInput = 0f;

        // Permitir solo A y D para girar
        if (Input.GetKey(KeyCode.A)) turnInput = -1f;
        if (Input.GetKey(KeyCode.D)) turnInput = 1f;

        Vector3 turn = Vector3.up * turnInput * turnForce * Time.fixedDeltaTime;
        rb.AddTorque(turn, ForceMode.VelocityChange);
    }
}
