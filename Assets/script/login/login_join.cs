using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login_join : MonoBehaviour {

    public GameObject password_panel;
    public GameObject email_panel;
    public GameObject enter_panel;


    [SerializeField]
    string email;
    [SerializeField]
    string password;
    [SerializeField]
    string password_confirm;

    public InputField inputTextEmail;
    public InputField inputTextPassword;
    public InputField inputTextPassword_confirm;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void join()
    {
        email = inputTextEmail.text;
        password = inputTextPassword.text;
        password_confirm = inputTextPassword_confirm.text;
        print("email"+email);
        print("password" + password);
        print("password_confirm" + password_confirm);
        
        if (password_confirm == "" || password == "" || email == "")
        {
            enter_panel.SetActive(true);
            return;
        }

        if (password_confirm!=password)
        {
            password_panel.SetActive(true);
            return;
        }
    }
}
