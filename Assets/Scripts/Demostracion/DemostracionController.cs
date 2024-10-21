using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
public class DemostracionController : MonoBehaviour
{
    bool iniciar;
    float v0;
    float tiempo;
    float tiempoSimulado;
    float aceleracion;
    public TMP_Text print;
    public void Iniciar()
    {
        iniciar = true;
    }
    private void Update()
    {
        if(iniciar)
        {
            tiempoSimulado += Time.deltaTime;
            MoverObjeto();
            Print();
            if (tiempoSimulado >= tiempo)
            {
                iniciar = false;
            }
        }
    }
    public void Aceleracion(string aceleracion)
    {
        this.aceleracion=float.Parse(aceleracion);
    }
    public void V0(string v0)
    {
        this.v0 = float.Parse(v0);
    }
    public void Tiempo(string timepo)
    {
        this.tiempo = float.Parse(timepo);
    }
    public void Print()
    {
        float valor=v0*tiempo+(aceleracion*math.pow(tiempo,2))/2;
        print.text = ""+valor;
    }
    public void MoverObjeto()
    {
        float x = v0 * tiempoSimulado + (aceleracion * math.pow(tiempoSimulado, 2)) / 2;
        transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);
    }
}
