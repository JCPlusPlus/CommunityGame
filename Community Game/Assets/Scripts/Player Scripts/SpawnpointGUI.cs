using UnityEngine;
using System.Collections;

public class SpawnpointGUI : MonoBehaviour {
	

	//reference to player
	public GameObject playerObj;

	//hide GUI window message 
	private bool render = false;

	//window message size
	private Rect windowRect; 

	//texture for GUI message
	public GUITexture texture;

	//message for gui
	private string SpawnStairMessage;

	//middle of screen
	private int width;
	private int height;

	//boolean to hide and show window
	private bool isTouching;

	// Use this for initialization
	void Start () {
		//set variables to be in the middle of the screen
		width = Screen.width /2;
		height = Screen.height /2;

		//assign new values for windowRect GUI box
		windowRect = new Rect(width,height,200,120);

		//set the message that comes out for the GUI
		SpawnStairMessage = "You must collect your tools of destruction to face the Universal Professor";

		//set isTouching to false since Player is not touching the spawn point
		isTouching = false;


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//collision for when player interacts with the stair well
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.gameObject == playerObj)
		{
			ShowWindow ();//set render to true when player makes contact with the object
			isTouching = true; //set to true on first contact
		}

	}

	//collision when player is no longer touching the spawn point
	void OnCollisionExit2D(Collision2D hit)
	{
		if(hit.gameObject.gameObject == playerObj)
		{
			ShowWindow ();//set render to true when player makes contact with the object
			isTouching = false; //set to false as player stops touching
		}
	}

	//setting conditions for GUI message to pop out
	void OnGUI()
	{
		//if touching show message.
		//Gui.Window(ID, window size specifications, run following function, title of the window)
		if(render == true && isTouching == true)
		{
			windowRect = GUI.Window(1, windowRect,doMyWindow, "Schools in Session");
		}



	}

	//window message
	void doMyWindow(int windowID)
	{
		GUI.TextArea(new Rect(20,20,160,80), SpawnStairMessage);
		
	}

	//functions to toggle GUI on and off
	public void ShowWindow()
	{
		render = true;
	}
	public void HideWindow()
	{
		render = false;
	}
}
