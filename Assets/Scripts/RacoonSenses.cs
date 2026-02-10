using NodeCanvas.Framework;
using UnityEngine;

public class RacoonSenses : MonoBehaviour
{

    public Blackboard blackboard;
    public Transform player;

    public float detectRadius = 12f;
    public float panicRadius = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //finding the player without dragging and dropping.
        player = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!player) return;

        //created distance variable to check between racoon and player

        float dist = Vector3.Distance(transform.position, player.position);

        //setting the variables up inside the blackboard and the script for the racoon.
        blackboard.SetVariableValue("playerDistance", dist);
        blackboard.SetVariableValue("playerIsDetected", dist <= detectRadius);
        blackboard.SetVariableValue("playerIsTooClose", dist <= panicRadius);
    }

}
