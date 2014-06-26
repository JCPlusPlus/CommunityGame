using UnityEngine;
using System.Collections;

public class PLScript : MonoBehaviour {
	//Variables
	public float moveSpeed = .025f;
	
	public Rigidbody2D playerR;

	private Vector2 Direction = new Vector2(0,0);
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		Movement ();


			



			
	}

	void FixedUpdate()
	{
		playerR.AddForce (Direction.normalized*Time.deltaTime * moveSpeed);
	}
	
	
	
	void Movement()
	{

		if(Input.GetKeyDown ("right"))
		{
			Direction = new Vector2(1,0);
		}

		if(Input.GetKey ("left"))
		{
			Direction = Vector2.right * -1;
		}

		if(Input.GetKey ("up"))
		{
			Direction = Vector2.up;
		}
		if(Input.GetKey ("down"))
		{
			Direction = Vector2.up * -1;
		}


		if(Input.GetKeyUp ("right"))
		{
			Direction = new Vector2(0,0);
		}
		
		if(Input.GetKeyUp ("left"))
		{
			Direction = new Vector2(0,0);
		}
		
		if(Input.GetKeyUp ("up"))
		{
			Direction = new Vector2(0,0);
		}
		if(Input.GetKeyUp ("down"))
		{
			Direction = new Vector2(0,0);
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