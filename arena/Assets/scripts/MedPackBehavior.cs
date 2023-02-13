using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MedPackBehavior : MonoBehaviour
{
    public float MedPackMultiplier = 2.0f;
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
            UnityEngine.Debug.Log("Med Pack!");

            PlayerBehavior player = collision.gameObject.GetComponent<PlayerBehavior>();
            /*
             player.MedPack( //med pack code):
            */
        }
    }
}
