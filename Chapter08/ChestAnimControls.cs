/// <summary>
/// works with state machine to control general logic of chest animation
/// used to set parameters of state machine
/// called from buttons and StateMachineBehaviours
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimControls : MonoBehaviour {
	////////////
	/// enums and classes
	////////////

	//the different types of parameters
	public enum TypesOfParameters{floatParam, intParam, boolParam, triggerParam};

	//properties of animation parameters
	[System.Serializable]
	public class ParameterProperties{
		public string parameterString; //what string sets it?
		public string whichState; //name of the state its called from, null=not called by the state machine
		public TypesOfParameters parameterType; //what type of Animator Parameter is it?
		public float floatValue; //float value required, if float
		public int intValue; //int value required, if int
		public bool boolValue; //bool value required, if bool
	}

	//make a list of all animatable objects and their parameters
	[System.Serializable]
	public class AnimatorProperties{
		public string name; //so the name will appear in the inspector rather than "Element 0, Element 1, etc"
		public Animator theAnimator; //the animator
		public List<ParameterProperties> animatorParameters; //its parameter properties
	}

	////////////
	/// variables
	////////////
	Animator theStateMachine; //the animator component on the state machine
	public List<AnimatorProperties> animatedItems; //all the animated items controlled by this state machine


	void Awake(){
		theStateMachine=GetComponent<Animator>(); //get the state machine
	}

	//called by player interactions (Waiting On Player)
	public void PlayerInputTrigger(string triggerString){
		theStateMachine.SetTrigger(triggerString);
	}

	//check if any of the animations need their parameters set
	//called from enter state
	public void CheckForParameterSet(){
		//loop through all of the objects
		foreach (AnimatorProperties animatorProp in animatedItems){
			//loop through its set of parameters
			foreach(ParameterProperties parameter in animatorProp.animatorParameters){
				//find the ones called on the current state
				if(theStateMachine.GetCurrentAnimatorStateInfo(0).IsName(parameter.whichState)){
					//determine parameter type
					//float types
					if(parameter.parameterType==TypesOfParameters.floatParam){
						animatorProp.theAnimator.SetFloat(parameter.parameterString, parameter.floatValue);

					//int types
					}else if(parameter.parameterType==TypesOfParameters.intParam){
						animatorProp.theAnimator.SetInteger(parameter.parameterString, parameter.intValue);

					//bool type
					}else if(parameter.parameterType==TypesOfParameters.boolParam){
						animatorProp.theAnimator.SetBool(parameter.parameterString, parameter.boolValue);

					//trigger type
					}else{
						animatorProp.theAnimator.SetTrigger(parameter.parameterString);
					}
				}
			}
		}
	}
}
