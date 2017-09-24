
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game_control : MonoBehaviour {

	public GameObject player;
	public GameObject[] monster=new GameObject[1];
	public GameObject win;
	public GameObject lose;
	public int stage;
	public int level;
	public int gold;
	public int exp;
	public Text gold_text;
	public Text exp_text;


	// Use this for initialization
	void Start () {
		gold_text = gold_text.GetComponent<Text>();
		exp_text = exp_text.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null) {
			Time.timeScale = 0;
			lose.SetActive (true);
		}
		for (int i = 0; i < monster.Length; i++) {
			if (monster [i] != null) {
				break;
			}
			if (i == monster.Length - 1) {
				Time.timeScale = 0;

				win.SetActive (true);
				gold_text.text=gold.ToString()+" GOLD";
				exp_text.text=exp.ToString()+" EXP";
							
			}
			
		}

		
	}
}
