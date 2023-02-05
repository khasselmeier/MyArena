using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
    {
        if(other.name == "player")
        {
            UnityEngine.Debug.Log("Player detected - attack!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "player")
        {
            UnityEngine.Debug.Log("Player out of range, resume patrol");
        }
    }
}
