using UnityEngine;

public class EnemyAircraftAI : MonoBehaviour
{
    public Transform target;
    public float speed = 100f;
    public float turnSpeed = 2f;

    void Update()
    {
        if (!target) return;

        Vector3 dir = (target.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime * turnSpeed);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}