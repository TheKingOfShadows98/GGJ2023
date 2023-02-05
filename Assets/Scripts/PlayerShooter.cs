using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource audioSource;
    bool InAttack = false;
    [SerializeField] GameObject Arrow;

    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        InAttack = Arrow.activeInHierarchy;
        if (Input.GetButtonDown("Fire1") && !InAttack)
        {
            audioSource.PlayOneShot(sound);
            Arrow.transform.position = transform.position;
            Arrow.SetActive(Arrow);
        }
        
    }
}
