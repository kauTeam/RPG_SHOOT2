using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTrans : MonoBehaviour {

    int stage;
    int temp_stage1;
    int temp_stage2;
    int current;
    public Canvas entry;
    public Canvas Stage_Canvas;

    Color _fadeColor = new Color(0f, 0f, 0f, 1f);
    public void Trans_Main()
	{
        GameObject.Find("Main Camera").GetComponent<DB_control>().write();
        AutoFade.LoadLevel("Main", 1, 1, _fadeColor);
    }
    public void game_end()
    {
        Application.Quit();
    }
    
    public void Trans_AR()
    {
        int count = PlayerPrefs.GetInt("ticket");
        if (count > 0)
        {
            count--;
            PlayerPrefs.SetInt("ticket",count);
            GameObject.Find("Main Camera").GetComponent<DB_control>().write();
            AutoFade.LoadLevel("scene/AR", 1, 1, _fadeColor);
        }
    }

    public void Trans_Shop()
    {
        AutoFade.LoadLevel("scene/shop", 1, 1, _fadeColor);
    }

    public void Trans_Board()
    {
        int stage = PlayerPrefs.GetInt("stage");
        int temp_stage1 = stage / 100;
        int temp_stage2 = stage % 100;
        print(stage);
        print(temp_stage1);
        print("scene/Stage/Stage" + temp_stage1.ToString() + "/" + temp_stage2.ToString());
        PlayerPrefs.SetInt("cur_stage", temp_stage1);
        AutoFade.LoadLevel("scene/stage_board", 1, 1, _fadeColor);
    }
    public void Trans_Stat()
    {
        AutoFade.LoadLevel("scene/Stat", 1, 1, _fadeColor);  
    }
    public void Trans_Stage1()
    {
        if (current >=1)
        {
            GameObject.Find("Main Camera").GetComponent<StageButtonSet>().st(1);
            Stage_Canvas.gameObject.SetActive(true);
        }
        else entry.gameObject.SetActive(true);

    
	}
    public void test()
    {
        AutoFade.LoadLevel("scene/Stage/Stage1/1", 1, 1, _fadeColor);

    }
    public void Trans_Stage2()
    {
        if (current >=2)
        {
            GameObject.Find("Main Camera").GetComponent<StageButtonSet>().st(2);
            Stage_Canvas.gameObject.SetActive(true);
        }
        else entry.gameObject.SetActive(true);
    }
    public void Trans_Stage3()
    {
        if (current >=3)
        {
            GameObject.Find("Main Camera").GetComponent<StageButtonSet>().st(3);
            Stage_Canvas.gameObject.SetActive(true);
        }
        else entry.gameObject.SetActive(true);
    }
    public void Trans_Stage4()
    {
        if (current >=4)
        {
            GameObject.Find("Main Camera").GetComponent<StageButtonSet>().st(4);
            Stage_Canvas.gameObject.SetActive(true);
        }
        else entry.gameObject.SetActive(true);
    }
    public void Close_Stage()
    {
        Stage_Canvas.gameObject.SetActive(false);
    }

    public void log_out()
    {
        PlayerPrefs.SetString("id", "");
        PlayerPrefs.SetString("password", "");
        AutoFade.LoadLevel("login", 1, 1, _fadeColor);
    }

    public void Close_no_entry()
    {
        entry.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        current = PlayerPrefs.GetInt("cur_stage");
        print(current);
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
