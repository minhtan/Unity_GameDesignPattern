using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

	Command key1;
	Command key2;

	// Use this for initialization
	void Start () {
		key1 = new MoveCommand ();
		key2 = new FireCommand ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.M)) {
			key1.Execute ();
		}
		if (Input.GetKeyDown(KeyCode.F)) {
			key2.Execute ();
		}
	}
}
