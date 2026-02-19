using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

    public class SetNavTargetAT : ActionTask {

        public BBParameter<Vector3> TargetPos;
        public float radius = 10f;

        protected override void OnExecute()
        {
            Vector3 offset = Random.insideUnitSphere * radius;
            offset.y = 0f;

            TargetPos.value = agent.transform.position + offset;
            EndAction(true);
        }
    }
}