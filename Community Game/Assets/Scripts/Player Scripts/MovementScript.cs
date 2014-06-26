using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	//Variables
	public float moveSpeed = 10f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Movement ();

	}
	
	
	
	void Movement()
	{
		if(Input.GetKey ("right"))
		{
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey ("left"))
		{
			transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey ("up"))
		{
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey ("down"))
		{
			transform.Translate(Vector2.up * -moveSpeed * Time.deltaTime);
		}
	}
	
	//Collisions
	
	/*
* Wall collision
*/
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag =="Wall")
		{
			Debug.Log("WORKING");
		}
	}

}