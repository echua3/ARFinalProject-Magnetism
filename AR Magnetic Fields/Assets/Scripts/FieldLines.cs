using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldLines: MonoBehaviour
{
    public Vector3[] positions;
    //private int numParticlesPerPath;
    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    private LineRenderer lr;

    public FieldLines(Vector3[] positions)
    {
        this.positions = positions;
        int numParticlesPerPath = positions.Length;

        //create new gameobject instance
        GameObject myLine = new GameObject();
        // myLine.transform.position = positions[0];

        // create line renderer
        myLine.AddComponent<LineRenderer>();
        lr = myLine.GetComponent<LineRenderer>();

        //instantiate line renderer
        lr.material = new Material(Shader.Find("Legacy Shaders/Particles/Additive (Soft)"));
        lr.useWorldSpace = false;
        lr.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;

        // 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lr.colorGradient = gradient;

        //lr.SetColors(color, color);
        lr.widthCurve = AnimationCurve.Linear(0, .5f, 1, .5f);
        //lr.SetPosition(0, start);
        //lr.SetPosition(1, end);

        lr.positionCount = positions.Length;
        //set Positions
        lr.SetPositions(positions);
        Debug.LogError("Last Position in drawline: " + positions[numParticlesPerPath - 1].ToString());
    }
    

    //update
    private void Update()
    {
        //LineRenderer lineRenderer = GetComponent<LineRenderer>();
        var t = Time.time;
        for (int i = 0; i < positions.Length; i++)
        {
            lr.SetPositions(positions);
        }

    }

}
