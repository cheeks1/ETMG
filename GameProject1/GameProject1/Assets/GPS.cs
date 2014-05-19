using UnityEngine;
using System.Collections;

public class GPS : MonoBehaviour {

	float fAlt;
	float fLong;
	float fLat;
	// Use this for initialization

	void Start () 
	{
		Input.location.Start ();
		Input.compass.enabled = true;

		fAlt = 0.0f;
		fLong = 0.0f;
		fLat = 0.0f;

	}
	
	// Update is called once per frame
	void Update () 
	{
		fAlt = Input.location.lastData.altitude;
		fLong = Input.location.lastData.longitude;
		fLat = Input.location.lastData.latitude;

		Vector3 col = new Vector3(fAlt, fLong, fLat);
		col.Normalize();

		this.GetComponent<GUITexture> ().color = new Color (col.x, col.y, col.z, 0.3f);


		//int mag = (int)Input.compass.magneticHeading;
		//Camera.main.fieldOfView = (float)mag;*/
	}

	void Stop()
	{
		Input.location.Stop();
		Input.compass.enabled = false;
	}

	void OnGUI()
	{
		//GUI.Box (new Rect (0, 0, 400, 30),"Alt: " + fAlt + "; Long: " 
		         //+ fLong + "; Lat: " + fLat);

		//int mag = (int)Input.compass.magneticHeading;
		//GUI.Box (new Rect (0, 90, 400, 30),"Magnetic heading: " + mag);
	}
	
}
