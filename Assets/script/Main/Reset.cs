using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("bullet_count")) {
			PlayerPrefs.SetInt ("bullet_count", 10);
		}
		if (!PlayerPrefs.HasKey ("damage")) {
			PlayerPrefs.SetInt ("damage", 1);
		}
		if (!PlayerPrefs.HasKey ("hp")) {
			PlayerPrefs.SetInt ("hp", 30);
		}
		if (!PlayerPrefs.HasKey ("mp")) {
			PlayerPrefs.SetInt ("mp", 20);
		}
		if (!PlayerPrefs.HasKey ("mp_recover")) {
			PlayerPrefs.SetInt ("mp_recover", 1);
		}

		if (!PlayerPrefs.HasKey ("max_bullet_count")) {
			PlayerPrefs.SetInt ("max_bullet_count", 15);
		}
		if (!PlayerPrefs.HasKey ("max_damage")) {
			PlayerPrefs.SetInt ("max_damage", 5);
		}
		if (!PlayerPrefs.HasKey ("max_hp")) {
			PlayerPrefs.SetInt ("max_hp", 55);
		}
		if (!PlayerPrefs.HasKey ("max_mp")) {
			PlayerPrefs.SetInt ("max_mp", 45);
		}
		if (!PlayerPrefs.HasKey ("max_mp_recover")) {
			PlayerPrefs.SetInt ("max_mp_recover", 5);
		}

		if (!PlayerPrefs.HasKey ("useful_stat")) {
			PlayerPrefs.SetInt ("useful_stat", 1);
		}

		if (!PlayerPrefs.HasKey ("treasure")) {
			PlayerPrefs.SetString ("treasure", "");
		}

		if (!PlayerPrefs.HasKey ("stage")) {
			PlayerPrefs.SetInt ("stage", 101);
		}

		if (!PlayerPrefs.HasKey ("character_have")) {
			PlayerPrefs.SetString ("character_have", "0");
		}

		if (!PlayerPrefs.HasKey ("level")) {
			PlayerPrefs.SetInt ("level", 1);
		}

		if (!PlayerPrefs.HasKey ("exp")) {
			PlayerPrefs.SetInt ("exp", 0);
		}

		if (!PlayerPrefs.HasKey ("now_character")) {
			PlayerPrefs.SetInt ("now_character", 0);
		}

		if (!PlayerPrefs.HasKey ("money")) {
			PlayerPrefs.SetInt ("money", 0);
		}

	}

	public void reset()
	{
		PlayerPrefs.SetInt ("bullet_count", 10);
		PlayerPrefs.SetInt ("damage", 1);
		PlayerPrefs.SetInt ("hp", 30);
		PlayerPrefs.SetInt ("mp", 20);
		PlayerPrefs.SetInt ("mp_recover", 1);

		PlayerPrefs.SetInt ("max_bullet_count", 15);
		PlayerPrefs.SetInt ("max_damage", 5);
		PlayerPrefs.SetInt ("max_hp", 55);
		PlayerPrefs.SetInt ("max_mp", 45);
		PlayerPrefs.SetInt ("max_mp_recover", 5);

		PlayerPrefs.SetInt ("useful_stat", 30);

		PlayerPrefs.SetString ("treasure","");
		PlayerPrefs.SetInt ("stage", 101);
		PlayerPrefs.SetString ("character_have", "0,1,2");
		PlayerPrefs.SetInt ("level", 1);
		PlayerPrefs.SetInt ("exp", 0);
		
		PlayerPrefs.SetInt ("now_character", 0);
	
		PlayerPrefs.SetInt ("money", 20000);
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
