using UnityEngine;
using System.Collections;

public class WinMenu : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {

		
		GUIStyle style = new GUIStyle();
		style.fontSize = 300;
		style.alignment = TextAnchor.UpperCenter;

		Rect box = new Rect (10, 10, Screen.width - 20 , Screen.height - 20);
		GUI.Box ((box), "You Win", style);

		style.alignment = TextAnchor.MiddleCenter;
		style.fontSize = 100;

		//style.border = this.guiTexture.border;
		
		//style.border.left = 40;
		//style.border.top = 400;
		//style.border.bottom = Screen.height / 4 - 40;
		//style.border.right = Screen.width - 80;
		
		if (GUI.Button (new Rect (40, Screen.height/2 - 100, Screen.width - 80, Screen.height/4 - 40), "Main Menu", style)) 
		{
			
			Application.LoadLevel(1);
			
		}
	}
}
