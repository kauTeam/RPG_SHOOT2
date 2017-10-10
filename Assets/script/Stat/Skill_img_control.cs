using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_img_control : MonoBehaviour {


    public Sprite[] Attack_sk_img = new Sprite[5];
    public Sprite[] Defence_sk_img = new Sprite[5];
	public Text skill_descrip;

    public GameObject skill_img;
    public bool attack=true;

    // Use this for initialization
    void Start () {
		skill_descrip = skill_descrip.GetComponent<Text> ();
	}

	void Awake()
	{
		skill_descrip = skill_descrip.GetComponent<Text> ();

	}
	// Update is called once per frame
	void Update () {
        int character = PlayerPrefs.GetInt("now_character");

        if(attack)
        {
            skill_img.GetComponent<Image>().sprite = Attack_sk_img[character];
			skill_descrip.text="강한 장풍을 연속해서 앞으로\n발사합니다";

		}	
        else
        {
            skill_img.GetComponent<Image>().sprite = Defence_sk_img[character];
			skill_descrip.text="잠시동안 공격을 막아주는\n방어막을 두릅니다";
        }

		
	}
}
