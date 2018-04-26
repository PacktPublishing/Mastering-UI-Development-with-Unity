using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter8Examples : MonoBehaviour {
	Animator theAnimator;

	void Awake(){
		theAnimator=GetComponent<Animator>();
	}

	public void SetAnimatorParameters(){
		theAnimator.SetFloat("FloatParameter", 1.0f);
		theAnimator.SetInteger("IntParameter", 1);
		theAnimator.SetBool("BoolParameter", true);
		theAnimator.SetTrigger("TriggerParameter"); //sets to true
		theAnimator.ResetTrigger("TriggerParameter"); //sets to false
	}

	public void ExampleFunction(){
		Debug.Log("The Animation Event is not sending an argument");
	}

	public void ExampleParameterFunction(int value){
		Debug.Log("The Animation Event sends the following value: " +value);
	}
}
