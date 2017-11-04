using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use_skill : MonoBehaviour {


    
    int character;
	
    // Use this for initialization
	void Start () {
        character = PlayerPrefs.GetInt("now_character");
	}
    private void Awake()
    {
        character = PlayerPrefs.GetInt("now_character");
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void use_skill1()
    {
        switch(character)
        {
            case 0:
                    //스킬구현
                break;
            case 1:
                    //스킬구현
                break;
            case 2:
                    //스킬구현
                break;
            case 3:
                    //스킬구현
                break;
            case 4:
                    //스킬구현
                break;
            case 5:
                break;
        }
    }

    public void use_skill2()
    {
        
        switch (character)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}
