using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserMover : MonoBehaviour
{
    public float speed;

    /////public Rigidbody rb;
    
    private void Destro()
    {
        Destroy(gameObject, 2.0f);
    }

    void Start()
    {
        GetComponent<Transform>().rotation = Quaternion.Euler(90, 0, 0);
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.up * speed;
        ////rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ////rb.AddForce(0, 0, -20);
        Destro();
    }
}
