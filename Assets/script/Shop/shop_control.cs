using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_control : MonoBehaviour {


    public GameObject stat;
    public GameObject character;
	// Use this for initialization
	void Start () {
        stat.SetActive(true);
        character.SetActive(false);
		
	}

    void Awake()
    {
        stat.SetActive(true);
        character.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void stat_active()
    {
        stat.SetActive(true);
        character.SetActive(false);

    }

    public void character_active()
    {
        stat.SetActive(false);
        character.SetActive(true);

    }

}
