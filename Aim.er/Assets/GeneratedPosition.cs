using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GeneratePosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
Vector3 GeneratePosition()
{
 int x,y,z;
 x = Random.Range(0,100);
 y = Random.Range(0,100);
z = Random.Range(0,20);
 return new Vector3(x,y,z);
}
}
