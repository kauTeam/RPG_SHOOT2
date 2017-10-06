using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_main : MonoBehaviour {

	int now_character;
	public GameObject[] characters=new GameObject[1];
	void Awake()
	{
		now_character = PlayerPrefs.GetInt ("now_character");
		for (int i = 0; i < characters.Length; i++) {
			characters [i].SetActive (false);
			if (i == now_character) {
				characters [i].SetActive (true);
					
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
