using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use_skill : MonoBehaviour {


    public GameObject wind_attack;
    public GameObject carrot_attack;
    int character;
    int damage;
    // Use this for initialization
	void Start () {
        character = PlayerPrefs.GetInt("now_character");
        damage = PlayerPrefs.GetInt("damage");
	}
    private void Awake()
    {
        character = PlayerPrefs.GetInt("now_character");
        damage = PlayerPrefs.GetInt("damage");
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void use_skill1()
    {
        //공격스킬
        switch(character)
        {
            case 0:
                GameObject wind1 = Instantiate(wind_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
                wind1.GetComponent<wind_attack>().setDamage(damage);
                Invoke("character0_attack",0.2f);
                Invoke("character0_attack", 0.4f);
                //스킬구현
                break;
            case 1:
                Instantiate(carrot_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);   
                    //스킬구현
                break;
            case 2:
                    //스킬구현
                break;
            case 3:
                    //스킬구현
                break;
            case 4:
                    //스킬구현
                break;
            case 5:
                break;
        }
    }

    //수비스킬
    public void use_skill2()
    {
        
        switch (character)
        {
            case 0:
                this.gameObject.transform.Find("0").gameObject.transform.Find("shield").gameObject.SetActive(true);
                break;
            case 1:
                this.gameObject.transform.Find("1").gameObject.GetComponent<Player_Status>().heal();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }

    void character0_attack()
    {
        GameObject wind1 = Instantiate(wind_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
        wind1.GetComponent<wind_attack>().setDamage(damage);
    }


}

