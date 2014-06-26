using UnityEngine;
using System.Collections;

public class ClassRoomScripts : MonoBehaviour {

	//window size
	public Rect windowRect = new Rect (50,300,300,100); //window size
	public string Riddle; //for the riddle
	public string Continue;//to click continue

	public float width;//positions
	public float height;//positions

	public GameObject Entrance;//reference to object attached to


	public bool isTouching;//register hitting object
	// Use this for initialization
	void Start () {

		//populate string for riddle
		Riddle = "One end creates while the other end destroys. I am simultaneously sharp and blunt. What am I?";
		Continue = "Find Me";

		//assign location for gui window
		width = Screen.width /2;
		height = Screen.height /2;


		//assign new values for windowRect GUI box
		windowRect = new Rect(width,height,180,200);

		//find game object to destroy
		Entrance = GameObject.FindGameObjectWithTag("ClassroomDoor");
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
			windowRect = GUI.Window (1, windowRect, DoMyWindow, "Quiz Time");
		}
	}

	void DoMyWindow(int windowID)
	{
		GUI.TextArea(new Rect(10,20,160,80),Riddle);
		if(GUI.Button (new Rect(10,100,160,80),Continue))
		{

			Destroy(Entrance);
			DestroyObject(this);

		}
	}
}
