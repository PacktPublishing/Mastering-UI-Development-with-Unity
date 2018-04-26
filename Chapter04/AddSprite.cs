using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class AddSprite : MonoBehaviour {
	public Image theImage;
	public Sprite theSprite;

	// Use this for initialization
	void Start () {
		theImage.sprite=theSprite;
		theImage.preserveAspect=true;
	}
}
