using UnityEngine;
using System.Collections;

public abstract class Character : MonoBehaviour {
	protected NavMeshAgent nma;
	protected Transform target, lastTarget;
	public float sight = 5, strength = 10, health = 100;
	// Use this for initialization
	protected void Setup () {
		nma = GetComponent<NavMeshAgent> ();
	}
	public void Hurt(float damage){
		health -= damage;
		if (health < 0) {
			Die ();
		}
	}
	protected virtual void Die(){
		Destroy (gameObject);
	}
	protected void UpdateNMA(Vector3 extra = default(Vector3)){
		if (target != null) {
			nma.SetDestination (target.position + extra);
		}
	}
	protected void NewDestination(Vector3 dest){
		nma.SetDestination (dest);
	}
}
