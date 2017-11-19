using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("set_false", 2f);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="enemy_bullet")
        {
            Destroy(other.gameObject);
        }
    }

    void set_false()
    {
        this.gameObject.SetActive(false);
    }
}
