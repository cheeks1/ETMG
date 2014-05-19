using UnityEngine;
using System.Collections;

public class IntroScreen : MonoBehaviour {

	void OnGUI () {
		
		
		GUIStyle style = new GUIStyle();
		style.fontSize = 150;
		style.alignment = TextAnchor.UpperCenter;
		
		Rect box = new Rect (40, 10, Screen.width - 40 , Screen.height - 20);
		GUI.Box ((box), "UIcontollers\nBy Tim Cheek\n05\\19\\2014", style);
		
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
