using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class login_scene_control : MonoBehaviour {


    public GameObject email_panel;
    public GameObject password_panel;
    public GameObject login_panel;
    public GameObject enter_panel;
    public GameObject success_panel;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void close()
    {
        success_panel.SetActive(false);
        enter_panel.SetActive(false);
        email_panel.gameObject.SetActive(false);
        password_panel.gameObject.SetActive(false);
        login_panel.gameObject.SetActive(false);
    }
}
