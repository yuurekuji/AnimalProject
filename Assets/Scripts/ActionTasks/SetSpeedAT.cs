using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class SetSpeedAT : ActionTask {

        public float speed = 3f;

        protected override void OnExecute()
        {
            var agentNav = agent.GetComponent<NavMeshAgent>();
            agentNav.speed = speed;
            EndAction(true);
        }
    }
}