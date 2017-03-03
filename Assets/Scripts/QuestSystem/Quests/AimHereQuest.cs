using UnityEngine;
using System.Collections;

public class AimHereQuest : Quest {
	public float maxX,maxY, minX, minY, allowance;
	void OnEnable(){
		CreateQuest ();
	}
	void QuestProgress (object messenger, System.EventArgs e)
	{
	}

	protected override void CreateQuest ()
	{
		started = true;
		QuestManager.AddQuestChecker (QuestsEnum.LookAt, QuestProgress);
		if (CantWalkDuringQuest) {
			Debug.Log ("Walk is locked.");
		}
	}

	protected override void EndQuest ()
	{
		Debug.Log (completedMessage);
		Messenger.NewMessage (completedMessage);
		completed = true;
		QuestManager.QuestCompleted (QuestsEnum.LookAt, QuestProgress);
		thisQuest = gameObject.GetComponent<AimHereQuest> ();
		DeleteQuest ();
	}
	void LateUpdate(){
		bool x, y;
	//	Debug.Log (PlayerLook.y);
		y = CriteriaMatch (PlayerLook.y, minY, maxY);
		x = CriteriaMatch (PlayerLook.x, minX, maxX);
		if (x && y) {
			EndQuest ();
		} else {
			Messenger.NewMessage (helpMessage);
		}
	}
	bool CriteriaMatch(float value, float min, float max){
		if(((value >= (min - allowance)) || min == 0) && ((value <= (max + allowance)) || max == 0)){
			return true;
		}
		return false;
	}
}
