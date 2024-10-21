using UnityEngine;
using System;
public class NPC_Controller : MonoBehaviour
{
    [SerializeField] private GameObject objetivo;
    [SerializeField] private float speed;
    static public event Action<float> eventSpeed;
    private void Start()
    {
        eventSpeed?.Invoke(speed);
    }
    private void Update()
    {
        Move();
    }   
    public void SetObjetive(GameObject NewObjetivo)
    {
        objetivo = NewObjetivo;  
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, speed * Time.deltaTime);
    }
}
