using UnityEngine;
using System.Collections;

public class Gui_Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{


		GUI.Box (new Rect (Screen.width/2-50, Screen.height/2-50, 250, 250),"Loader Menu");

		if(GUI.Button(new Rect (Screen.width/2, Screen.height/2+20,50,50), "Start Game"))
		{

			Application.LoadLevel ("Level");
			
		}
	}
}
