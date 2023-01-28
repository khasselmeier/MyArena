using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.forward * 0.025f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.back * 0.025f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.left * 0.025f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * 0.025f;
        }
    }
}
