using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_shop : MonoBehaviour {

	int now_character=0;
	public GameObject[] characters=new GameObject[1];
	void Awake()
	{
		for (int i = 0; i < characters.Length; i++) {
			characters [i].SetActive (false);
			if (i == now_character) {
				characters [i].SetActive (true);

			}
		}
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < characters.Length; i++) {
			characters [i].SetActive (false);
			if (i == now_character) {
				characters [i].SetActive (true);

			}
		}
	}

	public void setCharacter(int character)
	{
		now_character = character;
	}
}
