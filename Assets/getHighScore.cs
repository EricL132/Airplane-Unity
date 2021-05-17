using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    int[] arr = new int[] {0,0,0,0,0};
    int[] highscore;
    public GameObject table;
    
    void Awake(){
        /* PlayerPrefsX.SetIntArray("highscores",arr); */
        highscore = PlayerPrefsX.GetIntArray("highscores");
    }
    void Start()
    {   
        if(highscore.Length>0){
        int childCount = table.transform.childCount;
        for(var i =0;i<childCount;i++){
            if(i!=0){
                table.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = highscore[i-1].ToString();
            }
        }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
