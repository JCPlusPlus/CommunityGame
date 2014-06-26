#pragma strict


function Update()
{
	//Destroy(gameObject, 5); // For testing, eliminates stray bullets that have bee on-screen for too long.
}


function OnCollisionEnter2D(colInfo : Collision2D) 
{
	if (colInfo.collider.tag != "bullet")
		Destroy(gameObject, 0.01);
}
