using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	CircleCollider2D thisOne;
	bool bDidTouch;

	// Use this for initialization
	void Start () {
	
		thisOne = this.GetComponent<CircleCollider2D> ();
		bDidTouch = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		thisOne = this.GetComponent<CircleCollider2D> ();
		Touch touch;

		/**
		if (Input.touchCount > 0) 
		{
			touch = Input.GetTouch (0);
		}
		else
		{
			bDidTouch = false;			
			return;
			
		}

		//touch.position.x > 
		if (thisOne.center.x + thisOne.radius > touch.position.x && thisOne.center.x - thisOne.radius < touch.position.x) 
		{
			if (thisOne.center.y + thisOne.radius > touch.position.y && thisOne.center.y - thisOne.radius < touch.position.y) 
			{
				if (bDidTouch) 
				{
					transform.position.Set(touch.position.x, touch.position.y, 0.0f);
					this.GetComponent<CircleCollider2D>().center = touch.position;
				} 
				else 
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
		}
		
		/**/

		bool IsDown = Input.GetMouseButtonDown (0);
		Vector3 pos = Input.mousePosition;

		if (IsDown == false) 
		{
			bDidTouch = false;
			return;
		}
		//touch.position.x > 
		if (thisOne.center.x + thisOne.radius > pos.x && thisOne.center.x - thisOne.radius < pos.x) 
		{
			if (thisOne.center.y + thisOne.radius > pos.y && thisOne.center.y - thisOne.radius < pos.y) 
			{
				if (bDidTouch) 
				{
					transform.position.Set(pos.x, pos.y, transform.position.z);
					this.GetComponent<CircleCollider2D>().center = new Vector2(pos.x, pos.y);
				} 
				else 
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
}
