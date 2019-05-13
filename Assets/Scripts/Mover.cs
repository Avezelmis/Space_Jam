using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speedAsteroid;
        
    void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speedAsteroid;
        Destroy(gameObject, 10.0f);
    }
    
}
