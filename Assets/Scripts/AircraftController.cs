using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AircraftController : MonoBehaviour
{
    public float thrust = 200f;
    public float pitchPower = 50f;
    public float rollPower = 80f;
    public float yawPower = 30f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        float pitch = -Input.GetAxis("Vertical");
        float roll = -Input.GetAxis("Horizontal");
        float yaw = Input.GetKey(KeyCode.Q) ? -1 :
                    Input.GetKey(KeyCode.E) ? 1 : 0;

        rb.AddForce(transform.forward * thrust);
        rb.AddTorque(transform.right * pitch * pitchPower);
        rb.AddTorque(transform.forward * roll * rollPower);
        rb.AddTorque(transform.up * yaw * yawPower);
    }
}