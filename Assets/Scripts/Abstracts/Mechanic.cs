using UnityEngine;
using System.Collections;

public abstract class Mechanic : MonoBehaviour {
	public string triggerKey = "space";
/*	void Start(){
		Debug.Log (triggerKey + name);
	}*/
	void OnTriggerEnter(Collider c){
	//	Debug.Log (c.name);
		if (c.gameObject.tag == "Player"){
			Debug.Log ("Updating " + name);
			ShowCommands.UpdateText ("Press " + triggerKey, c.transform);
		}
	}
}
