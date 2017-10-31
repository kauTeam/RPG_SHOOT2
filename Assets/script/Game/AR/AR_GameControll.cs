using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_GameControll : MonoBehaviour {

    public GameObject player;
    public GameObject Bullet;
    public GameObject win;
    public GameObject lose;
    public GameObject count;
    public bool IsBullet = true;
    // Use this for initialization
    void Start () {
        
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
            print("win");
            win.SetActive(true);
        }
    }
}
