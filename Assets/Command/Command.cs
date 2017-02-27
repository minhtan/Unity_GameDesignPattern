using UnityEngine;
using System.Collections;

public abstract class Command {
	public abstract void Execute ();
}

public class MoveCommand : Command{
	public override void Execute ()
	{
		Debug.Log ("move");
	}
}

public class FireCommand : Command{
	public override void Execute ()
	{
		Debug.Log ("fire");
	}
}
