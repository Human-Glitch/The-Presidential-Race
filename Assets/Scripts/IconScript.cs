using UnityEngine;
using System.Collections;

public class IconScript : MonoBehaviour {

	public GameObject parent;

	private float yVal;

	// Use this for initialization
	void Start () {
		yVal = transform.position.y - parent.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = parent.transform.position;
		pos.y += yVal;
		transform.position = pos;
	}
}
