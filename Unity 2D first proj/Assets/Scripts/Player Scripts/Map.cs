using UnityEngine;
using System.Collections;

/*
 * Start the bool as false, make the player pick up the item and then allow minimap to be used
 */ 
public class Map : MonoBehaviour {

	public bool inBackpack;
	// Use this for initialization
	void Start () {
		inBackpack = false;
	}
	
	// Update is called once per frame
	void Update () {
		BackPack ();
	}

	public void SetTrue()
	{
		inBackpack = true;
	}
	public void BackPack()
	{
		if(inBackpack == true)
		{
			Debug.Log ("Item is in BackPack");
		}
	}
}
