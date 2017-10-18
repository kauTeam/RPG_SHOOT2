using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_GameControll : MonoBehaviour {

    public GameObject player;
    public GameObject Bullet;
    public GameObject win;
    public GameObject lose;
    public int Bullet_count;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            lose.SetActive(true);
        }
        if(Bullet == null && Bullet_count == 20)
        {
            win.SetActive(true);
        }
    }
}
