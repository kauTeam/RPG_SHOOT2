using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class character_descrip : MonoBehaviour
{



    public Sprite[] Attack_sk_img = new Sprite[5];
    public Sprite[] Defence_sk_img = new Sprite[5];
    public Text skill_descrip;
    public Text main_descrip;
    public Text buy;
    public GameObject skill_img;
    public bool attack = true;
    int character_num = 0;
    int[] characters_state = new int[6];
    string[] data_arr;
    int[] character_have;


    // Use this for initialization
    void Start()
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
    void Update()
    {
        int character = PlayerPrefs.GetInt("now_character");

        switch (character_num)
        {
            case 0:
                main_descrip.text = "모험을 떠나는 주인공: 게임을 시작하지...";
                if (attack)
                {
                    skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
                    skill_descrip.text = "강한 장풍을 연속해서 앞으로\n발사합니다";

                }
                else
                {
                    skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
                    skill_descrip.text = "잠시동안 공격을 막아주는\n방어막을 두릅니다";
                }
                break;

            case 1:
                main_descrip.text = "모험을 즐기는 토끼!!: 인생은 한방이지!!!";
                if (attack)
                {
                    skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
                    skill_descrip.text = "거대한 당근을 꺼내서 앞으로\n던집니다";

                }
                else
                {
                    skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
                    skill_descrip.text = "체력을 회복시켜 줄 수 있는\n당근을 먹습니다";
                }
                break;


            case 2:
                main_descrip.text = "순하디 순한 양이랍니다: 얼마있냐???";
                if (attack)
                {
                    skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
                    skill_descrip.text = "친구들을 불러서 앞으로\n몸통박치기!!";

                }
                else
                {
                    skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
                    skill_descrip.text = "주변에 공격을 막아주는 폭신한\n양털 모피를 두릅니다";
                }
                break;


            case 3:
                main_descrip.text = "시원한 얼음과 탄산을 좋아해요: 꺼어어억~";
                if (attack)
                {
                    skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
                    skill_descrip.text = "육중한 몸을 이용한 점프로\n주변에 충격을 줍니다";

                }
                else
                {
                    skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
                    skill_descrip.text = "전방에 큰 소리를 질러서\n적의 탄환을 부십니다";
                }
                break;

            case 4:
                main_descrip.text = "삼장법사의 친구 오공!: A man...";
                if (attack)
                {
                    skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
                    skill_descrip.text = "여의봉을 거대화 하여 앞으로\n강하게 휘두릅니다";

                }
                else
                {
                    skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
                    skill_descrip.text = "소환한 분신이 앞으로 달려가\n적 탄환을 막습니다";
                }
                break;

            case 5:
                main_descrip.text = "사막의 저승사자 아누비스: 멍멍!";
                if (attack)
                {
                    skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
                    skill_descrip.text = "지속적인 피해를 주는 저승을\n잠시 소환합니다";

                }
                else
                {
                    skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
                    skill_descrip.text = "모든 탄환을 막는 피라미드를\n소환합니다";
                }
                break;
        }

        switch (characters_state[character_num])
        {
            case 0:
                buy.text = "구매불가";
                break;
            case 1:
                buy.text = (character_num * 200).ToString();
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
        if (characters_state[character_num] == 1)
        {
            if ((character_num * 200) <= PlayerPrefs.GetInt("money"))
            {
                int money = PlayerPrefs.GetInt("money");
                money -= (character_num * 200);
                PlayerPrefs.SetInt("money", money);
                characters_state[character_num] = 2;
                string temp = "";
                for (int i = 0; i < 6; i++)
                {
                    if (characters_state[i] == 2)
                    {
                        temp = temp + "," + character_num;
                    }
                }
                PlayerPrefs.SetString("character_have", temp);
            }
        }
    }

}
