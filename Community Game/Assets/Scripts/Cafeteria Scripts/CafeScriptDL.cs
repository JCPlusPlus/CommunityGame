using UnityEngine;
using System.Collections;

public class CafeScriptDL : MonoBehaviour {

	//references to the food spawn locations
	private Vector2 PositionSpawn;
	
	
	private Vector2 ShootDown;
	
	//reference to rigidbody2d
	public Rigidbody2D projectile;
	
	//fire rate
	private float fireRate = 5.0f;
	private float nextFire = 1.0f;

	//destroy object time
	private float Wait = 2;
	
	void Start()
	{
		//set shootdown vector 2 
		ShootDown = new Vector2(-1,-1);
		
		
		PositionSpawn = transform.position + new Vector3(-1,-1,0);
	}
	
	
	
	
	// Update is called once per frame
	void Update () {
		Food ();
	}
	
	//spawn and shoot food items
	void Food()
	{
		if(Time.time > nextFire)
		{
			Rigidbody2D clone;
			clone = Instantiate(projectile,PositionSpawn , transform.rotation) as Rigidbody2D;
			clone.velocity = transform.TransformDirection(ShootDown * 10);
			nextFire = Time.time + fireRate;//set the fire rate
			Destroy (clone.gameObject, Wait); //destroy game object after certain time
		}
	}
}
