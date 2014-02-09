using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {

		Rect box = new Rect (10, 10, Screen.width - 20 , Screen.height - 20);
		GUI.Box (box, "Game Project 1");
	
		if (GUI.Button (new Rect (40, 40, Screen.width - 80, Screen.height/4 - 40), "Start")) 
		{
			
			Application.LoadLevel(1);
			
		}

		if(GUI.Button (new Rect (40, Screen.height/4 + 40, Screen.width - 80, Screen.height/4 - 40), "Exit"))
		{
			Application.Quit();
		}
	}

}
