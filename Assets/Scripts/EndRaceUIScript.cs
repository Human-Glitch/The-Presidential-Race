using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndRaceUIScript : MonoBehaviour {

    public Button raceAgain, quitToMenu;
    public Text placeText;
    public int place;

	// Use this for initialization
	void Start () {
        place = MusicManager.place;
        placeText.text = "You Placed: " + place.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void racingAgain()
    {
        // Add code to restart race with same conditions
        Debug.Log("Race Again!");
        SceneManager.LoadScene("Title");
    }

    public void quitToTheDesktop()
    {
        // exit game
        Debug.Log("Desktop Quit");
        SceneManager.LoadScene("Quit");
    }
}
