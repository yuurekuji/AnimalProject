using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class SetSpeedAT : ActionTask {

        public float speed = 3f;

        protected override void OnExecute()
        {
            float agentNav = agent.GetComponent<NavMeshAgent>().speed;
            agentNav = speed;
            EndAction(true);
        }
    }
}