using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByContact : MonoBehaviour
{
    public GameObject explosion;

    public GameObject explosionPlayer;

    private GameObject cloneExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cloneExplosion = Instantiate(explosionPlayer, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation) as GameObject;
            Destroy(other.gameObject);
            Destroy(gameObject);
            Destroy(cloneExplosion, 1.0f);
        }
        if (other.tag == "LaserStrike")
        {
            cloneExplosion = Instantiate(explosion, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation) as GameObject;
            Destroy(other.gameObject); 
            Destroy(gameObject);
            Destroy(cloneExplosion, 1.0f);
        }
    }  
 }
