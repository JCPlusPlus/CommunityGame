using UnityEngine;
using System.Collections;

public class CameraHide : MonoBehaviour {

	public Camera minicam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Pressing M will toggle the mini map camera
		if(Input.GetKeyDown("m") && minicam.camera.enabled == true)
		{
			minicam.camera.enabled = false;
		}
		else if(Input.GetKeyDown ("m") && minicam.camera.enabled == false)
		{
			minicam.camera.enabled = true;
		}
	}
}
