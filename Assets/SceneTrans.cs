using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrans : MonoBehaviour {

    public void Trans_Dungun()
    {
        Application.LoadLevel("Game_prototype");
    }

    public void Trans_AR()
    {
        Application.LoadLevel("AR");
    }

    public void Trans_Shop()
    {
        Application.LoadLevel("shop");
    }

    public void Trans_Stat()
    {
        Application.LoadLevel("Stat");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
