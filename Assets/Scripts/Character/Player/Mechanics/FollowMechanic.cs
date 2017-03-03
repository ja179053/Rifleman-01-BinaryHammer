using UnityEngine;
using System.Collections;

public class FollowMechanic : Mechanic {
	public Transform targetToSet;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (triggerKey)) {
			SetFollow (targetToSet);
		}
	}
	protected virtual void SetFollow(Transform t){
		BroadcastMessage ("Follow", t);
	}
}
