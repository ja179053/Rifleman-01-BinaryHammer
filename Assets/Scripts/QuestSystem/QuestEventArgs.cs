using System.Collections.Generic;

public class QuestEventArgs<T0> : System.EventArgs {
	public T0 value0;
	public QuestEventArgs(T0 value0){
		this.value0 = value0;
	}
}
