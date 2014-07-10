using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	//Variables
	public float moveSpeed = 1f;
	
	
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
			transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 4f * Time.deltaTime);
			transform.Translate(Vector3.up * Input.GetAxis("Vertical") * 4f * Time.deltaTime);
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