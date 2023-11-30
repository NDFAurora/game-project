using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private float speed = 5f;
    Vector3 deplacement;

    // Update is called once per frame
    void Update()
    {
        float deplacementX = Input.GetAxisRaw("Horizontal");
        float deplacementZ = Input.GetAxisRaw("Vertical");

        deplacement = new Vector3(deplacementX, 0f, deplacementZ);
        deplacement = deplacement * speed * Time.deltaTime;
        transform.Translate(deplacement);
    }
}
