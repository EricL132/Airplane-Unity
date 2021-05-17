using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text pointsText;
    void Awake(){
        Destroy(GameObject.Find("PersistentCanvas"));
    }
    void Start(){
        pointsText.text = "Score: "+ Scoring.Score.ToString();
    }
    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = "Score: "+ score.ToString();
    }
    // Start is called before the first frame update
    public void RestartGame(){
        
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu(){
        SceneManager.LoadScene("StartMenu");
    }
}
