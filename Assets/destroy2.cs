﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(waitKill());
    }

    IEnumerator waitKill(){
        yield return new  WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
}
