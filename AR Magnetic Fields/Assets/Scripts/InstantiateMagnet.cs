using System.Collections.Generic;
using UnityEngine;
using Vuforia;

// Creates points based on the location of the magnet
public class InstantiateMagnet : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    //private List<ImageTarget> imageTargets;


    // This script will simply instantiate the Prefab when the game starts.
    void update()
    {
        //imageTargets = new List<ImageTarget>(FindObjectsOfType<ImageTarget>());
        // Instantiate at position (0, 0, 0) and zero rotation.

        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

        Debug.Log("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables)
        {
            Instantiate(myPrefab, new Vector3((float)(tb.transform.position.x + .3),
                (float)(tb.transform.position.y + .3), (float)(tb.transform.position.z + .3)), Quaternion.identity);
            Debug.Log("Trackable: " + tb.TrackableName);
        }

    }
}
