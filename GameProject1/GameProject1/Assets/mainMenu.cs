using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {

		Rect box = new Rect (10, 10, 100, 90);
		GUI.Box (box, "Game Project 1");
	
		if (GUI.Button (new Rect (20, 40, 80, 20), "Start")) {
			
			Application.LoadLevel(1);
			
		}

		//mExit = GUI.Button (Rect (20, 70, 80, 20), "Exit");
	}

}
