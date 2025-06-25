using UnityEngine;
using UnityEngine.AI; 

public class InimigoIA : MonoBehaviour
{
    public Transform player;
    public float distanciaMinima = 1.5f;

    private NavMeshAgent agente;
    private bool esperando = false;

    public void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        float distancia = Vector3.Distance(transform.position, player.position);

        if (distancia > distanciaMinima && !esperando)
        {
            esperando = true;
            esperando = true;
            agente.SetDestination(player.position);
        }
        else if (distancia <= distanciaMinima && !esperando)
        {
            agente.ResetPath(); //Para de andar
            esperando = true;
            Invoke("Delay", 5f);
        }
    }
    public void Delay()
    {
        esperando = false;
    }
}