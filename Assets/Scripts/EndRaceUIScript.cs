using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndRaceUIScript : MonoBehaviour {

    public Button raceAgain, quitToMenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void racingAgain()
    {
        // Add code to restart race with same conditions
        Debug.Log("Race Again!");
        SceneManager.LoadScene("CharSelect");
    }

    public void quitToTheDesktop()
    {
        // exit game
        Debug.Log("Desktop Quit");
        SceneManager.LoadScene("Quit");
    }
}
