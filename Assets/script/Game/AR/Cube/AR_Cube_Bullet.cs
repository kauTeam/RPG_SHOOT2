using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AR_Cube_Bullet : MonoBehaviour {

    public float speed = 13f;
    public int type = 1;
    public int damage = 30;
    public float target_x;
    public float target_z;
    public float pos_x;
    public float pos_z;
    public float direction;
    public float Stop_var = 1;
    public bool down = true;
    // Use this for initialization
    void Start()
    {
 
    }
    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("0").activeSelf)
        {
            print("연결이 끊어졌습니다.");
            Stop_var = 0;
        }
        else
        {
            print("here");
            Stop_var = 1;
            if (this.transform.position.x == 0)
            {
                if (this.transform.position.z >= 0)
                    this.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime * Time.timeScale * Stop_var);
                else if (this.transform.position.z <= 0)
                    this.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime * Time.timeScale * Stop_var);
            }
            else if (this.transform.position.z == 0)
            {
                if (this.transform.position.x >= 0)
                    this.transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime * Time.timeScale * Stop_var);
                else if (this.transform.position.x <= 0)
                    this.transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * Time.timeScale * Stop_var);
            }
            else
            {
                if (this.transform.position.x >= 0 && this.transform.position.z >= 0)
                {
                    this.transform.Translate(new Vector3(-1, 0, -1) * speed * Time.deltaTime * Time.timeScale * Stop_var);
                }
                else if (this.transform.position.x >= 0 && this.transform.position.z <= 0)
                {
                    this.transform.Translate(new Vector3(-1, 0, 1) * speed * Time.deltaTime * Time.timeScale * Stop_var);
                }
                else if (this.transform.position.x <= 0 && this.transform.position.z >= 0)
                {
                    this.transform.Translate(new Vector3(1, 0, -1) * speed * Time.deltaTime * Time.timeScale * Stop_var);
                }
                else if (this.transform.position.x <= 0 && this.transform.position.z <= 0)
                {
                    this.transform.Translate(new Vector3(1, 0, 1) * speed * Time.deltaTime * Time.timeScale * Stop_var);
                }
            }
        }
    }

    public void setSpeed(int x)

    {
        speed = (float)x;
    }
    public int getDamage()
    {
        return damage;
    }
    public void setDamage(int x)
    {
        damage = x;
    }
    public void setScale(float x, float y, float z)
    {
        this.transform.localScale += new Vector3(x, y, z);
    }
    public void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);
    }

}

