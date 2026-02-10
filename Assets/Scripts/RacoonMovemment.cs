using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

public class RacoonMovemment : MonoBehaviour
{
    public Blackboard blackboard;
    NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Vector3 target = blackboard.GetVariableValue<Vector3>("TargetPos");

        if (target != Vector3.zero)
        {
            agent.SetDestination(target);
        }
    }

    public void SetSpeed(float speed)
    {
        agent.speed = speed;
    }

    public bool ReachedDestination()
    {
        if (agent.pathPending) return false;
        return agent.remainingDistance <= agent.stoppingDistance + 0.2f;
    }
}
