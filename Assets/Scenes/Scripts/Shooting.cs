using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 100f;
    public Camera fpsCamera;
    Animator meh_animator;
    public ParticleSystem flash;

    void Start()
    {
        meh_animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            flash.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        meh_animator.SetTrigger("Shoot");
        
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hitInfo))
        {
            Debug.Log(hitInfo.transform.name);
            Target target = hitInfo.transform.GetComponent<Target>();
            if (target != null)
            {
                target.Damage(damage);
            }
        }
    }
}
