using UnityEngine;
using System.Collections;

public class AI : Character {
	public float attackCooldownTime = 1;
	public enum AIEnum {
		Attacking,
		Charging,
		Peaceful
	}
	protected void Behave(){
		switch (state) {
		case AIEnum.Peaceful:
			break;
		case AIEnum.Charging:
			Charge ();
			break;
		case AIEnum.Attacking:
			break;
		}
	}
	public void Follow(Transform t){
		target = (t == null) ? transform : t;
		//If the target is not in sight for ALL ai of a type, ai will follow the sound of the player.
		//The leader script will be assigned to the closest ai of a type. This will allow all enemies to follow the leader when sight is blocked.
		if (RaycastData.RaycastBlocked (transform.position, t.position)) {
			target = null;
			NewDestination(FindObjectOfType<PlayerMove> ().transform.position);
		}
	}
	IEnumerator Attack(){
		target.GetComponent<Character> ().Hurt (strength);
		yield return new WaitForSeconds (attackCooldownTime);
		state = AIEnum.Charging;
	}
	void Charge(){
		if (target == null) {
			state = AIEnum.Peaceful;
			target = lastTarget;
		}
		RaycastHit attackRange;
		if(Physics.Raycast(transform.position, transform.forward, out attackRange, sight)){
			if (attackRange.collider.transform == target) {
				state = AIEnum.Attacking;
				StartCoroutine (Attack ());
			}
		}
	}
	protected void Alert(Transform t){
		if (state != AIEnum.Charging) {
			state = AIEnum.Charging;
			lastTarget = target;
			target = t;
		}
	}
	public AIEnum state = AIEnum.Peaceful;
}
