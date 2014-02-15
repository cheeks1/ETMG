using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	private Vector3 mDir;


	// Use this for initialization
	void Start () {
	
		mDir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;

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
}
