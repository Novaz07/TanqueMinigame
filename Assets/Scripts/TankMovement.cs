using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveForce = 1000f;
    public float turnForce = 5000f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Movimiento con W y S
        float moveInput = Input.GetAxis("Vertical"); // W/S
        Vector3 move = transform.forward * moveInput * moveForce * Time.fixedDeltaTime;
        rb.AddForce(move, ForceMode.Acceleration);

        // Rotación solo con A y D
        float turnInput = 0f;
        if (Input.GetKey(KeyCode.A)) turnInput = -1f;
        if (Input.GetKey(KeyCode.D)) turnInput = 1f;

        Vector3 turn = Vector3.up * turnInput * turnForce * Time.fixedDeltaTime;
        rb.AddTorque(turn, ForceMode.VelocityChange);
    }
}
