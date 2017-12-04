using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Unity.Editor;
using Firebase.Database;
using Firebase;
 



public class DB_control : MonoBehaviour {

    DatabaseReference databaseReference;



    public class character_data
    {
        public int bullet_count;
        public int damage;
        public int hp;
        public int mp;
        public int mp_recover;
        public int max_bullet_count;
        public int max_damage;
        public int max_hp;
        public int max_mp;
        public int max_mp_recover;
        public int useful_stat;

        public int ticket;
        public int stage;
        public string character_have;
        public int level;
        public int exp;
        public int now_character;
        public int money;
        public character_data()
        {

            bullet_count=PlayerPrefs.GetInt("bullet_count");
            damage=PlayerPrefs.GetInt("damage");
            hp=PlayerPrefs.GetInt("hp");
            mp=PlayerPrefs.GetInt("mp");
            mp_recover=PlayerPrefs.GetInt("mp_recover");
            max_bullet_count=PlayerPrefs.GetInt("max_bullet_count");
            max_damage=PlayerPrefs.GetInt("max_damage");
            max_hp=PlayerPrefs.GetInt("max_hp");
            max_mp=PlayerPrefs.GetInt("max_mp");
            max_mp_recover = PlayerPrefs.GetInt("max_mp_recover");
            useful_stat = PlayerPrefs.GetInt("useful_stat");

            ticket = PlayerPrefs.GetInt("ticket");
            stage = PlayerPrefs.GetInt("stage");
            character_have=PlayerPrefs.GetString("character_have");
            level = PlayerPrefs.GetInt("level");
            exp = PlayerPrefs.GetInt("exp");
            now_character = PlayerPrefs.GetInt("now_character");
            money = PlayerPrefs.GetInt("money");
         }
    }

    private void Awake()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://rpgshoot2.firebaseio.com/");
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }


    // Use this for initialization
    void Start () {
		
	}
	
    public void write()
    {
        if(login_join.user!=null)
        {
            character_data data = new character_data();
            string json= JsonUtility.ToJson(data);
            databaseReference.Child("users").Child(login_join.user.UserId).SetRawJsonValueAsync(json);
        }
    }

    public void read()
    {
        FirebaseDatabase.DefaultInstance
            .GetReference("users").Child(login_join.user.UserId) // 읽어올 데이터 이름
            .GetValueAsync().ContinueWith(task =>
            {
                if (task.IsFaulted)
                {
                }
                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;

                    // DataSnapshot 타입에 저장된 값 불러오기
                    PlayerPrefs.SetInt("bullet_count", System.Convert.ToInt32(snapshot.Child("bullet_count").Value.ToString()));
                    PlayerPrefs.SetInt("damage", System.Convert.ToInt32(snapshot.Child("damage").Value.ToString()));
                    PlayerPrefs.SetInt("hp", System.Convert.ToInt32(snapshot.Child("hp").Value.ToString()));
                    PlayerPrefs.SetInt("mp", System.Convert.ToInt32(snapshot.Child("mp").Value.ToString()));
                    PlayerPrefs.SetInt("mp_recover", System.Convert.ToInt32(snapshot.Child("mp_recover").Value.ToString()));
                    PlayerPrefs.SetInt("max_bullet_count", System.Convert.ToInt32(snapshot.Child("max_bullet_count").Value.ToString()));
                    PlayerPrefs.SetInt("max_damage", System.Convert.ToInt32(snapshot.Child("max_damage").Value.ToString()));
                    PlayerPrefs.SetInt("max_hp", System.Convert.ToInt32(snapshot.Child("max_hp").Value.ToString()));
                    PlayerPrefs.SetInt("max_mp", System.Convert.ToInt32(snapshot.Child("max_mp").Value.ToString()));
                    PlayerPrefs.SetInt("max_mp_recover", System.Convert.ToInt32(snapshot.Child("max_mp_recover").Value.ToString()));
                    PlayerPrefs.SetInt("useful_stat", System.Convert.ToInt32(snapshot.Child("useful_stat").Value.ToString()));
                    PlayerPrefs.SetInt("ticket", System.Convert.ToInt32(snapshot.Child("ticket").Value.ToString()));
                    PlayerPrefs.SetInt("stage", System.Convert.ToInt32(snapshot.Child("stage").Value.ToString()));
                    PlayerPrefs.SetInt("level", System.Convert.ToInt32(snapshot.Child("level").Value.ToString()));
                    PlayerPrefs.SetInt("exp", System.Convert.ToInt32(snapshot.Child("exp").Value.ToString()));
                    PlayerPrefs.SetInt("now_character", System.Convert.ToInt32(snapshot.Child("now_character").Value.ToString()));
                    PlayerPrefs.SetInt("money", System.Convert.ToInt32(snapshot.Child("money").Value.ToString()));

                    PlayerPrefs.SetString("character_have", snapshot.Child("character_have").Value.ToString());
                }
            });

    }
    





    // Update is called once per frame
    void Update () {
		
	}
}
