using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Camera fpsCamera;
    Animator animation;

    void Start()
    {
        animation = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hitInfo))
        {
            Debug.Log(hitInfo.transform.name);
            animation.SetTrigger("Shoot");
        }
    }
}
