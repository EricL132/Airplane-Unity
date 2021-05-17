using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameObject airplane = null;
    float velX = 0f;
    float velY = 5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(airplane==null){
            airplane = GameObject.Find("airplaneSprite");
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * velY;
        if(!GetComponent<Renderer>().isVisible){
            Destroy(gameObject);
        }
    }
}
