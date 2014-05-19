using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	BoxCollider thisOne;
	bool bDidTouch;

	public int nType;
	/// ///////////
	private Vector3 mDir;
	private Vector3 mAccel;
	/// ///////////////

	// Use this for initialization
	void Start () {
	
		bDidTouch = false;

		mDir = Vector3.zero;
		mAccel = Vector3.zero;
		nType = 0;
	}

	void OnGUI()
	{
		//GUI.Box (new Rect (0, 30, 400, 30),"Accelerometer - X: " + mAccel.x + "; Y: " 
		         //+ mAccel.y);


		//////////
		/// Switch controll type
		/// /////
		if (nType == 0) 
		{
			if (GUI.Button (new Rect (0, 30, Screen.width/3, Screen.height / 7 - 40), "T-Slide")) 
			{
				nType = 1;
			}
		} 
		else 
		{
			if (GUI.Button (new Rect (0, 30, Screen.width/3, Screen.height / 7 - 40), "Accel")) 
			{	
				nType = 0;	
			}
		}
	}

	// Update is called once per frame
	void Update () {

		if(nType == 1)
		{
			/////////////////
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
			/////////////////
		}
		else
		{
			//Touch touch;
		Input.simulateMouseWithTouches = true;
		thisOne = GetComponent<BoxCollider> ();

		if (Input.GetMouseButtonDown(0) || bDidTouch)//GetButtonDown ("Fire1")) 
		{

			Vector3 pos = Vector3.zero;
			
			Vector3 mousePos = Vector3.zero;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			if(Physics.Raycast(ray))
				mousePos = ray.GetPoint(10);
			mousePos.z = transform.position.z;
			
			pos = mousePos;

			Vector3 PlayerPos = transform.position;
			
			//Debug.Log("Mouse Down:  " + pos.x + ", " + pos.y + ":  PlayerPos: " + PlayerPos.x + ", " + PlayerPos.y + "::  "+ thisOne.bounds.max + ";" + 
			          //thisOne.bounds.min);


						
			if (thisOne.bounds.max.x > pos.x && thisOne.bounds.min.x < pos.x) 
			{
								
								
				if (thisOne.bounds.max.y > pos.y && thisOne.bounds.min.y < pos.y) 
				{
										
										
					if (bDidTouch) 
					{
						
				pos.z = 0.0f;
				Vector3 newPos = Vector3.zero;
				newPos = pos - PlayerPos;

						gameObject.transform.Translate((newPos ));//* Time.deltaTime));
						
				bDidTouch = true;				
					} 
				/**/	else 
					{
						bDidTouch = true;
					}
								
				} 
				else 
				{
					bDidTouch = false;
				}
						
			} 
			else 
			{
				bDidTouch = false;	
			}/**/
		} 
		else
			bDidTouch = false;
		/**/
		}

	}
}
