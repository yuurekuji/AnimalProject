using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class InvestigateAt : ActionTask {

        public float minIdleTime = 2f;
        public float maxIdleTime = 4f;

        private float timer;
        private float InvestigateDuration;
        private NavMeshAgent nav;

        public BBParameter<bool> InvestigateDone;
        protected override void OnExecute()
        {
            nav = agent.GetComponent<NavMeshAgent>();

            if (nav != null)
            {
                nav.isStopped = true;
                nav.velocity = Vector3.zero;
            }

            InvestigateDone.value = false;

            InvestigateDuration = Random.Range(minIdleTime, maxIdleTime);
            timer = 0f;
        }

        protected override void OnUpdate()
        {
            timer += Time.deltaTime;

            if (timer >= InvestigateDuration)
            {
                InvestigateDone.value = true;

                EndAction(true);
                Debug.Log("InvestigateDone");
            }
        }
    }
}