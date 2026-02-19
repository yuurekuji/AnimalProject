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
            agent.isStopped = false;
            agent.SetDestination(target);
        }

        // SIMPLE ARRIVAL CHECK (brute force)
        float dist = Vector3.Distance(transform.position, target);

        if (dist < 1.5f)
            blackboard.SetVariableValue("Arrived", true);
        else
            blackboard.SetVariableValue("Arrived", false);
    }
}
