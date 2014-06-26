using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	//Variables




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		/*
		  isOrthoGraphic is to have it zoomed out
		  orthographicSize is to alter the camera view size
		*/

		this.camera.isOrthoGraphic = true;
		this.camera.orthographicSize = 12;

		/*
		  Make a reference to the player game object 	
          Make the position relative to the player position with the Z depth of -1
		*/
		GameObject playerObject = GameObject.Find("pikachu");
		this.transform.position = new Vector3(playerObject.transform.localPosition.x,playerObject.transform.localPosition.y,-1);



		/*GameObject playerObject = GameObject.Find ("Pikachu");
		PLScript tempPlayerScript = playerObject.GetComponent<PLScript>();

		camPositionX = tempPlayerScript.positionX;
		camPositionY = tempPlayerScript.positionY;

		transform.position = new Vector3(camPositionX,camPositionY, -30);*/
	}
}
