using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;
    public Camera MainCamera;
    public bool RotateWithPlayer = true;

    public void Start()
    {
        SetPosition();
        SetRotation();
    }

    void LateUpdate()
    {
        if (player != null)
        {
            SetPosition();

            if (RotateWithPlayer && MainCamera)
            {
                SetRotation();
            }
        }
    }

    private void SetRotation()
    {
        transform.rotation =
            Quaternion.Euler(90.0f, MainCamera.transform.eulerAngles.y, 0.0f);
    }

    private void SetPosition()
    {
        var newPos = player.position;
        newPos.y = transform.position.y;

        transform.position = newPos;
    }
}
