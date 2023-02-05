using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    LanesData lanesData;
    const string VERTICAL_AXIS = "Vertical";
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

        if (Input.GetButtonDown(VERTICAL_AXIS))
        {
            currentLane = currentLane + Mathf.FloorToInt(Input.GetAxisRaw(VERTICAL_AXIS));
            currentLane = currentLane >= lanesData.getNumLanes() ? lanesData.getNumLanes() - 1 : currentLane < 0 ? 0 : currentLane;
        }
    } 
}
