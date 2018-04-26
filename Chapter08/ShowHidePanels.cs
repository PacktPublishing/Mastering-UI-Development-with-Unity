using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanels : MonoBehaviour {
	public Animator inventoryPanelAnim;
	public bool inventoryUp=false;

	public Animator pausePanelAnim;
	public bool pauseUp=false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//inventory panel
		if(Input.GetKeyDown(KeyCode.I) && pauseUp==false){
			//not visible
			if(inventoryUp==false){
				inventoryUp=true;
				inventoryPanelAnim.SetTrigger("FadeIn");

			//already visible
			}else{
				inventoryUp=false;
				inventoryPanelAnim.SetTrigger("FadeOut");
			}
		}

		//pause panel
		if(Input.GetButtonDown("Pause")){
			//not visible
			if(pauseUp==false){
				pauseUp=true;
				Time.timeScale=0;
				pausePanelAnim.SetTrigger("FadeIn");

			//already visible
			}else{
				pauseUp=false;
				Time.timeScale=1;
				pausePanelAnim.SetTrigger("FadeOut");
			}
		}
	}
}