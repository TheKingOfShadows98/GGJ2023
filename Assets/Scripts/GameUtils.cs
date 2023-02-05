using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        FindObjectOfType<ScoreSystem>().viewFinal();
    }

    public void RestartGame(){
        EndMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
