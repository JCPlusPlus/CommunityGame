using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {

	public Texture2D WallTexture;

	// Use this for initialization
	void Start () {
		gameObject.renderer.material.mainTexture = WallTexture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
