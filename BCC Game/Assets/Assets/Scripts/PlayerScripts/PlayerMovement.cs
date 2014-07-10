using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	void Update() 
	{
		Movement(); //Player Movement Function
	}

	//Get player movement
	void Movement()
	{
		if(Input.GetKey (KeyCode.D)) 
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.A)) 
		{
			transform.Translate(-Vector2.right * 4f * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(-Vector2.up * 4f * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector2.up * 4f * Time.deltaTime);
		}
	

	}
	

}
