using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SKill_cool_down : MonoBehaviour {

    public List<Skill> skills;
    public GameObject player;
    public float[] sk1_cool = new float[6];
    public float[] sk2_cool = new float[6];
    float[] sk1_now_cool = new float[6];
    float[] sk2_now_cool = new float[6];

    public int[] deffence_mana = new int[6];
    public int[] attack_mana = new int[6];
    int now_character;

    void Start()
    {
        now_character = PlayerPrefs.GetInt("now_character");
        for(int i=0;i<6;i++)
        {
           sk1_now_cool[i]=sk1_cool[i]+1;
           sk2_now_cool[i] = sk2_cool[i] + 1;
        }
        
    }
    private void Awake()
    {
        now_character = PlayerPrefs.GetInt("now_character");
        for (int i = 0; i < 6; i++)
        {
            sk1_now_cool[i] = sk1_cool[i] + 1;
            sk2_now_cool[i] = sk2_cool[i] + 1;
        }


    }
    // Update is called once per frame
    public void skill1()
    {
        if (player.transform.Find(now_character.ToString()).gameObject.GetComponent<Player_Status>().get_Now_MP() >= attack_mana[now_character])
        {
            if (sk1_now_cool[now_character] >= sk1_cool[now_character])
            {
                player.gameObject.GetComponent<use_skill>().use_skill1();
                player.transform.Find(now_character.ToString()).gameObject.GetComponent<Player_Status>().use_mp(attack_mana[now_character]);
                sk1_now_cool[now_character] = 0;
            }
        }
    }
    public void skill2()
    {
        if (player.transform.Find(now_character.ToString()).gameObject.GetComponent<Player_Status>().get_Now_MP() >= deffence_mana[now_character])
        {
            if (sk2_now_cool[now_character] >= sk2_cool[now_character])
            {
                player.gameObject.GetComponent<use_skill>().use_skill2();
                player.transform.Find(now_character.ToString()).gameObject.GetComponent<Player_Status>().use_mp(deffence_mana[now_character]);
                sk2_now_cool[now_character] = 0;
            }
        }
    }
    private void Update()
    {
        if (sk1_now_cool[now_character] < sk1_cool[now_character])
        {
            sk1_now_cool[now_character] += Time.deltaTime;
            skills[0].skillIcon.fillAmount = sk1_now_cool[now_character] / sk1_cool[now_character];
        }
        if (sk2_now_cool[now_character] < sk2_cool[now_character])
        {
            sk2_now_cool[now_character] += Time.deltaTime;
            skills[1].skillIcon.fillAmount = sk2_now_cool[now_character] / sk2_cool[now_character];
        }

    }
}

[System.Serializable]
public class Skill
{
    public Image skillIcon;
}