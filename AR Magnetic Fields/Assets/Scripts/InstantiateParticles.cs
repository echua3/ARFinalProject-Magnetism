using System.Collections.Generic;
using UnityEngine;

// Creates points based on the location of the magnet
public class InstantiateParticles : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    private List<PermanentMagnet> permanentMagnets;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        permanentMagnets = new List<PermanentMagnet>(FindObjectsOfType<PermanentMagnet>());
        // Instantiate at position (0, 0, 0) and zero rotation.
        foreach (PermanentMagnet pm in permanentMagnets)
        {
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .3), (float)(pm.transform.position.y + .3), (float)(pm.transform.position.z + .3)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .3), (float)(pm.transform.position.y + .4), (float)(pm.transform.position.z + .3)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .3), (float)(pm.transform.position.y + .5), (float)(pm.transform.position.z + .3)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .3), (float)(pm.transform.position.y - .3), (float)(pm.transform.position.z + .3)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .3), (float)(pm.transform.position.y - .4), (float)(pm.transform.position.z + .3)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .3), (float)(pm.transform.position.y - .5), (float)(pm.transform.position.z + .3)), Quaternion.identity);


            /*Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y + 2, pm.transform.position.z + .1), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y + 3, pm.transform.position.z + .1), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y - 1, pm.transform.position.z + .1), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y - 2, pm.transform.position.z + .1), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y - 3, pm.transform.position.z + .1), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y - 1, pm.transform.position.z + .3), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 1, pm.transform.position.y - 1, pm.transform.position.z - .3), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 4, pm.transform.position.y - 1, pm.transform.position.z + .1), Quaternion.identity);
            Instantiate(myPrefab, new Vector3(pm.transform.position.x + 4, pm.transform.position.y - 1, pm.transform.position.z + .1), Quaternion.identity);
            */
        }
        
    }
}
