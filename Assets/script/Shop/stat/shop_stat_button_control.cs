using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_stat_button_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void buy_max_hp()
    {
        int money = PlayerPrefs.GetInt("money");
        int lv = PlayerPrefs.GetInt("max_hp");
        if(money>= (lv - 25) * 200)
        {
            money -= (lv - 25) * 200;
            PlayerPrefs.SetInt("money",money);
            lv += 25;
            PlayerPrefs.SetInt("max_hp", lv);
        }
    }

    public void buy_bullet_count()
    {
        int money = PlayerPrefs.GetInt("money");
        int lv = PlayerPrefs.GetInt("max_bullet_count");
        if (money >= (lv - 5) * 400)
        {
            money -= (lv - 5) * 400;
            PlayerPrefs.SetInt("money", money);
            lv += 5;
            PlayerPrefs.SetInt("max_bullet_count", lv);
        }
    }


    public void buy_damage()
    {
        int money = PlayerPrefs.GetInt("money");
        int lv = PlayerPrefs.GetInt("max_damage");
        if (money >= (lv * 500))
        {
            money -= (lv * 500);
            PlayerPrefs.SetInt("money", money);
            lv += 5;
            PlayerPrefs.SetInt("max_damage", lv);
        }
    }

    public void buy_max_mp()
    {
        int money = PlayerPrefs.GetInt("money");
        int lv = PlayerPrefs.GetInt("max_mp");
        if (money >= (lv - 20) * 100)
        {
            money -= (lv - 20) * 100;
            PlayerPrefs.SetInt("money", money);
            lv += 25;
            PlayerPrefs.SetInt("max_mp", lv);
        }
    }

    public void buy_mp_recover()
    {
        int money = PlayerPrefs.GetInt("money");
        int lv = PlayerPrefs.GetInt("max_mp_recover");
        if (money >= (lv * 500))
        {
            money -= (lv * 500);
            PlayerPrefs.SetInt("money", money);
            lv += 5;
            PlayerPrefs.SetInt("max_mp_recover", lv);
        }
    }

}
