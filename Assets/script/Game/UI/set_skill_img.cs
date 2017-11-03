using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    

public class set_skill_img : MonoBehaviour {

    public Sprite[] sk1_img = new Sprite[6];
    public Sprite[] sk2_img = new Sprite[6];
    int now;
    public GameObject sk1;
    public GameObject sk2;

    // Use this for initialization
    void Start () {
        now = PlayerPrefs.GetInt("now_character");
    }
    private void Awake()
    {
        now = PlayerPrefs.GetInt("now_character");
    }

    // Update is called once per frame
    void Update () {
        
        sk1.GetComponent<Image>().sprite = sk1_img[now];
        sk2.GetComponent<Image>().sprite = sk2_img[now];
    }
}
