using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ImmortalityBehavior : MonoBehaviour
{
    public float ImmortalityDuration = 10f;
    PlayerBehavior playerBehavior;

    void Awake()
    {
        playerBehavior = GameObject.Find("player").GetComponent<PlayerBehavior>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(this.transform.parent.gameObject);
            UnityEngine.Debug.Log("Immortality!");

            PlayerBehavior player = collision.gameObject.GetComponent<PlayerBehavior>();
            /*
             player.Immortality(this, //immortality code);
            */
        }
    }
}
