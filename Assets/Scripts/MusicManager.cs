using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public static bool audioStart = false;
	public static bool canPlay = true;
	public static bool toggleState;

	//Bool for racer choice
	public static bool washington = false;
	public static bool lincoln = false;
	public static bool taft = false;

	public static bool racerReset = false;


	//Might use this for the options in pause menu too

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

		if (Application.loadedLevelName == "Title") {
			RacerReset ();
		}

		//Calls the racer reset method
		if(racerReset == true){
			RacerReset ();
			racerReset = false;
		}
			
	}

	//Reset the racer choice
	public void RacerReset(){
		washington = false;
		lincoln = false;
		taft = false;
		print ("Racer reset");
	}

}
