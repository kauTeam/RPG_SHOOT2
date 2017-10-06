using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Player : MonoBehaviour {

	public GameObject[] character = new GameObject[3];

	// Use this for initialization
	void Start () {
		int now_character = PlayerPrefs.GetInt ("now_character");
		for (int i = 0; i < character.Length; i++) {
			character [i].SetActive (false);
			if (i == now_character) {
				character [i].SetActive (true);
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
