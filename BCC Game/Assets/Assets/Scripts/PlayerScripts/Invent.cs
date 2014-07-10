using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//gfdgfdagergstrbearsgreg


public class Invent : MonoBehaviour {

	//Private Varaibles for GUI
	public Rect windowRect; //570 width, 66 height,295 top
	private bool inBackPack;
	private float width; //for gui width
	private float height;//for gui height
	private float top;//for gui location


	//array of gameobjects
	public GameObject[] Items;


	//to increment x position placement for icons
	public float holderNum;

	//counter to collecting all items
	public int Finished;

	//Variables for GUI icons
	public Texture[] TextBookIcon;//array to hold textures
	private int iconArraySize = 4;//amount of items in game
	public int i;


	public GameObject currentObject;
	public GameObject TEXTBOOK;
	public static GameObject PENCIL;
	public GameObject FLASH;
	public GameObject ENERGY;

	public ItemIconScript TextureScript_01;
	public ItemIconScript TextureScript_02;
	public ItemIconScript TextureScript_03;
	public ItemIconScript TextureScript_04;


	//at the very start
	void Awake()
	{
		Debug.Log (this);
		DontDestroyOnLoad(this);
		Debug.Log (this);


	}

	void init()
	{
		TextureScript_01 = GameObject.FindGameObjectWithTag("textbook").GetComponent<ItemIconScript>();
		//TextureScript_02 = GameObject.FindGameObjectWithTag("pencil").GetComponent<ItemIconScript>();
		//TextureScript_03 = GameObject.FindGameObjectWithTag("flash").GetComponent<ItemIconScript>();
		//TextureScript_04 = GameObject.FindGameObjectWithTag("energy").GetComponent<ItemIconScript>();
		
		
		TEXTBOOK = GameObject.FindGameObjectWithTag("textbook");
		PENCIL = GameObject.FindGameObjectWithTag("pencil");
		FLASH = GameObject.FindGameObjectWithTag("flash");
		ENERGY = GameObject.FindGameObjectWithTag("energy");


	}
	// Use this for initialization
	void Start () {

		width = Screen.width; //width of gui window
		height = Screen.height/10;//height of gui window
		top = Screen.height - Screen.height/10;//location of gui window, at the bottom of screen

		windowRect = new Rect(0,top,width,height);//set the location of the gui window

		//Initialize the Boolean Variables for Backpack icons
		inBackPack = false;

		//populate the array size
		//Items = GameObject.FindGameObjectsWithTag("item");

		//populate the array size for textures
		TextBookIcon = new Texture2D[iconArraySize];

		//Start counter for items picked up at 0
		Finished = 0;


		init ();

	}
	
	// Update is called once per frame
	void Update () 
	{

	}


	//Collision Detection
	void OnCollisionEnter2D(Collision2D hit)
	{



			if(hit.gameObject.gameObject == TEXTBOOK)
				
			{	
				inBackPack = true;
				//currentObject = textbook;
				DestroyObject (TEXTBOOK);//destroy object

				Finished++;
				TextBookIcon[i] = TextureScript_01.TextureSkin;
		


			}
		if(hit.gameObject.gameObject == PENCIL)
			
		{	
			inBackPack = true;
			//currentObject = textbook;
			DestroyObject (PENCIL);//destroy object
			
			Finished++;
			TextBookIcon[i] = TextureScript_02.TextureSkin;
			
			
		}
		if(hit.gameObject.gameObject == FLASH)
			
		{	
			inBackPack = true;
			//currentObject = textbook;
			DestroyObject (FLASH);//destroy object
			
			Finished++;
			TextBookIcon[i] = TextureScript_03.TextureSkin;
			
			
		}
		if(hit.gameObject.gameObject == ENERGY)
			
		{	
			inBackPack = true;
			//currentObject = textbook;
			DestroyObject (ENERGY);//destroy object
			
			Finished++;
			TextBookIcon[i] = TextureScript_04.TextureSkin;
			
			
		}





	}

	//Gui
	void OnGUI()
	{
		//foreach(GameObject textbook in Items)
		for(int i = 0;i < Finished;i++)
		{
			windowRect = GUI.Window(0, windowRect,DoMyWindow,"Back Pack");
		}
	}
	//adding icons to the gui
	void DoMyWindow(int windowId)
	{


		//if(inBackPack == true)
			//{
			holderNum = 0;
				

				
			for(i = 0;i < Finished;i++)
			{

				GUI.Button(new Rect (0+holderNum,0,Screen.width/4,Screen.height/10),TextBookIcon[i]);
				holderNum += Screen.width/4;



			}
			
		//}

	

	}


	
}
