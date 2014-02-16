using UnityEngine;
using System.Collections;

public class Game_UI : MonoBehaviour {

	void OnGUI () 
	{
		GUIStyle style = new GUIStyle();
		style.fontSize = 20;
		style.alignment = TextAnchor.UpperCenter;

		GUI.Box (new Rect (Screen.width - 100, Screen.height - 80, Screen.width - 40, Screen.height - 30),"");

		if (GUI.Button (new Rect (Screen.width - 100, Screen.height - 80, Screen.width - 40, Screen.height - 30), "Main Menu", style)) 
		{
			Application.LoadLevel(1);
		}
	}
	// Use this for initialization
	void Start () 
	{


	}
	
	// Update is called once per frame
	void Update () 
	{


	}
}
