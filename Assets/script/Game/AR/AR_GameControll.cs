using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AR_GameControll : MonoBehaviour {
    public Text text;
    public GameObject player;
    public GameObject Bullet;
    public GameObject win;
    public GameObject lose;
    public GameObject count;
    public bool IsBullet = true;
    bool check = true;
    // Use this for initialization
    void Start () {
        text = text.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

      
        for (int i=1; i<=20; i++)
        {
            if (GameObject.Find("AR_Bullet" + i.ToString()))
            {
                IsBullet = true;
                break;
            }
            else
            {
                IsBullet = false;
            }
        }



        if (player == null)
        {
            lose.SetActive(true);
        }
        if(IsBullet==false &&  count.GetComponent<Cube_Type>().Bullet_Count == 20)
        {
            if (check)
            {
                print("win");
                int money = 400 * Random.Range(1, 4);

                int temp = PlayerPrefs.GetInt("money");
                temp = money + temp;
                PlayerPrefs.SetInt("money", temp);
                text.text = money.ToString();
                check = false;
            }
            win.SetActive(true);
        }
    }
}
