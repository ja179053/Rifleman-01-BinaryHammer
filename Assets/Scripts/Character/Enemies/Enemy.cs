using UnityEngine;
using System.Collections;

public class Enemy : AI {
	void Start(){
		Setup ();
	}
	void Update(){
		UpdateNMA ();
		Behave ();
	}
	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Hoarde" || c.gameObject.tag == "Player") {
			Alert (c.transform);
		}
	}
}
