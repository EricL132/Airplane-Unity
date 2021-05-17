using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class animationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("airplaneSprite");
        enemy = GameObject.Find("EnemyPlane");
        if(player==null){
            StartCoroutine(playerGone());
            

        }
        if(enemy==null){
            StartCoroutine(enemyGone());
        }
    }

     IEnumerator playerGone(){
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator enemyGone(){
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}
