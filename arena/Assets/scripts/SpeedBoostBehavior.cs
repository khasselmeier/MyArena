using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostBehavior : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(this.transform.parent.gameObject);
            UnityEngine.Debug.Log("Speed Boost!");
        }
    }
}