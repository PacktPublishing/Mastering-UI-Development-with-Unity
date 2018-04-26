using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanels : MonoBehaviour {
	public CanvasGroup inventoryPanel;
	public bool inventoryUp=false;

	public CanvasGroup pausePanel;
	public bool pauseUp=false;

	// Use this for initialization
	void Start () {
		inventoryPanel.alpha=0;
		inventoryPanel.interactable=false;
		inventoryPanel.blocksRaycasts=false;

		pausePanel.alpha=0;
		pausePanel.interactable=false;
		pausePanel.blocksRaycasts=false;
	}
	
	// Update is called once per frame
	void Update () {
		//inventory panel
		if(Input.GetKeyDown(KeyCode.I) && pauseUp==false){
			//not visible
			if(inventoryUp==false){
				inventoryUp=true;
				inventoryPanel.alpha=1;
				inventoryPanel.interactable=true;
				inventoryPanel.blocksRaycasts=true;

			//already visible
			}else{
				inventoryUp=false;
				inventoryPanel.alpha=0;
				inventoryPanel.interactable=false;
				inventoryPanel.blocksRaycasts=false;
			}
		}

		//pause panel
		if(Input.GetButtonDown("Pause")){
			//not visible
			if(pauseUp==false){
				pauseUp=true;
				pausePanel.alpha=1;
				pausePanel.interactable=true;
				pausePanel.blocksRaycasts=true;
				Time.timeScale=0;

			//already visible
			}else{
				pauseUp=false;
				pausePanel.alpha=0;
				pausePanel.interactable=false;
				pausePanel.blocksRaycasts=false;
				Time.timeScale=1;
			}
		}
	}
}