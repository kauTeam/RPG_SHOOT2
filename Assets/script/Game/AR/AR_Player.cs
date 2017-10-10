using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "AR_Enemy_Bullet")
        {
            Destroy(tan.gameObject);
        }
    }
}
