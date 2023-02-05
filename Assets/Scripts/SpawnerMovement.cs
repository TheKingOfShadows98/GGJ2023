using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    LanesData lanesData;
    int currentLane = 0;
    private void Start()
    {
        lanesData = FindObjectOfType<LanesData>();

    }
    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = lanesData.GetLineHeight(currentLane);
        transform.position = newPosition;

        if (false)
        {
            int l = Random.Range(0, lanesData.getNumLanes());
            currentLane = currentLane >= lanesData.getNumLanes() ? lanesData.getNumLanes() - 1 : currentLane < 0 ? 0 : currentLane;
        }
    }
}
