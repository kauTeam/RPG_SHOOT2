using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class character_button : MonoBehaviour {
	

	string[] data_arr;
	int[] characters;
	int now;

	void Awake()
	{
		data_arr=PlayerPrefs.GetString("character_have").Split(',');
		characters=new int[data_arr.Length];
		for (int i = 0; i < data_arr.Length; i++) {
			characters [i] = System.Convert.ToInt32 (data_arr[i]);
			if (characters [i] == PlayerPrefs.GetInt ("now_character")) {
				now = i;
			}
		}
	}
	// Use this for initialization
	void Start () {
		data_arr=PlayerPrefs.GetString("character_have").Split(',');
		characters=new int[data_arr.Length];
		for (int i = 0; i < data_arr.Length; i++) {
			characters [i] = System.Convert.ToInt32 (data_arr[i]);
			if (characters [i] == PlayerPrefs.GetInt ("now_character")) {
				now = i;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void left()
	{
		now=now-1;
		if (now < 0) {
			now=characters[characters.Length-1];
		}
		PlayerPrefs.SetInt ("now_character", characters [now]);
	}

	public void right()
	{
		now = (now + 1) % characters.Length;
		PlayerPrefs.SetInt ("now_character", characters [now]);
	}

}








