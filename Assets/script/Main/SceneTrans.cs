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
        int stage = PlayerPrefs.GetInt("stage");
        print(stage);
        int temp_stage1 = stage / 100;
        int temp_stage2 = stage % 100;
        print(temp_stage1);
        print(temp_stage2);
        print("scene/Stage/Stage"+ temp_stage1.ToString()+"/" + temp_stage2.ToString());
        SceneManager.LoadScene("scene/Stage/Stage"+ temp_stage1.ToString()+"/" + temp_stage2.ToString());
    }

    public void Trans_AR()
    {
        int count = PlayerPrefs.GetInt("ticket");
        if (count > 0)
        {
            count--;
            PlayerPrefs.SetInt("ticket",count);
            SceneManager.LoadScene("scene/AR");
        }
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
