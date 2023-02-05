using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    public GameObject children;
    public AudioClip sound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    private void Start()
    {
      audioSource = GetComponentInChildren<AudioSource>();   
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.CompareTag("Arrow")){
            audioSource.PlayOneShot(sound);
            children.transform.parent=null;
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            FindObjectOfType<ScoreSystem>().addPoints(1000);
        }
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("YOU LOSE");
            Time.timeScale = 0;
        }

    }
}
