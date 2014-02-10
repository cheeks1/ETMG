using UnityEngine;
using System.Collections;

public class Game_UI : MonoBehaviour {

	void OnGUI () 
	{
		GUI.Box (new Rect (0, 0, 100, 80),"");
		
		if (GUI.Button (new Rect (0, 0, 100, 80), "Main Menu")) 
		{
			Application.LoadLevel(0);
		}
	}
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
