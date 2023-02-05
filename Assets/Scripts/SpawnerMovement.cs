using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    LanesData lanesData;
    int currentLane = 0;
    Timer timer = new Timer(1f);
    private void Start()
    {
        lanesData = FindObjectOfType<LanesData>();
        timer.Play();
    }
    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = lanesData.GetLineHeight(currentLane);
        transform.position = newPosition;

        if (timer.IsDone(true))
        {
            int l = Random.Range(0, lanesData.getNumLanes());
            currentLane = l;
        }
    }
}
