using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SetNavTargetAT : ActionTask {

        public float radius = 10f;

        protected override void OnExecute()
        {
            Vector3 offset = Random.insideUnitSphere * radius;
            offset.y = 0;

            Vector3 target = agent.transform.position + offset;
            blackboard.SetVariableValue("TargetPos", target);

            EndAction(true);
        }
    }
}