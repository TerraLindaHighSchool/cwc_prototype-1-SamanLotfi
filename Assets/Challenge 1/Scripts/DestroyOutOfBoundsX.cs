using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float topBound = 400;
    private float lowerBound = -200;
    
    //Removes things that are out of bounds
    void FixedUpdate()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
