﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointspeace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if (collision.transform.name == "Rocket(Clone)"){
            Score.score -= 50;
            Debug.Log("Civilian");
        }
    }
}
