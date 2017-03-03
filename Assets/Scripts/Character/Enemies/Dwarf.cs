using UnityEngine;
using System.Collections;

public class Dwarf : AI {
	//static Transform player;
	
	// Update is called once per frame
	void Start(){
		Setup ();
	}
	void Update () {
		UpdateNMA ();
		Behave ();
	}
	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Enemy") {
			Alert (c.transform);
		}
	}
}
