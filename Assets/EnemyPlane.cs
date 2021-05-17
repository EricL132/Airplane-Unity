using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnemyPlane : MonoBehaviour
{
    public GameObject explosion;
    public Slider healthBarSlider;
    public int currentHealth;
    public int maxHealth;
    public Text healthText;
    private Scoring Score;
    public AudioSource hitAud;

    void Awake(){

    }
    void Start()
    {
        
        currentHealth = maxHealth;
        Score = GameObject.FindGameObjectWithTag("ScoreBox").GetComponent<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="PlayerBullet" && GameObject.Find("airplaneSprite")){
            Destroy(other.gameObject);
            hitAud.Play();
            currentHealth -= 10;
            healthBarSlider.maxValue = maxHealth;
            healthBarSlider.value = currentHealth;
            healthText.text = currentHealth.ToString()+"/"+maxHealth.ToString();
            Score.addScore();
            if(currentHealth==0){
                GameObject e = Instantiate(explosion) as GameObject;
                e.transform.position = transform.position;
                Destroy(gameObject);
                


                
            }
        }
    }
    
}
