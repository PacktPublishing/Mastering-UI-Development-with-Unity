using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingAnalogStick : MonoBehaviour {
	//for the analog stick
	public RectTransform theStick;
	Vector2 mouseStartPosition;
	Vector2 mouseCurrentPosition;
	public int dragPadding=30;
	public int stickMoveDistance=30;

	//so it can float
	public RectTransform theBase;
	CanvasGroup theBaseVisibility;
	public bool stickAdded=false;

	void Awake(){
		theBaseVisibility=theBase.GetComponent<CanvasGroup>();
	}

	public void AddTheStick(){
		theBase.anchoredPosition=Input.mousePosition;
		theStick.anchoredPosition=Vector2.zero;
		mouseStartPosition=Input.mousePosition;
		stickAdded=true;

		theBaseVisibility.alpha=1;
		theBaseVisibility.interactable=true;
		theBaseVisibility.blocksRaycasts=true;
	}

	void Update(){
		if(stickAdded==true){
			Dragging();

			if(Input.GetMouseButtonUp(0)){
				theBaseVisibility.alpha=0;
				theBaseVisibility.interactable=false;
				theBaseVisibility.blocksRaycasts=false;

				stickAdded=false;
				StoppedDragging();
			}
		}
	}

	public void StartingDrag(){
		mouseStartPosition=Input.mousePosition;
	}


	public void Dragging(){
		float xPos;
		float yPos;
		mouseCurrentPosition=Input.mousePosition;
		if(mouseCurrentPosition.x<mouseStartPosition.x-dragPadding){
			MovingLeft();
			xPos=-10;
		}else if(mouseCurrentPosition.x>mouseStartPosition.x+dragPadding){
			MovingRight();
			xPos=10;
		}else{
			xPos=0;
		}

		if(mouseCurrentPosition.y>mouseStartPosition.y+dragPadding){
			MovingUp();
			yPos=10;
		}else if(mouseCurrentPosition.y<mouseStartPosition.y-dragPadding){
			MovingDown();
			yPos=-10;
		}else{
			yPos=0;
		}

		theStick.anchoredPosition=new Vector2(xPos,yPos);
	}

	public void StoppedDragging(){
		theStick.anchoredPosition=Vector2.zero;
	}

	public void MovingLeft(){
		Debug.Log("move left");
	}

	public void MovingRight(){
		Debug.Log("move right");
	}

	public void MovingUp(){
		Debug.Log("move up");
	}

	public void MovingDown(){
		Debug.Log("move down");
	}
}
