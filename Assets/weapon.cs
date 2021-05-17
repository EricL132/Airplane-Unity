using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !EventSystem.current.currentSelectedGameObject && !pauseScript.GameIsPaused){
           shoot();
        }
    }


    void shoot(){
        Instantiate(bulletPrefab,firepoint.position,firepoint.rotation);
    }
}
