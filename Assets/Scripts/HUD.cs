using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Vehicles.Car
{
	public class HUD : MonoBehaviour {
		public Text timeLabel;
		public Text three, two, one, go;
		public bool starttime = false;
		private AudioSource beepSound;
		private bool raceStarted = false;

		public Text lapText;
		private int lap = 1;
		private int place = 1;

		private GameObject player, ai1, ai2;

		//public Text lapLabel;

		private float time;

		void Awake(){
		}
		void Start () {
			Time.timeScale = 0.1f;
			beepSound = GetComponent<AudioSource>();

			three.enabled = true;
			two.enabled = false;
			one.enabled = false;
			go.enabled = false;

			timeLabel.enabled = false;

			starttime = true;

			if(starttime == true){
				StartCoroutine ("CountDown");
			}

			
		
		}
		
		// Update is called once per frame
		void Update () {
			

			var minutes = time / 60; 	//Divide the guiTime by sixty to get the minutes.

			var seconds = time % 60;	//Use the euclidean division for the seconds.

			var fraction = (time * 100) % 100; //Can add fraction if we want

			//updates the HUD time text
			if (raceStarted == true) {
				time = time + Time.deltaTime;
				timeLabel.enabled = true;
				timeLabel.text = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
			}

			//Add lap counter code here... still deciding how to implement this
		}

		IEnumerator CountDown(){
			beepSound.Play ();
			yield return new WaitForSeconds (0.09f);
			beepSound.Play ();
			three.enabled = false;
			two.enabled = true;
			yield return new WaitForSeconds (0.09f);
			beepSound.Play ();
			two.enabled = false;
			one.enabled = true;
			yield return new WaitForSeconds (0.09f);
			one.enabled = false;
			go.enabled = true;
			yield return new WaitForSeconds (0.09f);
			go.enabled = false;
			raceStarted = true;
			startTime ();
		}
		void startTime(){
			Time.timeScale = 1.0f;
		}

		public void SetRacers(GameObject ob1, GameObject ob2, GameObject ob3) {
			player = ob1;
			ai1 = ob2;
			ai2 = ob3;
		}

		public void Lap(GameObject lapOb) {
			if (lapOb == player) {
				if (lap == 3) {
					if (place == 1) {

						SceneManager.LoadScene ("end_race");
					} else {

						SceneManager.LoadScene ("loose_race");
					}
				}
				lap++;
				lapText.text = lap + "/3";
			}
			
		}

	}
}