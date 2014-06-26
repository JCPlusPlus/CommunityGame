using UnityEngine;
using System.Collections;

public class CafeDoor : MonoBehaviour {
	//variables

	//reference to the player script to turn on kinematics
	public GameObject Player;


	//reference to spawn point in cafeteria
	public GameObject CafeSpawn;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//collision with player
	void OnCollisionEnter2D(Collision2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			KinematicOn(); //turn on kinematic 
			Player.transform.position = CafeSpawn.transform.position;//teleport player to new position to start minigame
		}
	}

	//function to turn on kinematics on Rigidbody of player
	void KinematicOn()
	{
		Player.rigidbody2D.isKinematic = true;
	}
}

