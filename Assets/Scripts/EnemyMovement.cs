using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
     public float GetSpeed() => speed;


    private void FixedUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

}
