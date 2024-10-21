using UnityEngine;
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float speed;
    float x;
    float z;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity=new Vector3(x*speed,rb.velocity.y,z*speed);
    }
}
