using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class rushmoreOptions : MonoBehaviour {
	public Toggle mute;


	// Use this for initialization
	void Start () {
		mute.isOn = MusicManager.toggleState;
	}

	// Update is called once per frame
	void Update () {

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
