using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {

	public ParticleSystem stars;

	void PlayTheParticles(){
		if(!stars.isPlaying){
			stars.Play();
		}
	}
}
