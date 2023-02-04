using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Spawner
{
    [SerializeField, Tooltip("Tiempo entre disparo y disparo")] protected float delay;

    [SerializeField] protected float timeToBullet;
    private void Start()
    {
        timeToBullet = Time.time + delay;
    }
    protected void FixedUpdate()
    {
        if (Time.time >= timeToBullet)
        {
            Debug.Log("AHHHH");
            timeToBullet = Time.deltaTime + delay;
            Spawn();
        }
    }

}
