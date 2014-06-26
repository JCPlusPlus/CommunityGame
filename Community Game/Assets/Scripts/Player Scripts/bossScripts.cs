using UnityEngine;
using System.Collections;

public class bossScripts : MonoBehaviour {


	public float bossHPMax = 100;
	public float bossHP = 100;
	public float damage = 1;
	public float speed = 7.5f;
	public float bulletSpeed;
	private float damagePtoB;
	private Transform playerPosition;
	private playerScripts playerScript;



	// Use this for initialization
	void Start () {

		if (bossHP != bossHPMax)
			bossHP = bossHPMax;

		playerPosition = GameObject.FindGameObjectWithTag ("player").transform;
		playerScript = GameObject.FindGameObjectWithTag ("player").GetComponent <playerScripts>();
		damagePtoB = playerScript.damage;
	}
	
	// Update is called once per frame
	void Update () {

		if (playerPosition.transform.position.x > this.transform.position.x)
			rigidbody2D.velocity = (new Vector3 (speed, 0f, 0f));

		if (playerPosition.transform.position.x < this.transform.position.x)
			rigidbody2D.velocity = (new Vector3 (speed * -1f, 0f, 0f));

	}

	public void OnCollisionEnter2D (Collision2D colInfo)
	{

		if (colInfo.collider.tag == "bullet")
			bossHP -= damagePtoB;

	}
}
