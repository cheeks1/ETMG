using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	public void OnColissionEnter(Collision myCollision)
	{

		if (myCollision.gameObject.name == "Finish") 
		{
			Application.LoadLevel(2);
		}

		/*
		if (myCollision.gameObject.name == Enemy) 
		{
			Application.LoadLevel(3);
		}*/
	}

}
