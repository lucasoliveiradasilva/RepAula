using UnityEngine;
using UnityEngine.AI;

public class PatrulhaIA : MonoBehaviour
{
    public Transform[] pontos;
    private int pontoAtual = 0;
    private NavMeshAgent agent;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(pontos[pontoAtual].position);
    }

    public void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            pontoAtual = (pontoAtual + 1) % pontos.Length;
            agent.SetDestination(pontos[pontoAtual].position);
        }
    }
}