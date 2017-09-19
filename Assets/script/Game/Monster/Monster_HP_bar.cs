using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_HP_bar : MonoBehaviour {

	public GameObject monster;
	float max_Health;
	float cur_Health = 0f;
	public GameObject monster_HPBar;
	// Use this for initialization 
	void Start()
	{
		max_Health = monster.gameObject.GetComponent<Monster_Status>().get_Max_HP();
		cur_Health = max_Health;
	}

	// Update is called once per frame
	void Update()
	{
		decreseHealth();
	}

	public void decreseHealth()
	{
		if (monster != null) {
			cur_Health = monster.gameObject.GetComponent<Monster_Status> ().get_Now_HP ();
		}
		if (monster == null) {
			cur_Health = 0;
		}
		//cur_Health -= 2f;
		float calc_Health = cur_Health / max_Health;
		SetHealthBar(calc_Health);
	}

	public void SetHealthBar(float myHealth)
	{
		monster_HPBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), monster_HPBar.transform.localScale.y, monster_HPBar.transform.localScale.z);
	}
}
