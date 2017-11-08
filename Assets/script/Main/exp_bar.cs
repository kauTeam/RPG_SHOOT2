using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp_bar : MonoBehaviour {

    public GameObject bar;
    int lv;
    int exp;
	// Use this for initialization
	void Start () {
        lv = PlayerPrefs.GetInt("level");
        exp = PlayerPrefs.GetInt("exp");
	}
	
	// Update is called once per frame
	void Update () {
        lv = PlayerPrefs.GetInt("level");
        exp = PlayerPrefs.GetInt("exp");
        float temp = (float)exp / ((float)lv*40+(float)lv * (float)lv * 10);
        SetHealthBar(temp);
	}

    public void SetHealthBar(float myHealth)
    {
        bar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), bar.transform.localScale.y, bar.transform.localScale.z);
    }
}
