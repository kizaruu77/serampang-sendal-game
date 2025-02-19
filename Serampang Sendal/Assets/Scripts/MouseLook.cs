﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;
    public float minimumX = -90F;
    public float maximumX = 90F;
    public float minimumY = -60F;
    public float maximumY = 60F;
    float rotationY = 0F;
    float rotationX = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis ("Mouse X") * sensitivityX;
        rotationX = Mathf.Clamp (rotationX, minimumX, maximumX);
        rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
        transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
    }
}
