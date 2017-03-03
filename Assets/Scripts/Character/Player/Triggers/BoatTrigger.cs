using UnityEngine;
using System.Collections;

public class BoatTrigger : TriggerByPlayer {
	protected override void Action(Collider c){
		LevelManager.LoadLevel ("Map");
	}
}
