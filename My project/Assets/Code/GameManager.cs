using System;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public GameObject ground;
    private float period = 4;
    public float timer = 0;
    void Start()
    {
        ground = GameObject.Find("Ground");
        if(ground == null )
        {
            throw new MissingReferenceException("Ground plane missing");
        }

        GameObject firstGameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        firstGameObject.AddComponent<Rigidbody>();
        firstGameObject.transform.localScale = Vector3.one;
        firstGameObject.transform.localPosition = new Vector3(0f, 3f, 0f);
    }

    void Update()
    {
        if(timer < period)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
        GroundSineRotation();
    }

    // Rotate ground plane to oscillate every <period>seconds
    void GroundSineRotation()
    {
        float amplitude = .5f;
        float motive = (float) (2 * Math.PI / 4);
        float phase = 1f;

        float sine = amplitude * Mathf.Sin(motive * (timer - phase));
        Debug.Log($"{sine} at {timer}");

        ground.transform.Rotate(new Vector3(0f,0f, sine/30.0f), Space.World);
    }
}
