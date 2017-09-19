using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_HP_Bar : MonoBehaviour {

	public GameObject user;
	float max_Health;
	float cur_Health = 0f;
	public GameObject user_HPBar;
	// Use this for initialization 
	void Start()
	{
		max_Health = user.gameObject.GetComponent<Player_Status>().get_Max_HP();
		cur_Health = max_Health;
	}

	// Update is called once per frame
	void Update()
	{
		decreseHealth();
	}

	public void decreseHealth()
	{
		if (user != null) {
			cur_Health = user.gameObject.GetComponent<Player_Status> ().get_Now_HP ();
		}
		if (user == null) {
			cur_Health = 0;
		}
		//cur_Health -= 2f;
		float calc_Health = cur_Health / max_Health;
		SetHealthBar(calc_Health);
	}

	public void SetHealthBar(float myHealth)
	{
		user_HPBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), user_HPBar.transform.localScale.y, user_HPBar.transform.localScale.z);
	}
}

