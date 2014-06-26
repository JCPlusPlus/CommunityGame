using UnityEngine;
using System.Collections;

public class BossFightTP : MonoBehaviour {

	//reference to player game object
	public GameObject playerObj;

	//boolean to see if player has all objects
	private bool CollectedAll;

	//set the size of the GUI window
	private Rect windowRect;

	//make variables to store middle location of screen
	private int width;
	private int height;

	//toggable variable to show/hide GUI window
	private bool render = false;

	//variable to verify contact with this item
	private bool isTouching;

	//String for Incomplete Inventory
	private string CollectionIncomplete;
	private string CollectionComplete;


	public Invent inventory;


	// Use this for initialization
	void Start () {
		//initialize isTouching to false;
		isTouching = false;

		//initialize CollectedAll, set to false
		CollectedAll = false;

		//find the middle of screen
		width = Screen.width /2;
		height = Screen.height /2;

		//set GUI window to middle of screen
		windowRect = new Rect(width,height,400,200);

		//populate Strings
		CollectionIncomplete = "You must collect All Four items to unlock this passage";
		CollectionComplete = "Get ready to take the Test of your life!";

		//How to reference variables in other classes
		//
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Invent>();


	}
	
	// Update is called once per frame
	void Update () {
		if(inventory.Finished == 4)
		{
			CollectedAll = true;
		}
	}

	//collision detection for when player hits the exit
	void OnCollisionEnter2D(Collision2D hit)
	{
		//if the player hits this object without having collected all items
		if(hit.gameObject.gameObject == playerObj)
		{
			ShowWindow (); //set Render to true
			isTouching = true;
		}

	}

	//collision detectiong for when player is not touching 
	void OnCollisionExit2D(Collision2D hit)
	{
		//when thay players not touching this object anymore
		if(hit.gameObject.gameObject == playerObj)
		{
			HideWindow (); //set Render to true
			isTouching = false;
		}
	}

	//GUI message
	//Share the same window ID placement so that they cancel eachother
	void OnGUI()
	{
		//Not all items collected
		if(render == true && isTouching == true && CollectedAll == false)
		{
			windowRect = GUI.Window (1, windowRect, FinishCollecting, "You are not yet ready");
		}

		//All items collected
		else if(render == true && isTouching == true && CollectedAll == true)
		{
			windowRect = GUI.Window (1,windowRect, DoneCollecting, "Test Time Baby!");
		}
	}

	//message that shows when you dont have all items
	void FinishCollecting(int WindowID)
	{
		GUI.TextArea(new Rect(20,20,160,80), CollectionIncomplete);
	}

	//message that shows when you have all items
	void DoneCollecting(int WindowID)
	{
		GUI.TextArea (new Rect(20,20,160,80),CollectionComplete);

	}

	//functions to make window toggable
	public void ShowWindow()
	{
		render = true;
	}
	public void HideWindow()
	{
		render = false;
	}
}
