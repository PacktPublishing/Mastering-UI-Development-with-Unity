using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestStateMachineBehaviour : StateMachineBehaviour {
	ChestAnimControls theControllerScript;

	public void Awake(){
		//get the script that holds the state machine logic
		theControllerScript=FindObjectOfType<ChestAnimControls>();

	}

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		
		theControllerScript.CheckForParameterSet();
	}
}
