using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public float velYSpeed = 5f;
    float velX = 0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * -velYSpeed;
        if(!GetComponent<Renderer>().isVisible){
            Destroy(gameObject);
        }
    }
}
