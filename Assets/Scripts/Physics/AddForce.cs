using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
	public int startForce;
	public float waitTime = 10;
	public Vector3 startAngle;
	// Use this for initialization
	void Start () {
		transform.rotation *= Quaternion.Euler (startAngle);
		Rigidbody r = GetComponent<Rigidbody> ();
		r.AddForce (transform.forward * startForce);
		StartCoroutine (r.WaitAndDestroy (waitTime));
	}
}
