using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour{

    
    public TextMeshProUGUI scoreText;
    private int score=0;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text= "Puntaje: " + score;
    }



    public void addPoints(int num){

        score+=num;

    }
}
