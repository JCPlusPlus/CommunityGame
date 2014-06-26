using UnityEngine;
using System.Collections;

public class TryAgain : MonoBehaviour {

	//window size
	public Rect windowRect = new Rect (50,300,300,100); //window size

	private int width;
	private int height;

	private bool isTouching;

	private string Message;
	// Use this for initialization
	void Start () {
	
		//assign location for gui window
		width = Screen.width /2;
		height = Screen.height /2;
		
		
		//assign new values for windowRect GUI box
		windowRect = new Rect(width,height,160,50);

		//populate string
		Message = "Try Again...";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//collision detection
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			isTouching = true;
		}
	}
	void OnCollisionExit2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			isTouching = false;
		}
	}

	//for the window
	void OnGUI()
	{
		//only display message when the player is touching the door
		if(isTouching == true)
		{
			windowRect = GUI.Window (1, windowRect, DoMyWindow, "Oops!");
		}
	}

	void DoMyWindow(int windowID)
	{
		GUI.TextArea(new Rect(10,20,140,20),Message);

	}

}
