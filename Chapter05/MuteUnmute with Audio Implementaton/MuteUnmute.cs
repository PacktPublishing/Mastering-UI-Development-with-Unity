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

	GameObject soundEffectsSource;
	GameObject musicSource;
	AudioSource musicPlaying;
	AudioSource soundPlaying;
	
	void Awake(){
		soundEffectsSource=GameObject.FindGameObjectWithTag("Sound");
		musicSource=GameObject.FindGameObjectWithTag("Music");
		
		if(musicSource!=null){
			musicPlaying=musicSource.GetComponent<AudioSource>();
		}
		
		if(soundEffectsSource!=null){
			soundPlaying=soundEffectsSource.GetComponent<AudioSource>();
		}

		musicImage=musicButton.GetComponent<Image>();
		soundImage=soundButton.GetComponent<Image>();

		//show correct music image when starting scene
		//music is off
		if(musicPlaying!=null){
			if (musicPlaying.mute==false) {
				musicImage.sprite=MusicOn;
			//music is on
			}else{
				musicImage.sprite=MusicOff;
			}
		}


		//show correct sound image when starting scene
		//sound is off
		if(soundPlaying!=null){
			if (soundPlaying.mute==false) {
				soundImage.sprite=SoundOn;
			//sound is on
			}else{
				soundImage.sprite=SoundOff;
			}
		}


	}
	
	public void MuteAndUnMuteMusic(){
		//mute music if on
		if (musicPlaying.mute==false) {
			musicImage.sprite=MusicOff;
			if(musicPlaying!=null){
				musicPlaying.mute=true;
			}
		
		//unmute music if off
		} else {
			musicImage.sprite=MusicOn;
			if(musicPlaying !=null){
				musicPlaying.mute=false;
			}

		}
		
	}
	
	public void MuteAndUnMuteSound(){
		//mute sound if on
		if (soundPlaying.mute==false) {
			soundImage.sprite=SoundOff;
			if(soundPlaying !=null){
				soundPlaying.mute=true;
			}
			
		//unmute sound if off
		} else {
			soundImage.sprite=SoundOn;
			if(soundPlaying !=null){
				soundPlaying.mute=false;
			}
		}
		
	}
}