using UnityEngine;
using System.Collections;

public abstract class Quest : MonoBehaviour {
	public GameObject anything;
	protected Quest thisQuest;
	protected bool started;
	protected bool completed;
	public bool cantWalkDuringQuest = false;
	public bool CantWalkDuringQuest{
		get{
			PlayerMove.canMove = completed;
			return cantWalkDuringQuest;
		} set {
			cantWalkDuringQuest = value;
			PlayerMove.canMove = completed;
		}
	}
	public string helpMessage, completedMessage;

	protected virtual void CreateQuest(){
		started = true;
		Debug.Log ("fg");
	}
	protected virtual void EndQuest(){
		completed = true;
		Debug.Log("gf");
	}
	protected void DeleteQuest(){
		CantWalkDuringQuest = false;
		Messenger.NewMessage ("Quest Completed");
		if (anything != null) {
			anything.SetActive(!anything.activeSelf);
		}
		Destroy (thisQuest);
	}
}
