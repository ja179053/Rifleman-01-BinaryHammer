using UnityEngine;
using System.Collections;

public static class RigidDestroy {
	public static IEnumerator WaitAndDestroy(this Rigidbody r, float waitTime){
		if (r.isKinematic) {
			Rigidbody.Destroy (r);
		}
		yield return new WaitForSeconds (waitTime);
		Rigidbody.Destroy (r);
	}
}
