using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     GameObject mycube;
    // Start is called before the first frame update
    void Start()
    {
        mycube=GameObject.CreatePrimitive(PrimitiveType.Cube);
        mycube.transform.localScale=new Vector3(1f,3f,5f);
        mycube.transform.localPosition=new Vector3(0f,5f,3f);
    }

    // Update is called once per frame
    void Update()
    {
       mycube.transform.Rotate(new Vector3(0f,0.1f,0f));
    }
}
