using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Player : MonoBehaviour {


	// Use this for initialization
	void Start () {
		int now_character = PlayerPrefs.GetInt ("now_character");
        this.gameObject.transform.Find(now_character.ToString()).gameObject.SetActive(true);



    }
    void Awake()
    {
        int now_character = PlayerPrefs.GetInt("now_character");
        this.gameObject.transform.Find(now_character.ToString()).gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
