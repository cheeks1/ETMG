using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	void OnCollisionEnter(Collision myCollision)
	{
		//Debug.Log("Hit Something");
		if (myCollision.gameObject.name == "Finish") 
		{
			Debug.Log("Hit Sphere");
			Application.LoadLevel(2);
		}

		/**/
		if (myCollision.gameObject.tag == "Enemy") 
		{
			Application.LoadLevel(3);
		}/**/
	}

}
