using UnityEngine;
using System.Collections;

public abstract class TriggerByPlayer : Mechanic {
	static object triggerLock = new object();
	void OnTriggerStay(Collider c){
		if (Input.GetKeyDown (triggerKey)) {
			lock (triggerLock) {
				Action (c);
				ShowCommands.UpdateText ("", c.transform);
			}
		}
	}
	protected virtual void Action(Collider c){
		Debug.Log ("No action has been assigned to trigger" + this.gameObject + " with " + c.name);
	}
}
