using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
  public float movementSpeed = 5.0f;
  
  void Start() {
    Debug.Log("Start");
  }
  void Update() {
    // Updates the position and moves it to the right
    transform.position += Vector3.right * Time.deltaTime * movementSpeed;
  }
}