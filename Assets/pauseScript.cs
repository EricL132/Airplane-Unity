using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    private GameObject audList;
    void Start()
    {
        audList = GameObject.Find("Music");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }


    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused=false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused=true;
    }

    public void LoadMenu(){
        GameObject pause = GameObject.Find("PersistentCanvas");
        Destroy(pause);
        GameIsPaused=false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
    public void QuitGame(){
        Application.Quit();
    }

}
