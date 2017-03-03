using UnityEngine;
using System.Collections;
//movement classes derive from the character class.
public class PlayerMove : Player {
	public float speed = 1;
	public static Transform headTransform;
	public static bool head,canMove = true;
	// Use this for initialization
	void Start () {
		PlayerSettings ();
		headTransform = (head) ? transform : FindObjectOfType<PlayerLook> ().transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = (headTransform.forward * Input.GetAxis ("Vertical")) + (transform.right * Input.GetAxis ("Horizontal")) * speed * Time.deltaTime;
		target = headTransform;
		if (!canMove) {
			newPos = Vector3.zero;
		}
		UpdateNMA (newPos);
	}
	public static IEnumerator LookAt(Transform t, Vector3 extra = default(Vector3)){
		headTransform.rotation = Quaternion.RotateTowards(headTransform.rotation, Quaternion.FromToRotation (headTransform.position, t.position + extra), 360);
		yield return new WaitForSeconds (5);
	}
}
