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
}
