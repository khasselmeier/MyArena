using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MedPackBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(this.transform.parent.gameObject);
            UnityEngine.Debug.Log("Speed Boost!");
            gameManager.Items += 1;
        }
    }
}