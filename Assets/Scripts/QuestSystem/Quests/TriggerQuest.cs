using UnityEngine;
using System.Collections;

public class TriggerQuest : Quest {
	void OnEnable(){
		CreateQuest ();
	}
	void QuestProgress (object messenger, System.EventArgs e)
	{
	}
	
	protected override void CreateQuest ()
	{
		started = true;
		Debug.Log (helpMessage);
		Messenger.NewMessage (helpMessage);
		StartCoroutine(PlayerMove.LookAt(this.transform));
		QuestManager.AddQuestChecker (QuestsEnum.MoveOntoTrigger, QuestProgress);
	}
	
	protected override void EndQuest ()
	{
		completed = true;
		Messenger.NewMessage (completedMessage);
		QuestManager.QuestCompleted (QuestsEnum.MoveOntoTrigger, QuestProgress);
		thisQuest = gameObject.GetComponent<TriggerQuest> ();
		DeleteQuest ();
	}

	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag == "Player"){
			EndQuest();
		}
	}
}
