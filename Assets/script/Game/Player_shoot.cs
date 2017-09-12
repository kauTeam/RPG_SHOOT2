using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shoot : MonoBehaviour {



	public GameObject bullet;
	public Transform pos;
	// Use this for initialization

	public void shoot()
	{
		Instantiate (bullet, pos);
	}
}
