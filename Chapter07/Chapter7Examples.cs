using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter7Examples : MonoBehaviour {

	public void ToggleWithoutParameter(){
		Debug.Log("changed");
	}

	public void ToggleWithParameter(bool value){
		Debug.Log(value);
	}

	public void SliderWithoutParameter(){
		Debug.Log("changed");
	}

	public void SliderWithParameter(float value){
		Debug.Log(value);
	}

	public void ScrollViewWithParameter(Vector2 value){
		Debug.Log(value);
	}

	public void InputFieldValueChangeWithoutParameter(){
		Debug.Log("changed");
	}

	public void InputFieldValueChangeWithParameter(string value){
		Debug.Log(value);
	}

	public void InputFieldOnEndEditWithoutParamter(){
		Debug.Log("end");
	}

	public void InputFieldOnEndEditWithParamter(string value){
		Debug.Log(value);
	}


}
