using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeapon : MonoBehaviour
{
    public GameObject redBullet;
    public GameObject blueBullet;
    public Transform firepoint;
    public float Timer;
    private float countTimer ;
    void Start(){
        countTimer= Timer;
    }
    void Update()
    {
        countTimer -= Time.deltaTime;
        if(countTimer<=0){
            shoot();
            countTimer = Timer;
        }
        
    }


    void shoot(){
        int num = Random.Range(0,20);
        if(num>=15){
        Instantiate(blueBullet,firepoint.position,firepoint.rotation);
        Vector3 eulerRotation = firepoint.rotation.eulerAngles;
        firepoint.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 50);
        Instantiate(blueBullet,firepoint.position,firepoint.rotation);
        firepoint.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, -50);
        Instantiate(blueBullet,firepoint.position,firepoint.rotation);
        firepoint.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);

        }else{
        Instantiate(redBullet,firepoint.position,firepoint.rotation);

        }
    }
}
