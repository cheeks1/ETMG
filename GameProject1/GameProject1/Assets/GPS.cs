using UnityEngine;
using System.Collections;

public class GPS : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Input.location.Start ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float fAlt = Input.location.lastData.altitude;
		float fLong = Input.location.lastData.longitude;
		float fLat = Input.location.lastData.latitude;

		Vector3 col = new Vector3(fAlt, fLong, fLat);
		col.Normalize();

		this.GetComponent<GUITexture> ().color = new Color (col.x, col.y, col.z, 0.3f);
	}

	void Stop()
	{
		Input.location.Stop();
	}
}
