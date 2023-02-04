using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    bool InAttack = false;
    [SerializeField] GameObject Arrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InAttack = Arrow.activeInHierarchy;
        if (Input.GetButtonDown("Fire1") && !InAttack)
        {
            
            Arrow.transform.position = transform.position;
            Arrow.SetActive(Arrow);
        }
        
    }
}
