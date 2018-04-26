using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPresses : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Submit")){
			Debug.Log("You pressed a submit key/button!");
		}

		float horizontalValue=Input.GetAxis("Horizontal");
		if(horizontalValue!=0){
			Debug.Log("You're holding down a horizontal button!");
		}

		if(Input.GetKeyDown(KeyCode.Alpha8)){
			Debug.Log("You pressed the 8 key for some reason!");
		}

		if(Input.GetMouseButtonDown(2)){
			Debug.Log("You pressed the middle mouse button!");
		}
	}
}
