using UnityEngine;
using System.Collections;

public class playerScripts : MonoBehaviour 
{

	//---------------------------------------//
	//--------------VARIABLES----------------//
	//---------------------------------------//
	
	
	// RELATED TO CONTROLS/MOVEMENT //
	public KeyCode moveLeft;
	public KeyCode moveRight;
	public KeyCode shoot;
	public float speed = 10; // Universal speed change, applies to all player movements
	
	
	// RELATED TO PROJECTILES //
	public Rigidbody2D pBullet; // Link for the player's bullets
	//public GameObject sineBullet;
	public float bulletSpeedP = 5; // Speed of player's fired bullets. Best speed dependant on screen height (distance from player to boss)
	public float rateOfFire = 0.45f; // Firing rate/cooldown of player's bullets in seconds
	private float rateOfFirePointer; // Required internally for cooldown, DON'T TOUCH
	public bool doubleShot = false;
	//public bool sineShot = false;
	public float damage = 1;

	
	
	// RELATED TO HEALTH/LIVES //
	public float healthMax = 100; // How much damage the player can take before losing the game / losing a life
	public float health = 100; // How much health the player starts with / currently has
	public int lives = 0; // How many lives the player has, player loses when they die with 0 lives. For a non-lives based system, keep this at 0.
	
	public float shield = 1; // Shield's maximum HP
	public float shieldHP = 1; // Shield's current HP
	public float shieldRecharge = 1; // How many points of shield are recharged
	public float shieldRechargeCooldown = 5; // How many seconds the shield takes to recharge
	private float shieldCooldownPointer; // Required internally for cooldown, DON'T TOUCH
	public bool shieldResetOnHit = false; //If true, shield cooldown resets when hit while it's recharging
	
	private float damageBtoP; // How much damage the player takes from the enemy's bullets
	private bossScripts bossScript;
	

	private float timer = 0.0f; //False timer, Time.time workaround
	
	
	//---------------------------------------//
	//--------------FUNCTIONS----------------//
	//---------------------------------------//
	
	
	public void Start() 
	{
		health = healthMax;
		rateOfFirePointer = 0.0f;
		shieldCooldownPointer = 0.0f;

		bossScript = GameObject.FindGameObjectWithTag("boss").GetComponent<bossScripts>();
		damageBtoP = bossScript.damage;

	}
	
	
	public void Update () 
	{
		timer += Time.deltaTime;

		if(Input.GetKey(moveLeft))
		{
			rigidbody2D.velocity = (new Vector3(speed * -1,0f,0f));
		}
		else if (Input.GetKey(moveRight))
		{
			rigidbody2D.velocity = (new Vector3(speed * 1,0f,0f));
		}
		else
		{
			rigidbody2D.velocity = (new Vector3(0f,0f,0f));
		}
		
		if (Input.GetKeyUp(moveLeft))
		{
			rigidbody2D.velocity = (new Vector3(0f,0f,0f));
		}
		
		if (Input.GetKeyUp(moveRight))
		{
			rigidbody2D.velocity = (new Vector3(0f,0f,0f));
		}
		
		if (Input.GetKey(shoot) && (timer > rateOfFirePointer)) // Checks that player has pressed 'fire' key and that the cooldown will allow the shot
		{
			StartCoroutine("playerShooting");
		}
		
		if ((timer > shieldCooldownPointer) && (shieldHP < shield)) // Recharges players shield, cooldown resets on successful charge or on hit
		{
			shieldHP += shieldRecharge;
			shieldCooldownPointer = timer + shieldRechargeCooldown;
		}
	}
	
	public void playerShooting() // Function called when holding/pressing shoot key
	{ 
		if (doubleShot == true) // Double shot
		{
			GameObject pBulletClone1 = Instantiate(pBullet,transform.position + new Vector3(-0.5f,1.25f,0f),transform.rotation) as GameObject;
			GameObject pBulletClone2 = Instantiate(pBullet,transform.position + new Vector3(0.5f,1.25f,0f),transform.rotation) as GameObject;
		}
		/*	if (sineShot == true)
		{
		public GameObject sineBulletClone = Instantiate(sineBullet,transform.position + new Vector3(0,1.25,0),transform.rotation) as GameObject;
		}
*/
		else // Single shot (Normal)
		{
			GameObject pBulletClone3 = Instantiate(pBullet,transform.position + new Vector3(0f,1.25f,0f),transform.rotation) as GameObject;
		}

		rateOfFirePointer = timer + rateOfFire; // Cooldown effect
	}
	
	
	public void OnCollisionEnter2D(Collision2D colInfo) // Function called when colliding with something, triggers once per collision
	{
		if (colInfo.collider.tag == "bullet") // Ignore collisions unless the object is a bullet
		{
			StartCoroutine("shieldF");
		}
	}
	
	
	public void shieldF() // Shield
	{
		if(shieldHP > 0)
		{
			shieldHP -= damageBtoP;
			
			if(shieldResetOnHit == true)
				shieldCooldownPointer = timer + shieldRechargeCooldown;
		}
		else
		{
			StartCoroutine("playerDamaged");
		}
		//Debug.Log("Shield registered");
	}
	
	
	public void playerDamaged() // Player damaged (shield broken through)
	{
		health -= damageBtoP;
		
		if(shieldResetOnHit == true)
			shieldCooldownPointer = Time.time + shieldRechargeCooldown;
		
		if ((health <= 0) && (lives <= 0))
			StartCoroutine("playerDeath");
		
		if ((health <= 0) && (lives > 0))
			StartCoroutine("player1UP");

		//Debug.Log ("Damage registered");
	}
	
	
	
	public void player1UP() // Function called when player dies but still has lives remaining
	{
		health = healthMax;
		lives -= 1;
		shieldHP = shield;
		shieldCooldownPointer = 0f;
		rateOfFirePointer = 0f;
	}
	
	
	
	public void playerDeath() // Function called when player dies with no lives remaining
	{
		
		
		
	}
}