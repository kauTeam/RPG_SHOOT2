using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_num : MonoBehaviour {


	public GameObject character_object;
	public GameObject character_describe;
	int num=0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		character_object.GetComponent<Character_shop> ().setCharacter (num);
        character_describe.GetComponent<character_descrip>().set_characterNum(num);
	}
    public void left()
    {
        num -= 1;
        if(num<0)
        {
            num = 5;
        }
    }

    public void right()
    {
        num = (num + 1) % 6;
    }
}
