using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {

	private Vector3 mDir;

	// Use this for initialization
	void Start () {
	
		mDir = Vector3.zero;

		GameObject.Find ("Particle System").particleEmitter.enabled = false;

		GameObject.Find ("Particle System").particleEmitter.rndVelocity = mDir;

		GameObject.Find ("Particle System").particleEmitter.worldVelocity = mDir;
		
		GameObject.Find ("Particle System").particleEmitter.localVelocity = mDir;
	}
	
	// Update is called once per frame
	void Update () {
		//particleEmitter emit = GameObject.Find ("Particle System").particleEmitter.worldVelocity = ;

		Vector3 dir = Vector3.zero;
		dir.x = -Input.acceleration.y;
		dir.z = Input.acceleration.x;
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		dir *= Time.deltaTime;

		if (dir != mDir) 
		{
			GameObject.Find ("Particle System").particleEmitter.enabled = true;

			GameObject.Find ("Particle System").particleEmitter.worldVelocity = dir;
	
			GameObject.Find ("Particle System").particleEmitter.localVelocity = dir;

			GameObject.Find ("Particle System").particleEmitter.enabled = true;

			mDir = dir;
		}
	}
}
