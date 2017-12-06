
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
	public int gold;
	public int exp;
	public Text gold_text;
	public Text exp_text;
    bool check = true;
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
                if (check)
                {
                    int now_gold = PlayerPrefs.GetInt("money");
                    now_gold += gold;
                    PlayerPrefs.SetInt("money", now_gold);
                    gold_text.text = gold.ToString() + " GOLD";
                    exp_text.text = exp.ToString() + " EXP";
                    int save;
                    save = PlayerPrefs.GetInt("exp");
                    int lv = PlayerPrefs.GetInt("level");
                    save += exp;
                    if (save >= lv*40+lv * lv * 10)
                    {
                        save -= (lv * 40 + lv * lv * 10);
                        PlayerPrefs.SetInt("level", lv + 1);
                        PlayerPrefs.SetInt("exp", save);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("exp", save);
                    }
                    stage = PlayerPrefs.GetInt("stage");
                    stage++;
                    if(stage%100==10)
                    {
                        stage += 100;
                        stage -= 9;
                    }
                    PlayerPrefs.SetInt("stage", stage);
                    GameObject.Find("Main Camera").GetComponent<DB_control>().write();
                    win.SetActive(true);
                    check = false;
                }
			}
		}
	}
}
