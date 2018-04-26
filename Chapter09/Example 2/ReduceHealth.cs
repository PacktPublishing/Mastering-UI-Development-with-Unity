using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReduceHealth : MonoBehaviour {
	int totalHealth=100;
	int currentHealth=100;
	float healthPercent;

	public RectTransform healthFill;

	public void ReduceHealthBar(){
		Debug.Log("click");
		currentHealth=currentHealth-1;
		if(currentHealth<0){
			currentHealth=0;
		}
		healthPercent=(float)currentHealth/totalHealth;
		healthFill.localScale=new Vector2(healthPercent, 1f);
	}

}
n