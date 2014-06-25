using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	//variables
	void Start()
	{
	
	}


	void Update()
	{
		GameObject playerObject = GameObject.Find("pikachu");
		this.transform.position = new Vector3(playerObject.transform.position.x,playerObject.transform.position.y,-2 );
	}
}
