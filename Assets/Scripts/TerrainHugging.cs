using UnityEngine;
using System.Collections;

//Code comes from SirGive
//http://answers.unity3d.com/questions/168097/orient-vehicle-to-ground-normal.html

public class TerrainHugging : MonoBehaviour {
	public float meterRadius = .5f;
	public float meterDistance = 5f;

	void Update(){
		RaycastHit hit;
		if (Physics.SphereCast (transform.position, meterRadius, -transform.up, out hit, meterDistance)) {
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.LookRotation (Vector3.Cross (transform.right, hit.normal), hit.normal), Time.deltaTime * 5.0f);
		}
	}
}
