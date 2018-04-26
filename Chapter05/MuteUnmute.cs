using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteUnmute : MonoBehaviour {
	public Button musicButton;
	public Button soundButton;
	
	Image musicImage;
	Image soundImage;
	
	public Sprite MusicOn;
	public Sprite MusicOff;
	
	public Sprite SoundOn;
	public Sprite SoundOff;

	bool musicMuted;
	bool soundMuted;


	
	void Awake(){
		musicImage=musicButton.GetComponent<Image>();
		soundImage=soundButton.GetComponent<Image>();
	}
	
	public void MuteAndUnmuteMusic(){
		if (musicMuted==false) { //mute music 
			musicImage.sprite=MusicOff;
			musicMuted=true;
		
		} else { //unmute music 
			musicImage.sprite=MusicOn;
			musicMuted=false;
		}
	}
	
	public void MuteAndUnmuteSound(){
		
		if (soundMuted==false) { //mute sound 
			soundImage.sprite=SoundOff;
			soundMuted=true;
		
		} else { //unmute sound 
			soundImage.sprite=SoundOn;
			soundMuted=false;
		}
	}
}