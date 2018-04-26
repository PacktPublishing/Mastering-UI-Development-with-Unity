/// <summary>
/// A simple script that shows and hides two canvas groups on timers
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageInteractions : MonoBehaviour {
	public CanvasGroup theExclaimationPoint;
	public CanvasGroup theDialogBox;

	void Start(){
		StartCoroutine(ShowTheExclaimationPoint(3.0f)); //show the exclaimation point 3 seconds after start
	}	


	public IEnumerator ShowTheExclaimationPoint(float howLong){
		yield return new WaitForSeconds(howLong);
		theExclaimationPoint.alpha=1;
		theExclaimationPoint.interactable=true;
		theExclaimationPoint.blocksRaycasts=true;

	}

	//will show the dialog box and hide the exclaimation point after a button is pressed
	public void ShowTheDialogBox(){
		//hide the exclaimation point
		theExclaimationPoint.alpha=0;
		theExclaimationPoint.interactable=false;
		theExclaimationPoint.blocksRaycasts=false;

		//show the dialog
		theDialogBox.alpha=1;
		theDialogBox.blocksRaycasts=true;

		StartCoroutine(HideTheDialogBox(5.0f)); //automatically hide the dialog box in 5 seconds
	}

	public IEnumerator HideTheDialogBox(float howLong){
		yield return new WaitForSeconds(howLong);
		theDialogBox.alpha=0;
		theDialogBox.blocksRaycasts=false;

		StartCoroutine(ShowTheExclaimationPoint(10.0f));//once the dialog box is hidden, in 10 seconds, the exclaimation point will reappear
	}
}
