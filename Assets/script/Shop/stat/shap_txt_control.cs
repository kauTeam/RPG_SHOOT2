using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class shap_txt_control : MonoBehaviour {

    public Text bullet_lv;
    public Text damage_lv;
    public Text max_mp_lv;
    public Text mp_re_lv;
    public Text max_hp_lv;

    public Text bullet_cost;
    public Text damage_cost;
    public Text max_mp_cost;
    public Text mp_re_cost;
    public Text max_hp_cost;



    // Use this for initialization
    void Start () {
        bullet_lv = bullet_lv.GetComponent<Text>();
        bullet_cost = bullet_cost.GetComponent<Text>();

        damage_lv = damage_lv.GetComponent<Text>();
        damage_cost = damage_cost.GetComponent<Text>();

        max_hp_lv = max_hp_lv.GetComponent<Text>();
        max_hp_cost = max_hp_cost.GetComponent<Text>();

        max_mp_lv = max_mp_lv.GetComponent<Text>();
        max_mp_cost = max_mp_cost.GetComponent<Text>();

        mp_re_lv = mp_re_lv.GetComponent<Text>();
        mp_re_cost = mp_re_cost.GetComponent<Text>();
  }
	
	// Update is called once per frame
	void Update () {
        int lv;
        lv = PlayerPrefs.GetInt("max_bullet_count");
        bullet_lv.text = "Max." + lv.ToString()+"->" + (lv + 5).ToString();
        bullet_cost.text = ((lv-5) * 400).ToString();

        lv = PlayerPrefs.GetInt("max_damage");
        damage_lv.text= "Max." + lv.ToString() + "->" + (lv + 5).ToString();
        damage_cost.text = (lv * 500).ToString();

        lv = PlayerPrefs.GetInt("max_hp");
        max_hp_lv.text = "Max." + lv.ToString() + "->" + (lv + 25).ToString();
        max_hp_cost.text = ((lv-25) * 200).ToString();

        lv = PlayerPrefs.GetInt("max_mp");
        max_mp_lv.text = "Max." + lv.ToString() + "->" + (lv + 25).ToString();
        max_mp_cost.text = ((lv-20) * 100).ToString();

        lv = PlayerPrefs.GetInt("max_mp_recover");
        mp_re_lv.text = "Max." + lv.ToString() + "->" + (lv + 5).ToString();
        mp_re_cost.text = (lv * 500).ToString();
    }
}
