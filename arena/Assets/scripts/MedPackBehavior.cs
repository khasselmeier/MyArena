using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MedPackBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Destroy(this.transform.parent.gameObject);

            UnityEngine.Debug.Log("Health pack collected!");
        }
    }
}
