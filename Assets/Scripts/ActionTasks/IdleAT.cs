using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions
{

    public class IdleAT : ActionTask
    {
        public float minIdleTime = 2f;
        public float maxIdleTime = 4f;

        private float timer;
        private float idleDuration;
        private NavMeshAgent nav;

        public BBParameter<bool> idleDone;
        protected override void OnExecute()
        {
            nav = agent.GetComponent<NavMeshAgent>();

            if (nav != null)
            {
                nav.isStopped = true;
                nav.velocity = Vector3.zero;
            }

            idleDone.value = false;

            idleDuration = Random.Range(minIdleTime, maxIdleTime);
            timer = 0f;
            // IMPORTANT: do NOT EndAction here, we want OnUpdate to run
        }

        protected override void OnUpdate()
        {
            timer += Time.deltaTime;

            if (timer >= idleDuration)
            {
                idleDone.value = true;

                EndAction(true);
                Debug.Log("IdleIsDone");
            }
        }
        protected override void OnStop()
        {
            if (nav != null) nav.isStopped = false;
        }
    }
}