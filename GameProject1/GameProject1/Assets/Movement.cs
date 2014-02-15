using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	BoxCollider thisOne;
	bool bDidTouch;

	// Use this for initialization
	void Start () {
	
		bDidTouch = false;
	}
	
	// Update is called once per frame
	void Update () {

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
