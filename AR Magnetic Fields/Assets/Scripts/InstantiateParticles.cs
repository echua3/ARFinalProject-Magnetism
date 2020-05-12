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
            //SAME x and y
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);
           //keep y and z the same
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .1), (float)(pm.transform.position.y), (float)(pm.transform.position.z)), Quaternion.identity);

            //change x
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .1), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .15), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .2), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .1), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .15), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .2), (float)(pm.transform.position.y), (float)(pm.transform.position.z + .15)), Quaternion.identity);

            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .1), (float)(pm.transform.position.y + .3), (float)(pm.transform.position.z + .15)), Quaternion.identity);

            //add the y variable
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .1), (float)(pm.transform.position.y + .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .15), (float)(pm.transform.position.y + .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .2), (float)(pm.transform.position.y + .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .1), (float)(pm.transform.position.y + .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .15), (float)(pm.transform.position.y + .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .2), (float)(pm.transform.position.y + .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);

            //subtract y
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .1), (float)(pm.transform.position.y - .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .15), (float)(pm.transform.position.y - .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x + .2), (float)(pm.transform.position.y - .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .1), (float)(pm.transform.position.y - .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .15), (float)(pm.transform.position.y - .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);
            Instantiate(myPrefab, new Vector3((float)(pm.transform.position.x - .2), (float)(pm.transform.position.y - .15), (float)(pm.transform.position.z + .15)), Quaternion.identity);



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
