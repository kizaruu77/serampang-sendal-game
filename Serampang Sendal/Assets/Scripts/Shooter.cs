﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject peluru;
    public Camera cam;
    public int ammo;
    public bool isFiring;
    public Text ammoCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&& !isFiring && ammo > 0)
        {
            isFiring = true;
            ammo--;
            isFiring = false;
            Shoot();
        }
        ammoCount.text = "Amunisi " + (int)ammo;
    }
    public void Shoot(){
        GameObject peluruPadu = Instantiate(peluru);
        peluruPadu.transform.position = cam.transform.position;
        peluruPadu.transform.forward = cam.transform.forward;
    }
   
    public void OnTriggerEnter(Collider amunisi) {
        if (amunisi.CompareTag("Sandal"))
        {
            ammo++;
        }
    }
}
