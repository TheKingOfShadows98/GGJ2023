using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public float max;
    public float min;
     public float GetSpeed() => speed;

    void Start(){
       speed= Random.Range(min,max); 
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

}
