using System.Collections;
using System.Collections.Generic;

public delegate void EventAssigner(object messager, System.EventArgs e);

public static class QuestManager
{
	public static Dictionary<QuestsEnum, EventAssigner> eventDictionary = new Dictionary<QuestsEnum, EventAssigner>();

	public static void AddQuestChecker (QuestsEnum questName, EventAssigner checker){
		if (eventDictionary.ContainsKey(questName)){
			//REDO QUEST
			eventDictionary[questName] += checker;
		} else {
			//NEW QUEST
			eventDictionary.Add(questName, checker);
		}
	}

	public static void QuestCompleted(QuestsEnum questName, EventAssigner checker){
		eventDictionary [questName] -= checker;
	}
	public static void QuestAffect(QuestsEnum questName, object messager, System.EventArgs e){
		if (eventDictionary.ContainsKey (questName)) {
			//As effective as an interface, quest specific.
			eventDictionary[questName].Invoke(messager, e);
		}
	}
}
