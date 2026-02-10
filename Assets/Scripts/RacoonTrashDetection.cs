using NodeCanvas.Framework;
using UnityEngine;

public class RacoonTrashDetection : MonoBehaviour
{
    public Blackboard blackboard;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            blackboard.SetVariableValue("TrashIsNear", true);
            blackboard.SetVariableValue("TrashTransform", other.transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            blackboard.SetVariableValue("TrashIsNear", false);
            blackboard.SetVariableValue("TrashTransform", null);
        }
    }
}
