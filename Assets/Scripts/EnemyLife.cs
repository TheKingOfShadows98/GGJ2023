using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.CompareTag("Arrow")){
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("YOU LOSE");
            Time.timeScale = 0;
        }

    }
}
