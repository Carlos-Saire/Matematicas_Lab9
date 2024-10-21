using UnityEngine;
public class PointControl : MonoBehaviour
{
    public GameObject NexPoint;
    [SerializeField] private float time;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            collision.gameObject.GetComponent<NPC_Controller>().SetObjetive(NexPoint);
        }
    }
    private void UpdateTime(float speed)
    {
        this.time = Vector3.Distance(this.gameObject.transform.position,NexPoint.transform.position)/speed;
    }
    private void OnEnable()
    {
        NPC_Controller.eventSpeed+=UpdateTime;
    }
    private void OnDisable()
    {
        NPC_Controller.eventSpeed -= UpdateTime;
    }
}
