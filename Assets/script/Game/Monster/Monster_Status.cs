using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Status : MonoBehaviour {


	public int Max_HP;
	int Now_HP;
	// Use this for initialization
	void Start () {
		Now_HP = Max_HP;
		
	}
	public float get_Now_HP()
	{
		return Now_HP;
	}
	public int get_Max_HP()
	{
		return Max_HP;
	}
	void OnTriggerEnter(Collider tan)
	{

		if (tan.tag == "player_bullet") {

			Now_HP -= tan.gameObject.GetComponent<Player_Bullet> ().getDamage ();
			Destroy (tan.gameObject);
			print (Now_HP);
			if (Now_HP <= 0) {
				Destroy (this.gameObject);
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
