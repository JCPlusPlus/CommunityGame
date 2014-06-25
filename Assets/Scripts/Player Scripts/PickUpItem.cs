using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour {

	//Variables

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate()
	{

	}
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag =="item")
		{
			Debug.Log ("Contact Made");
		}
	}
	void OnCollisionStay2D(Collision2D col)
	{
		GameObject ItemPickedUp = GameObject.FindGameObjectWithTag("item");//For referencing picking up items

		GameObject MAP = GameObject.Find ("flower");//Replace with map later


		/*
		 * Detect objects with "item" tag and when they press Use button
		 * Destroy the Object and then run conditions to determine if item is in backpack
		 */
		if(col.gameObject.tag =="item" && Input.GetKeyDown ("e"))
		{
			DestroyObject(ItemPickedUp);
			Debug.Log("Working Nigga");

			//this is for the map
			if(ItemPickedUp = GameObject.Find ("flower"))
			{
				Map mapscript = MAP.GetComponent<Map>();
				mapscript.SetTrue();
				mapscript.BackPack();
				Debug.Log ("Flower Picked up");
			}
		}
	}


}
