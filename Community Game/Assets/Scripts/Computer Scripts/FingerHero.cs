using UnityEngine;
using System.Collections;

public class FingerHero : MonoBehaviour {

	//booleans for left and right
	public bool left,right,up,down;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		//player input recognition
		buttonDown();
		buttonUp();

	}


	//set booleans based on player input
	void buttonDown()
	{

		if(Input.GetKey ("right"))
		{
			right = true;
		}
		if(Input.GetKey ("left"))
		{
			left = true;
		}
		if(Input.GetKey ("up"))
		{
			up = true;
		}
		if(Input.GetKey ("down"))
		{
			down = true;
		}

	}
	void buttonUp()
	{
		
		if(!Input.GetKey ("right"))
		{
			right = false;
		}
		if(!Input.GetKey ("left"))
		{
			left = false;
		}
		if(!Input.GetKey ("up"))
		{
			up = false;
		}
		if(!Input.GetKey ("down"))
		{
			down = false;
		}
		
	}

}
