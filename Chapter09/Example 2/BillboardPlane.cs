using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardPlane : MonoBehaviour {

	public Camera theCamera;

	void Update(){
		transform.LookAt(2*transform.position-theCamera.transform.position);
	}
}
