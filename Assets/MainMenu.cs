using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public static string PlayerName = "";
    public Text inputText;
    public InputField holder;
    // Start is called before the first frame update
    void Update(){
        PlayerName = inputText.text;
    }
    public void PlayGame(){
        if(PlayerName!=""){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }else{
            holder.placeholder.GetComponent<Text>().text = "Enter Name To Start";
        }
    }

    public void QuitGame(){
        Application.Quit();
    }
}
