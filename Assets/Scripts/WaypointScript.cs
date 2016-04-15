using UnityEngine;
using System.Collections;

public class WaypointScript : MonoBehaviour {

	GameObject marker;
	public GameObject nextWaypoint;
	public bool isFinishLine = false;

	// Use this for initialization
	void Start () {
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

		//print ("Hit");

		KartMovement otherScript = other.gameObject.GetComponent<KartMovement> ();
		if (otherScript.targetWaypoint == this.gameObject) {
			otherScript.UpdateWaypoint(nextWaypoint);
			if(isFinishLine) {
				// Update GUI
				print("Lap, " + other.name);
			}
		}
		
	}

	public Vector3 GetPoint() {

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
		return point;
	}
}
