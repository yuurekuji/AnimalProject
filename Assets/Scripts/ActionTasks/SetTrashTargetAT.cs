using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SetTrashTargetAT : ActionTask {

        protected override void OnExecute()
        {
            Transform trash = blackboard.GetVariableValue<Transform>("TrashTransform");

            if (trash == null)
            {
                EndAction(false);
                return;
            }

            blackboard.SetVariableValue("TargetPos", trash.position);
            EndAction(true);
        }
    }
}