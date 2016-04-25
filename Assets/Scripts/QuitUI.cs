using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class QuitUI : MonoBehaviour {
	public Button yes, no;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Yes(){
		//Quits the application
		print ("Quitting");
		//Application.Quit ();
	}

	public void No(){
		//Goes back to the title
		//print ("Nope");
		SceneManager.LoadScene ("Title");
	}
}
