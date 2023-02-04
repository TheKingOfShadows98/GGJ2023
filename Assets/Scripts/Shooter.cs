using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Spawner
{
    // Time Beetween shoots.
    [SerializeField, Tooltip("Tiempo entre disparo y disparo")] protected float delay;

    // mark the next time to shoot a bullet.
    protected float timeToBullet;
    private void Start()
    {
        //Set the mark in "Dekay" times after.
        timeToBullet = Time.time + delay;
    }
    protected void FixedUpdate()
    {
        // If Current Time is more or iquals to the mark, reset Timer and Spawn Bullet
        if (Time.time >= timeToBullet)
        {
            //Set the mark in "Dekay" times after.
            timeToBullet = Time.deltaTime + delay;
            // Use The Spawner.Spawn to spawn a bullet.
            Spawn();
        }
    }

}
