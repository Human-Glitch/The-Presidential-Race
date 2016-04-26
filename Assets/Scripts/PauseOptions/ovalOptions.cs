using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ovalOptions : MonoBehaviour {
	public Toggle mute;


	// Use this for initialization
	void Start () {
		mute.isOn = MusicManager.toggleState;

	}

	public void Mute(){
		//Mute the music

		if (mute.isOn) {
			//print ("Muted");
			MusicManager.canPlay = false;

		}

		if (!mute.isOn) {
			//print ("Playing");
			MusicManager.canPlay = true;
		}
	}
}
