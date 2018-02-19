using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
	public CharacterController cc; 
	public float speed = 4f; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			cc.Move (transform.forward*speed*Time.deltaTime); 
		} 
		if (Input.GetKey (KeyCode.S)) { 
			cc.Move (transform.forward * -speed * Time.deltaTime); 
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0f, -90f * Time.deltaTime, 0f); 
		}
		if (Input.GetKey (KeyCode.D)) { 
			transform.Rotate (0f, 90f * Time.deltaTime, 0f); 
	}
}
}