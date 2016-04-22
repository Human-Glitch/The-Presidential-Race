using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public static bool audioStart = false;
	public static bool canPlay = true;
	public static bool toggleState;


	void Awake(){
		if (!audioStart) {
			GetComponent<AudioSource>().Play ();
			DontDestroyOnLoad (gameObject);
			audioStart = true;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Add in the track scene names to stop the music from playing
		//Change loadedlevelname to scenemanager
	/*
		if (Application.loadedLevelName == "Quit") {
			GetComponent<AudioSource>().Stop ();
			audioStart = false;
		}
	*/		

		if (canPlay == false) {
			AudioListener.pause = true;
			toggleState = true;
			//audioStart = false;

		}

		if (canPlay == true) {
			//audioStart = true;
			AudioListener.pause = false;
			toggleState = false;

		}

	}
		
}
