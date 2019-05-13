using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByContact : MonoBehaviour
{
    public GameObject explosion;

    public GameObject explosionPlayer;

    private GameObject cloneExplosion;

    public int scoreValue;

    private GameController gameController;

    private void Start()
    {
        GameObject GameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (GameControllerObject !=null)
        {
            gameController = GameControllerObject.GetComponent<GameController>();
        }
        if (GameControllerObject == null)
        {
            Debug.Log("Script not found");
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cloneExplosion = Instantiate(explosionPlayer, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation) as GameObject;
            gameController.GameOver();
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

            gameController.AddScore(scoreValue);
        }
    }  
 }
