using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
	public class TrackScript : MonoBehaviour {

		public Vector3 startPoint;
		public Vector3 startOffset;
		public Vector3 startRotation;
		public float kartScale;

		public GameObject startWaypoint;


		// Use this for initialization
		void Awake () {
			Vector3 leftPoint = startPoint + startOffset;
			Vector3 rightPoint = startPoint - startOffset;

			GameObject player, ai1, ai2;

			if (MusicManager.washington == true) {
				print ("washington");
				player = Resources.Load ("Washington (Player)") as GameObject;
				ai1 = Resources.Load ("Taft (AI)") as GameObject;
				ai2 = Resources.Load ("Lincoln (AI)") as GameObject;
			} else if (MusicManager.lincoln == true) {
				print ("lincoln");
				player = Resources.Load ("Lincoln (Player)") as GameObject;
				ai1 = Resources.Load ("Taft (AI)") as GameObject;
				ai2 = Resources.Load ("Washington (AI)") as GameObject;
			} else {
				print ("taft");
				player = Resources.Load ("Taft (Player)") as GameObject;
				ai1 = Resources.Load ("Washington (AI)") as GameObject;
				ai2 = Resources.Load ("Lincoln (AI)") as GameObject;

			}

			Vector3 scale = new Vector3 (kartScale, kartScale, kartScale);
			GameObject kart = Instantiate (player, startPoint, Quaternion.Euler (startRotation)) as GameObject;
			kart.transform.localScale = scale;
			CarController script = kart.GetComponent<CarController> ();
			script.UpdateWaypoint (startWaypoint);
			kart = Instantiate (ai1, leftPoint, Quaternion.Euler (startRotation)) as GameObject;
			kart.transform.localScale = scale;
			script = kart.GetComponent<CarController> ();
			script.UpdateWaypoint (startWaypoint);
			kart = Instantiate (ai2, rightPoint, Quaternion.Euler (startRotation)) as GameObject;
			kart.transform.localScale = scale;
			script = kart.GetComponent<CarController> ();
			script.UpdateWaypoint (startWaypoint);
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}