using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use_skill : MonoBehaviour {


    public int[] mp1 = new int[6];
    public int[] mp2 = new int[6];

    int character;
	
    // Use this for initialization
	void Start () {
        character = PlayerPrefs.GetInt("now_character");
	}
    private void Awake()
    {
        character = PlayerPrefs.GetInt("now_character");
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void use_skill1()
    {
        switch(character)
        {
            case 0:
                if(this.transform.Find("0").gameObject.GetComponent<Player_Status>().get_Now_MP()>= mp1[character])
                {
                    //스킬구현
                    this.transform.Find("0").gameObject.GetComponent<Player_Status>().use_mp(mp1[character]);
                }
                break;
            case 1:
                if (this.transform.Find("1").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp1[character])
                {
                    //스킬구현
                    this.transform.Find("1").gameObject.GetComponent<Player_Status>().use_mp(mp1[character]);
                }
                break;
            case 2:
                if (this.transform.Find("2").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp1[character])
                {
                    //스킬구현
                    this.transform.Find("2").gameObject.GetComponent<Player_Status>().use_mp(mp1[character]);
                }
                break;
            case 3:
                if (this.transform.Find("3").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp1[character])
                {
                    //스킬구현
                    this.transform.Find("3").gameObject.GetComponent<Player_Status>().use_mp(mp1[character]);
                }
                break;
            case 4:
                if (this.transform.Find("4").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp1[character])
                {
                    //스킬구현
                    this.transform.Find("4").gameObject.GetComponent<Player_Status>().use_mp(mp1[character]);
                }
                break;
            case 5:
                if (this.transform.Find("5").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp1[character])
                {
                    //스킬구현
                    this.transform.Find("5").gameObject.GetComponent<Player_Status>().use_mp(mp1[character]);
                }
                break;
        }
    }

    public void use_skill2()
    {
        print(this.transform.Find("0").gameObject.GetComponent<Player_Status>().get_Now_MP());

        switch (character)
        {
            case 0:
                if (this.transform.Find("0").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp2[character])
                {
                    //스킬구현
                    this.transform.Find("0").gameObject.GetComponent<Player_Status>().use_mp(mp2[character]);
                }
                break;
            case 1:
                if (this.transform.Find("1").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp2[character])
                {
                    //스킬구현
                    this.transform.Find("1").gameObject.GetComponent<Player_Status>().use_mp(mp2[character]);
                }
                break;
            case 2:
                if (this.transform.Find("2").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp2[character])
                {
                    //스킬구현
                    this.transform.Find("2").gameObject.GetComponent<Player_Status>().use_mp(mp2[character]);
                }
                break;
            case 3:
                if (this.transform.Find("3").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp2[character])
                {
                    //스킬구현
                    this.transform.Find("3").gameObject.GetComponent<Player_Status>().use_mp(mp2[character]);
                }
                break;
            case 4:
                if (this.transform.Find("4").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp2[character])
                {
                    //스킬구현
                    this.transform.Find("4").gameObject.GetComponent<Player_Status>().use_mp(mp2[character]);
                }
                break;
            case 5:
                if (this.transform.Find("5").gameObject.GetComponent<Player_Status>().get_Now_MP() >= mp2[character])
                {
                    //스킬구현
                    this.transform.Find("5").gameObject.GetComponent<Player_Status>().use_mp(mp2[character]);
                }
                break;
        }
    }
}
