using UnityEngine;
using System.Collections;

public class WheelScript : MonoBehaviour {

	[SerializeField] private GameObject parent;

	private Vector3 parentStartPos;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		parentStartPos = parent.transform.position;
		print (startPos);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = (parent.transform.position - parentStartPos) + startPos;
		//transform.position = pos;
		transform.Rotate(0, 2, 0);
	}
}
 