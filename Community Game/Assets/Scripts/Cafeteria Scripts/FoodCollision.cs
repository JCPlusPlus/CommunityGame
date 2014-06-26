using UnityEngine;
using System.Collections;

public class FoodCollision : MonoBehaviour {

	public bool objDestroy;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		DestroySelf();//run this shit
	}

	//SET TO TRUE WHEN HIT
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{

			objDestroy = true;


		}


	}

	//check yo self before you break yo self
	void DestroySelf()
	{
		if(objDestroy == true)
		{
			DestroyObject(this.gameObject);
		}
	}

}
