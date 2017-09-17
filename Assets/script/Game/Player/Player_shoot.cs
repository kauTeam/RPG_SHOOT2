using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shoot : MonoBehaviour {



	public GameObject bullet;
	public Transform pos;

	public int damage;
	public float speed;
	// Use this for initialization

	public void shoot()
	{
		GameObject tan= Instantiate (bullet, pos.position,pos.rotation);
		tan.GetComponent<Player_Bullet> ().setDamage (damage);
		tan.GetComponent<Player_Bullet> ().setSpeed (speed);
	}
}
