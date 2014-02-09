using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {

		GUIStyle style = new GUIStyle();// = this.guiText;
		style.fontSize = 100;
		style.alignment = TextAnchor.UpperCenter;

		Rect box = new Rect (10, 10, Screen.width - 20 , Screen.height - 20);
		GUI.Box ((box), "Game Project 1", style);
	
		//GUI.TextField(new Rect(10, 10, Screen.width - 20 , Screen.height - 20), "Game Project 1");
		//Camera.current.rect

		style.alignment = TextAnchor.MiddleCenter;
		//style.border = this.guiTexture.border;

		//style.border.left = 40;
		//style.border.top = 400;
		//style.border.bottom = Screen.height / 4 - 40;
		//style.border.right = Screen.width - 80;

		if (GUI.Button (new Rect (40, 400, Screen.width - 80, Screen.height/4 - 40), "Start", style)) 
		{
			
			Application.LoadLevel(1);
			
		}

		if(GUI.Button (new Rect (40, Screen.height/4 + 400, Screen.width - 80, Screen.height/4 - 40), "Exit", style))
		{
			Application.Quit();
		}
	}

}
