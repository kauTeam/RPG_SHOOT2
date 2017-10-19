using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class shop_money : MonoBehaviour {

    public Text money;
	// Use this for initialization
	void Start () {
        money = money.GetComponent<Text>();
		
	}

    void Awake()
    {
        money = money.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
        money.text = PlayerPrefs.GetInt("money").ToString();
	}
}
