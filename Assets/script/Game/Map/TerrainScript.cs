using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "enemy_bullet")
		{
			Destroy(col.gameObject);
		}
		if (col.tag == "player_bullet") {
			Destroy (col.gameObject);
		}
	}
}
