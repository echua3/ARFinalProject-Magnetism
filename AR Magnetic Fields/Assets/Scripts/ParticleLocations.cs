using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ParticleLocations : MonoBehaviour
{
    private List<MovingParticle> movingParticles;
    private List<PermanentMagnet> permanentMagnets;

    // Start is called before the first frame update
    void Start()
    {
        movingParticles = new List<MovingParticle>(FindObjectsOfType<MovingParticle>());
        permanentMagnets = new List<PermanentMagnet>(FindObjectsOfType<PermanentMagnet>());
    }

    // get the coordinates of the particle if the permanent magnet was at the origin
    private static Vector3 getOriginPosition(MovingParticle mp, PermanentMagnet pm)
    {
        Vector3 aToB = mp.transform.position - pm.transform.position;
        Vector3 relativePosition = pm.transform.InverseTransformPoint(aToB);

        return relativePosition;
    }

    //
    private Vector3 getMagneticDipole(MovingParticle mp)
    {
        Vector3 newForce = Vector3.zero;

        foreach (PermanentMagnet pm in permanentMagnets)
        {
            Vector3 position = getOriginPosition(mp, pm);
            // calculate magnetic force
            float x = position.x;
            float y = position.y;
            float z = position.z;
            float denominator = (float)(4 * Math.PI * Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            Vector3 multDirection = (3 * z * x, 3 * z * y, (float)(2 * Math.Pow(z, 2) - Math.Pow(x, 2) - Math.Pow(y, 2)));
            Vector3 force = ((float)(pm.RemanenceField)/denominator) * multDirection;
            
        }
    }
}
