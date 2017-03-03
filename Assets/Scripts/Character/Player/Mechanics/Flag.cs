using UnityEngine;
using System.Collections;

public class Flag : TriggerByPlayer {
	public LayerMask ground;
	bool carryingFlag = false;
	
	// Update is called once per frame
	void Update () {
		//Throws the flag to a new location on mouse lift
		//SHOW AIMING WHILE MOUSE IS DOWN
		//PLAY SOUND EFFECT
		if (Input.GetMouseButtonUp (0) && carryingFlag) {
			transform.position = Vector3.up + RaycastData.RayPoint(Camera.main.ScreenPointToRay (Input.mousePosition), ground);
			SetParent (transform);
		}
	}

	protected override void Action(Collider c){
		//Picks up flag when close enough and the trigger key 'E' is pressed.
		//ERROR THIS DOES NOT OCCUR FOR ONLY ONE FRAME.
		Debug.Log ("Flag to " + c.transform + "THIS IS THE " + gameObject.name);
		SetParent (c.transform);
	}

	void SetParent(Transform t){
		carryingFlag = !carryingFlag;
		//PLAY APPROPRIATE SOUND EFFECT WHEN EITHER "REMOVING AND CARRYING" FLAG OR "THROWING" FLAG.
		//The conditional refers to whether carrying flag is true or not.
		//When false, carrying flag is set to true and they share the same parent.
		transform.parent = (t.parent == transform.parent) ? t.parent.parent : t.parent;
	}
}
