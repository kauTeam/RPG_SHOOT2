using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use_skill : MonoBehaviour {


    public GameObject wind_attack;
    public GameObject carrot_attack;
    public GameObject sheep_attack;
    public GameObject dog_attack;
    public GameObject monkey_shield;
    public GameObject monkey_attack;
    float jump = 1f;
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
                Invoke("character0_attack", 0.2f);
                Invoke("character0_attack", 0.4f);
                //스킬구현
                break;
            case 1:
                Instantiate(carrot_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);   
                    //스킬구현
                break;
            case 2:
                Instantiate(sheep_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
                Instantiate(sheep_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos1").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
                Instantiate(sheep_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos2").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
                Instantiate(sheep_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos3").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
                Instantiate(sheep_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos4").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
                //스킬구현
                break;
            case 3:
                for(float i = 1f; i>= -1; i -= 0.1f)
                {
                    
                }
                    //스킬구현
                break;
            case 4:
                //스킬구현
                Instantiate(monkey_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos1").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos1").gameObject.transform.rotation);
                break;
            case 5://스킬 구현된뒤 그위치 고정시켜야함  Instantiate로 구현해야함
                Instantiate(dog_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos1").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos1").gameObject.transform.rotation);
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
                this.gameObject.transform.Find("2").gameObject.transform.Find("wool_shield").gameObject.SetActive(true);
                break;
            case 3:

                break;
            case 4:
                Instantiate(monkey_shield, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("alter_ego1").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("alter_ego1").gameObject.transform.rotation);
                Instantiate(monkey_shield, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("alter_ego2").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("alter_ego2").gameObject.transform.rotation);
                Instantiate(monkey_shield, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("alter_ego3").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("alter_ego3").gameObject.transform.rotation);
                break;
            case 5:
                this.gameObject.transform.Find("pyramid").gameObject.SetActive(true);
                break;
        }
    }

    void character0_attack()
    {
        GameObject wind1 = Instantiate(wind_attack, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.position, this.gameObject.transform.Find(character.ToString()).gameObject.transform.Find("shoot_pos").gameObject.transform.rotation);
        wind1.GetComponent<wind_attack>().setDamage(damage);
    }


}

