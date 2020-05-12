using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

public class ParticleLocations : MonoBehaviour
{
    private float cycleInterval = 0.01f;
    private List<MovingParticle> movingParticles;
    private List<PermanentMagnet> permanentMagnets;

    void OnDrawGizmos()
    {
        Handles.Label(transform.position, transform.position.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.transform.position = new Vector3(0, 1.5f, 0);

        movingParticles = new List<MovingParticle>(FindObjectsOfType<MovingParticle>());
        permanentMagnets = new List<PermanentMagnet>(FindObjectsOfType<PermanentMagnet>());

        // Start the coroutine for each particle path
        foreach (MovingParticle mp in movingParticles)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            //Debug.Log(mp.transform.position.ToString());
            /*if (mp.rb == null)
                Debug.LogError("SomeVariable has not been assigned.", this);
            Debug.LogError(mp.transform.position.ToString());
            if (!mp.GetComponent<Rigidbody>())
            {
                mp.AddComponent<Rigidbody>();
                Debug.LogError("No Rigid body?");
            }
            if (!currentPrefab.GetComponent<Rigidbody>())
            {
                // Add the Rigidbody component
                currentPrefab.AddComponent<Rigidbody>();
            }
                Debug.LogError(mp.charge.ToString());
            Debug.LogError(mp.rb.mass.ToString());*/
            StartCoroutine(Cycle(mp));
        }
            
    }

    public IEnumerator Cycle (MovingParticle mp)
    {
        //Vector3[] positions = new[] { new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f) };
        while (true)
        {
            //positions = getMagneticDipole(mp);
            getMagneticDipole(mp);
            yield return new WaitForSeconds(cycleInterval);
        }
    }

    // get the coordinates of the particle if the permanent magnet was at the origin
    private static Vector3 getOriginPosition(MovingParticle mp, PermanentMagnet pm)
    {
        Vector3 aToB = mp.transform.position - pm.transform.position;
        Debug.LogError("PM World Position" + pm.transform.position.ToString());
        Debug.LogError("MP World Position" + mp.transform.position.ToString());

        Debug.LogError("aToB" + aToB.ToString());

        //local space
        Vector3 relativePosition = aToB;
        //Debug.LogError("Relative Position" + relativePosition.ToString());


        return relativePosition;
    }

    //
    private void getMagneticDipole(MovingParticle mp)
    {
        Vector3 newForce = Vector3.zero;

        foreach (PermanentMagnet pm in permanentMagnets)
        {
            Vector3 position = getOriginPosition(mp, pm);
            Debug.LogError("Current position " + position.ToString());
            // calculate magnetic force
            float x = position.x;
            float y = position.y;
            float z = position.z;
            float denominator = (float)(4 * Math.PI * Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            Vector3 multDirection = new Vector3(3 * z * x, 3 * z * y, (float)(2 * Math.Pow(z, 2) - Math.Pow(x, 2) - Math.Pow(y, 2)));
            Vector3 force = ((float)(pm.RemanenceField)/denominator) * multDirection;

            newForce += force;

            /*if (float.IsNaN(newForce.x))
            {
                newForce = Vector3.zero;
            }*/
        }
        Debug.LogError("New Force vector: " + newForce.ToString());
        //mp.rb.AddForce(newForce);
        //return newForce;

        Vector3 newLocation = getNewLocation(newForce, mp);
        Debug.LogError("New location " + newLocation.ToString());
    }

    private Vector3 getNewLocation(Vector3 force, MovingParticle mp)
    {
        Vector3 newLocation = force + mp.transform.position;
        return newLocation;
    }
}
