using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacterSwap : MonoBehaviour {
	public Image characterImage;
	Dropdown dropDown;

	void Awake(){
		dropDown=GetComponent<Dropdown>();
	}

	public void DropDownSelection(int selectionIndex){
		Debug.Log("player selected " +dropDown.options[selectionIndex].text);
		characterImage.sprite=dropDown.options[selectionIndex].image;	
	}
}
