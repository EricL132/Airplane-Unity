using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour{
    // Update is called once per frame
    public GameObject explosion;
    public Slider healthBarSlider;
    public int currentHealth;
    public int maxHealth;
    public Text healthText;
    private Scoring Score;
    private Text playerName;
    public AudioSource hitAud;
    void Awake(){
        playerName = GameObject.Find("NameText").GetComponent<Text>();
        playerName.text=MainMenu.PlayerName;
        Score = GameObject.FindGameObjectWithTag("ScoreBox").GetComponent<Scoring>();
    }
    void Start(){
    }

    void Update()
    {   

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))  
        {  
            
                transform.Translate(0,Input.GetAxis("Vertical") * 15f * Time.deltaTime,0f,0f);


        }  

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Input.GetAxis("Horizontal")*15f*Time.deltaTime,0f,0f);
        }
        //keeps plane inside screen
        transform.position= new Vector3(Mathf.Clamp(transform.position.x,-40f,40f),Mathf.Clamp(transform.position.y,-20f,5f),transform.position.z);
        
    }


        void OnTriggerEnter2D(Collider2D other){
            if(other.gameObject.tag=="EnemyBullet" && GameObject.Find("EnemyPlane")){
            Destroy(other.gameObject);
            hitAud.Play();
            currentHealth -= 10;
            healthBarSlider.maxValue = maxHealth;
            healthBarSlider.value = currentHealth;
            healthText.text = currentHealth.ToString()+"/"+maxHealth.ToString();
            Score.loseScore();
            if(currentHealth==0 ){
                Scoring.Score = 0;
                Score.printNewScore();
                GameObject e = Instantiate(explosion) as GameObject;
                e.transform.position = transform.position;
                if(SceneManager.GetActiveScene().buildIndex==1){
                    Destroy(GameObject.Find("PersistentCanvas"));
                } 
                Destroy(gameObject);
                
                /* SceneManager.LoadScene("GameOver"); */
                
            }
            }
        }

 
}
