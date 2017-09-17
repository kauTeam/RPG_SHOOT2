using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Status : MonoBehaviour {


	public int Max_HP;
	public int Max_MP;
	int Now_HP;
	int Now_Mp;
	public int Mp_Recover;
	bool Mp_Cover_state=true;
	// Use this for initialization
	void Start () {
		Now_HP = Max_HP;
		Now_Mp = Max_MP;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Mp_Cover_state) {
			Invoke ("MP_Cover", 1f);
			Mp_Cover_state = false;
			Now_Mp += Mp_Recover;
			if (Now_Mp > Max_MP) {
				Now_Mp = Max_MP;
			}
			
		}
	}

	void MP_Cover()
	{
		Mp_Cover_state = true;
	}

	void OnTriggerEnter(Collider tan)
	{

		if (tan.tag == "enemy_bullet") {
			
			Now_HP -= tan.gameObject.GetComponent<Bullet> ().getDamage ();
			Destroy (tan.gameObject);
			print (Now_HP);
			if (Now_HP <= 0) {
				Destroy (this.gameObject);
			}
		}
	}

	public int get_Now_HP()
	{
		return Now_HP;
	}
	public int get_Max_HP()
	{
		return Max_HP;
	}
	public int get_Now_MP()
	{
		return Now_Mp;
	}
	public int get_Max_MP()
	{
		return Max_MP;
	}


}
