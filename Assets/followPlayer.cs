using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    Transform target;
    public float speed;
    void Awake(){

    }
    void Start()
    {   
        target = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if(target!=null){
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);

        }

        

    }
}
