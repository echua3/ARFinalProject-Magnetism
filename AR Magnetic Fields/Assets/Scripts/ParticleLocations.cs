using System.Collections;
using System.Collections.Generic;
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

    private void getMagneticDipole(MovingParticle mp)
    {

    }
}
