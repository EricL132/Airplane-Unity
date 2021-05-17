using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
public class setHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    int[] highscore;
    int[] newHigh = new int[6];
  void Awake(){
        highscore = PlayerPrefsX.GetIntArray("highscores");
    }
    void Start()
    {
       
      /* for(var i =0;i<highscore.Length;i++){
          if(setScore.score>highscore[i]){
              if(i>0 &&highscore[i-1]>=setScore.score){
                  break;
              }

              highscore[i] = setScore.score;
              break;
          }
      } */
    if(!highscore.Contains(Scoring.Score)){
        for(var i =0;i<highscore.Length;i++){
          newHigh[i] = highscore[i];
      }
     newHigh[5] = Scoring.Score;
     Array.Sort(newHigh,(x, y) => y.CompareTo(x));
     Array.Resize(ref newHigh,newHigh.Length-1);

    PlayerPrefsX.SetIntArray("highscores",newHigh); 
    }
     
    }

    // Update is called once per frame
    void Update()
    {
    }
}
