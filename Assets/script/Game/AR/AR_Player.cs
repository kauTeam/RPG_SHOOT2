using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Player : MonoBehaviour {

    public float AR_Player_HP;
	// Use this for initialization
	void Start () {
        AR_Player_HP = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "AR_Enemy_Bullet")
        {
            Destroy(tan.gameObject);
            AR_Player_HP--;
            if(AR_Player_HP<=0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public float GET_AR_Player_HP()
    {
        return AR_Player_HP;
    }
}
