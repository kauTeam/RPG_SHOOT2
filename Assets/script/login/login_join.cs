using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase.Auth;


public class login_join : MonoBehaviour {


    public static FirebaseUser user;
    public GameObject password_panel;
    public GameObject email_panel;
    public GameObject enter_panel;
    public GameObject success_panel;
    public GameObject login_panel;

    [SerializeField]
    string email;
    [SerializeField]
    string password;
    [SerializeField]
    string password_confirm;
    [SerializeField]
    string email_login;
    [SerializeField]
    string password_login;



    public InputField inputTextEmail_login;
    public InputField inputTextPassword_login;

    public InputField inputTextEmail;
    public InputField inputTextPassword;
    public InputField inputTextPassword_confirm;


    FirebaseAuth auth;
    void Awake()
    {
        // 초기화
        auth = FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);


    }
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
        CreateUser();
    }



    void CreateUser()
    {
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                email_panel.SetActive(true);
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                email_panel.SetActive(true);
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
            success_panel.SetActive(true);
        });
    }


    public void login()
    {
        email_login = inputTextEmail_login.text;
        password_login = inputTextPassword_login.text;
        
        if (password_login == "" || email_login == "")
        {
            enter_panel.SetActive(true);
            return;
        }
        
        LoginUser();
    }

    void LoginUser()
    {
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                login_panel.SetActive(true);
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                login_panel.SetActive(true);
                return;
            }

            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
            PlayerPrefs.SetString("id", email_login);
            PlayerPrefs.SetString("password", password_login);
            AuthStateChanged(this, null);
            //씬전환
            SceneManager.LoadScene("scene/Main");
        });
    }
    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if (auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null;
            if (!signedIn && user != null)
            {
                Debug.Log("Signed out " + user.UserId);
            }
            user = auth.CurrentUser;
            if (signedIn)
            {
                Debug.Log("Signed in " + user.UserId);

            }
        }
    }

}
