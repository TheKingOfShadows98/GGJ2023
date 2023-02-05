using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject EndMenu;

    private void Start()
    {
        Time.timeScale = 0;
        EndMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void StartGame()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void EndGame()
    {
        EndMenu.SetActive(true);
        Time.timeScale = 0;
    }

}
