using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float hp = 100f;

    public void Damage(float amountOf)
    {
        hp -= amountOf;

        if(hp <= 0f)
        {
            TargetEliminated();
        }
    }

    void TargetEliminated ()
    {
        Destroy(gameObject);
    }

}
