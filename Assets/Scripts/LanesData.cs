using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanesData : MonoBehaviour
{
    [SerializeField, Tooltip("Pon aqui los identificadores de linea.")] GameObject[] Lanes = new GameObject[0];


    public int getNumLanes() => Lanes.Length;
    public float GetLineHeight(int lane) => Lanes[lane].transform.position.y;

}
