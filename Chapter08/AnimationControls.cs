/// <summary>
/// Script attached to animated items, so Animation Event can be used
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour {

	Animator chestAnimController;

	void Awake(){
		chestAnimController=Camera.main.GetComponent<Animator>();

	}

	//call as an animation event on last frame of animations
	public void ProceedStateMachine(){
		chestAnimController.SetTrigger("AnimationComplete");
		if(chestAnimController.GetCurrentAnimatorStateInfo(0).IsName("Canvas Fading Out")){
				Debug.Log("Animation Complete trigger");
		}
	}
}
