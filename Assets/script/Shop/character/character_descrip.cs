using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class character_descrip : MonoBehaviour {



	public Sprite[] Attack_sk_img = new Sprite[5];
	public Sprite[] Defence_sk_img = new Sprite[5];
	public Text skill_descrip;
	public Text main_descrip;
    public Text buy;
	public GameObject skill_img;
	public bool attack=true;
	int character_num=0;
    int[] characters_state = new int[6];
    string[] data_arr;
    int[] character_have;


    // Use this for initialization
    void Start () {
		main_descrip = main_descrip.GetComponent<Text> ();
		skill_descrip = skill_descrip.GetComponent<Text> ();
        buy = buy.GetComponent<Text>();

        for(int i=0;i<6;i++)
        {
            characters_state[i] = 0;
        }
        for(int i=0;i<(PlayerPrefs.GetInt("stage")/100);i++)
        {
            characters_state[i] = 1;
        }

        data_arr = PlayerPrefs.GetString("character_have").Split(',');
        character_have = new int[data_arr.Length];
        for (int i = 0; i < data_arr.Length; i++)
        {
            character_have[i] = System.Convert.ToInt32(data_arr[i]);
            characters_state[character_have[i]] = 2;
        }


    }

	void Awake()
	{
		main_descrip = main_descrip.GetComponent<Text>();
        skill_descrip = skill_descrip.GetComponent<Text>();
        buy = buy.GetComponent<Text>();

        for (int i = 0; i < 6; i++)
        {
            characters_state[i] = 0;
        }
        for (int i = 0; i < (PlayerPrefs.GetInt("stage") / 100); i++)
        {
            characters_state[i] = 1;
        }

        data_arr = PlayerPrefs.GetString("character_have").Split(',');
        character_have = new int[data_arr.Length];
        for (int i = 0; i < data_arr.Length; i++)
        {
            character_have[i] = System.Convert.ToInt32(data_arr[i]);
            characters_state[character_have[i]] = 2;
        }

    }
	// Update is called once per frame
	void Update () {
		int character = PlayerPrefs.GetInt("now_character");

		switch(character_num)
		{
		case 0:
			main_descrip.text="모험을 떠나는 주인공: 게임을 시작하지...";
			if (attack) {
				skill_img.GetComponent<Image> ().sprite = Attack_sk_img [character];
				skill_descrip.text = "강한 장풍을 연속해서 앞으로\n발사합니다";

			} else {
				skill_img.GetComponent<Image> ().sprite = Defence_sk_img [character];
				skill_descrip.text = "잠시동안 공격을 막아주는\n방어막을 두릅니다";
			}
			break;
		}

        switch(characters_state[character_num])
        {
            case 0:
                buy.text = "구매불가";
                break;
            case 1:
                buy.text = (character_num*200).ToString();
                break;
            case 2:
                buy.text = "소유중!";
                break;

        }

    }

	public void set_characterNum(int num)
	{
		character_num = num;
	}

    public void botton_buy()
    {
        if(characters_state[character_num]==1)
        {
            if((character_num * 200)<=PlayerPrefs.GetInt("money"))
            {
                int money = PlayerPrefs.GetInt("money");
                money -= (character_num * 200);
                PlayerPrefs.SetInt("money",money);
                characters_state[character_num] = 2;
                string temp = "";
                for (int i=0; i<6; i++)
                {
                    if(characters_state[i]==2)
                    {
                        temp = temp + "," + character_num;
                    }
                }
                PlayerPrefs.SetString("character_have", temp);
            }
        }
    }

}
