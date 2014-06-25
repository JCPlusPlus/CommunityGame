using UnityEngine;
using System.Collections;

public class MiniMapBackGround : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
		GameObject MiniMapCam = GameObject.Find ("MiniMapCamera");
		this.transform.position = new Vector2(MiniMapCam.transform.position.x, MiniMapCam.transform.position.y);
	}
}
