using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleUI : MonoBehaviour {
	public Button letsRace, credits, options, quit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Title Screen Buttons
	public void LetsRace(){
		print ("Lets Race!");
		//Load character select scene
	}

	public void Credits(){
		//print ("Credits");
		//load credit scene
		SceneManager.LoadScene("Credits");	
	}

	public void Options(){
		//print ("Options");
		// display options
		SceneManager.LoadScene("Options");
	}

	public void Quit(){
		//print ("Quit");
		// quit the application
		SceneManager.LoadScene("Quit");
	}
		
}
