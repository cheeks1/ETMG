using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	private Vector3 mDir;
	private Vector3 mAccel;

	// Use this for initialization
	void Start () {
	
		mDir = Vector3.zero;
		mAccel = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;
		mAccel.x = dir.x;
		mAccel.y = dir.y;

		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		dir *= Time.deltaTime;

		if (dir != mDir) 
		{
			mDir = dir;

			transform.Translate (dir);
		}
	
		Input.ResetInputAxes();

	}

	void OnGUI()
	{
		GUI.Box (new Rect (0, 30, 400, 30),"Accelerometer - X: " + mAccel.x + "; Y: " 
		         + mAccel.y);
	}
}
