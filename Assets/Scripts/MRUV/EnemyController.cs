using UnityEngine;
public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float fullspeed;
    private GameObject objetivo;
    private void Start()
    {
        fullspeed = speed;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objetivo = other.gameObject;
            speed += Time.deltaTime;
            Move();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objetivo = null;
            speed = fullspeed;
        }
    }
    private void Move()
    {
        if (objetivo != null) 
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, speed * Time.deltaTime);
        }
    }

}
