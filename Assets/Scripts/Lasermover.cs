using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasermover : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private void Destro()
    {
        Destroy(gameObject, 2.0f);
    }

    void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destro();
    }
}
