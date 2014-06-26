using UnityEngine;
using System.Collections;
using System.Collections.Generic;




public class Invent : MonoBehaviour {

	//Private Varaibles for GUI
	private Rect windowRect = new Rect(0,600,600,100);
	private bool inBackPack;





	//array of gameobjects
	public GameObject[] Items;


	//to increment x position placement for icons
	public int holderNum;

	//counter to collecting all items
	public int Finished;

	//Variables for GUI icons
	public Texture[] TextBookIcon;//array to hold textures
	private int iconArraySize = 4;//amount of items in game


	public Texture2D SampleIcon01;//links to textures
	public Texture2D SampleIcon02;
	public Texture2D SampleIcon03;
	public Texture2D SampleIcon04;

	public GameObject currentObject;
	public GameObject TEXTBOOK;
	public GameObject PENCIL;
	public GameObject FLASH;
	public GameObject ENERGY;


	// Use this for initialization
	void Start () {
		//Initialize the Boolean Variables for Backpack icons
		inBackPack = false;

		//populate the array size
		Items = GameObject.FindGameObjectsWithTag("item");

		//populate the array size for textures
		TextBookIcon = new Texture2D[iconArraySize];

		//Start counter for items picked up at 0
		Finished = 0;




	}
	
	// Update is called once per frame
	void Update () 
	{

	}


	//Collision Detection
	void OnCollisionEnter2D(Collision2D hit)
	{

		foreach(GameObject textbook in Items)
		{


			if(hit.gameObject.gameObject == textbook)
				
			{	
				inBackPack = true;
				currentObject = textbook;
				DestroyObject (textbook);//destroy object

				Finished++;


			}


		}


	}

	//Gui
	void OnGUI()
	{
		foreach(GameObject textbook in Items)
		{
			windowRect = GUI.Window(0, windowRect,DoMyWindow,"Back Pack");
		}
	}
	//adding icons to the gui
	void DoMyWindow(int windowId)
	{


		if(inBackPack == true)
			{
			holderNum = 0;
				

				
			for(int i = 0; i < Finished;i++)
				{

				GUI.Button(new Rect (0+holderNum,0,150,64), TextBookIcon[i]);
				holderNum += 150;

				}

		}

	

	}


	
}
