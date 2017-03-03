using UnityEngine;
using System.Collections;

public class ShootFireball : Mechanic {
	public GameObject fireball;
	public float waitTime = 5;
	static bool canFire = true;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (triggerKey) && canFire) {			
			StartCoroutine (ConjureFireball ());
		}
	}
	IEnumerator ConjureFireball(){
		canFire = false;
		Instantiate (fireball, transform.position, transform.rotation);
		yield return new WaitForSeconds (waitTime);
		canFire = true;
	}
}
