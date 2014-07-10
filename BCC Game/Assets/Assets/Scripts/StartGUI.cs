using UnityEngine;
using System.Collections;

public class StartGUI : MonoBehaviour {

	//set the size of the GUI window
	public Rect windowSize;
	//vars for window size
	public int width;
	public int height;

	public string LevelToLoad;

	public int buttonHeight;
	public int buttonWidth;



	public GUISkin gSkin;
	// Use this for initialization
	void Start () {


	}
	


	//gui window
	private void OnGUI()
	{
		GUI.skin = gSkin;


		//Button to Start the Game

		GUILayout.BeginArea(new Rect(10,100,100,90));

		GUILayout.BeginHorizontal();

		//GUILayout.Label ("hi");

		if(GUILayout.Button("Start Game"))
		{
			Application.LoadLevel("Library");
		}

		GUILayout.EndHorizontal();

		GUILayout.EndArea();



		//Button to Exit the Game
		GUILayout.BeginArea(new Rect(10,200,100,90)); //lower it 100 units
		
		GUILayout.BeginHorizontal();

		if(GUILayout.Button("Exit"))
		{
			Application.Quit();
		}
		
		GUILayout.EndHorizontal();
		
		GUILayout.EndArea();


	}

/*	void DoMyWindow(int windowID)
	{
		if(GUI.Button(new Rect(5,5,50,50),"Play"))
		{
			Application.LoadLevel("Library");
		}

	}*/

}
