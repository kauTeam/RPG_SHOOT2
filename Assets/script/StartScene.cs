using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScene : MonoBehaviour {


    public GameObject control;
    void Start()
    {
        Invoke("changeScene", 2);

    }

    void Awake()
    {
        Invoke("changeScene", 2);
    }

    void Update()
    {
    }
    void changeScene()
    {
        if(PlayerPrefs.GetString("id")==""||PlayerPrefs.GetString("password")=="")
        {
            Color _fadeColor = new Color(0f, 0f, 0f, 1f);
            AutoFade.LoadLevel("login", 1, 1, _fadeColor);
        }
        else
        {
            control.gameObject.GetComponent<login_join>().main_login();
        }
    }
}
