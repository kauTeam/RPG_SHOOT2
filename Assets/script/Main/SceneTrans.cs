using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTrans : MonoBehaviour {

	public void Trans_Main()
	{
		SceneManager.LoadScene ("scene/Main");
	}

    public void Trans_Dungun()
    {
        SceneManager.LoadScene("scene/Game_prototype");
    }

    public void Trans_AR()
    {
        SceneManager.LoadScene("scene/AR");
    }

    public void Trans_Shop()
    {
        SceneManager.LoadScene("scene/shop");
    }

    public void Trans_Stat()
    {
        SceneManager.LoadScene("scene/Stat");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
