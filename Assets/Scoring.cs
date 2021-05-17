using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    public Text ScoreText;
    public static int Score=0;
    private int inARow = 0;
    public void addScore(){
            int ScoreToAdd = 1000;
            if(inARow>2){
                ScoreToAdd = 1000*inARow;
            }
            Score += ScoreToAdd;
            inARow++;
            ScoreText.text = "Score: "+Score.ToString();
    }
    public void loseScore(){
        if(Score>0){
            Score -= 1000;
            inARow=0;
            ScoreText.text = "Score: "+Score.ToString();
        }
           
    }

    public void printNewScore(){
        ScoreText.text = "Score: "+Score.ToString();
    }
}
