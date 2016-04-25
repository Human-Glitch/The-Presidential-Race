using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
	public class WaypointScript : MonoBehaviour {

		public GameObject marker;
		public GameObject nextWaypoint;
		public bool isFinishLine = false;

		// Use this for initialization
		void Awake () {
			//print (GetPoint ());
			marker = Resources.Load ("Waypoint Center") as GameObject;
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		public void Mark(Vector3 point) {
			Instantiate (marker, point, Quaternion.identity);
		}

		void OnTriggerEnter(Collider other) {

			if (other.name == "Terrain")
				return;

			CarController otherScript = other.gameObject.GetComponent<CarController> ();
			if (otherScript != null && otherScript.targetWaypoint == this.gameObject) {
				otherScript.UpdateWaypoint(nextWaypoint);
				if(isFinishLine) {
					// Update GUI
					print("Lap, " + other.name);
				}
			}
			
		}

		public Transform GetPoint() {

			// From http://www.design.caltech.edu/erik/Misc/Gaussian.html
			float x1 = Random.value;
			float x2 = Random.value;
			float r = Mathf.Sqrt(-2 * Mathf.Log(x1)) * Mathf.Cos(2*Mathf.PI*x2) / 5f;
			if (r > 1f)
				r = 1f;
			if (r < -1f)
				r = -1f;
			//print (r);
			r *= transform.lossyScale.x * 0.5f;
			Vector3 point = transform.position;
			point.x += r;

			GameObject mark = Instantiate (marker, point, transform.rotation) as GameObject;
			Destroy (mark, 20);
			return mark.transform;
		}
	}
}