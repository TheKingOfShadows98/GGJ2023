using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Store a GameObject Patter to Instantiate
    [SerializeField, Tooltip("Guarda aquí el objeto que quieres que se Spawnee.")] protected GameObject prefab;

    public void Spawn() => Spawn(transform.position);
    public void Spawn( Vector3 position)
    {
        GameObject obj = Instantiate(prefab);
        obj.transform.position = position;
    }
}
