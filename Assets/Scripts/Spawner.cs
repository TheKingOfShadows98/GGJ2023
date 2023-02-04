using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Store a GameObject Patter to Instantiate
    [SerializeField, Tooltip("Guarda aquí el objeto que quieres que se Spawnee.")] protected GameObject prefab;

    // Spawn obj in current Position
    public void Spawn() => Spawn(transform.position);
    public void Spawn( Vector3 position)
    {
        // Instantiate a obj into Current Scene
        GameObject obj = Instantiate(prefab);
        // Set Position to obj.
        obj.transform.position = position;
    }
}
