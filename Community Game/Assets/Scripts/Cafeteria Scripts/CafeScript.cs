using UnityEngine;

using System.Collections;

public class CafeScript : MonoBehaviour {
	
	//references to the food spawn locations
	private Vector2 YPositionSpawn;
	
	
	private Vector2 ShootDown;
	
	//reference to rigidbody2d
	public Rigidbody2D projectile;
	public Rigidbody2D clone;
	
	
	
	
	//fire rate
	private float fireRate = 5.0f;
	private float nextFire = 1.0f;
	
	//destroy object time
	private float Wait = 2;
	
	//boolean for destroy clone
	public FoodCollision FCol;
	
	
	void Start()
	{
		//set shootdown vector 2 
		ShootDown = new Vector2(0,-1);
		
		//spawn position of the food projectiles
		YPositionSpawn = transform.position + new Vector3(0,-1,0);
		
		//reference the boolean in food collision
		FCol = GameObject.FindGameObjectWithTag("Player").GetComponent<FoodCollision>();
	}
	
	// Update is called once per frame
	void Update () {
		Food (); //run this shit
		
	}
	
	
	
	//spawn and shoot food items
	void Food()
	{
		if(Time.time > nextFire)
		{
			
			clone = Instantiate(projectile,YPositionSpawn , transform.rotation) as Rigidbody2D;
			clone.velocity = new Vector2(0,-1) * 10;

			nextFire = Time.time + fireRate;//set the fire rate


			Destroy(clone.gameObject,Wait);//destroy itself after period of time
			
			
			
			
		}

	}
}

