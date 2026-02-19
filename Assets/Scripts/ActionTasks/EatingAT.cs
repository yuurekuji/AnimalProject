using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class EatingAT : ActionTask {

        public float minIdleTime = 2f;
        public float maxIdleTime = 4f;

        private float timer;
        private float EatingDuration;
        private NavMeshAgent nav;

        public BBParameter<bool> EatingDone;
        protected override void OnExecute()
        {
            nav = agent.GetComponent<NavMeshAgent>();

            if (nav != null)
            {
                nav.isStopped = true;
                nav.velocity = Vector3.zero;
            }

            EatingDone.value = false;

            EatingDuration = Random.Range(minIdleTime, maxIdleTime);
            timer = 0f;
        }

        protected override void OnUpdate()
        {
            timer += Time.deltaTime;

            if (timer >= EatingDuration)
            {
                EatingDone.value = true;

                EndAction(true);
                Debug.Log("EatingIsDone");
            }
        }
    }
}