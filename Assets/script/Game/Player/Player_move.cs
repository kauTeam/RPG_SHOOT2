using UnityEngine;

public class Player_move : MonoBehaviour
{
    Animator ani;

    public joystick stick;   //조이스틱 스크립트
    public float MoveSpeed;     //플레이어 이동속도

    private Vector3 _moveVector; //플레이어 이동벡터
    private Transform _transform;

    private GameObject camera;

    private float shake = 0.5f;
    private float shake_amount = 0.7f;
    private float drease = 1.0f;
    Vector3 originalPos;

    private bool shake_true;
    private bool set_jumpingani;
    private bool land;
    private int damage;

    void Awake()
    {
        camera = GameObject.Find("Main Camera");
    }

    void Start()
    {
        shake_true = false;
        set_jumpingani = false;
        land = false;
        _transform = transform;      //Transform 캐싱
        _moveVector = Vector3.zero;  //플레이어 이동벡터 초기화
        ani = GetComponent<Animator>();
        damage = PlayerPrefs.GetInt("damage");
    }

    void OnEnable()
    {
        if (camera == null)
            print("hi");
        else originalPos = camera.transform.localPosition;
    }


    void Update()
    {
        if (GameObject.Find("Player").GetComponent<use_skill>().Istrue_jump() == null)
        {
            GameObject.Find("Player").GetComponent<use_skill>().jump_true();
        }
        else if (GameObject.Find("Player").GetComponent<use_skill>().Istrue_jump() == true)
        {
            if (set_jumpingani == false)
            {
                //print("jump triger");
                ani.SetTrigger("jump");

                set_jumpingani = true;
            }
            if (set_jumpingani == true)
            {
                this.transform.Translate(Vector3.up * Time.deltaTime * 2.0f);


                ani.SetFloat("jump_x", this.transform.position.x);
                ani.SetFloat("jump_y", this.transform.position.y);

                if (this.transform.position.y > 2.5)
                {
                    if (land == false)
                    {
                        GameObject.Find("Player").GetComponent<use_skill>().jump_true();
                        land = true;
                    }
                }
            }
        }
        else if (land)
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * 15.0f);
            ani.SetFloat("jump_x", this.transform.position.x);
            ani.SetFloat("jump_y", this.transform.position.y);
            
            if (this.transform.position.y <= 0)
            {
                land = false;
                set_jumpingani = false;
                shake_true = true;
                ani.SetTrigger("end");

                GameObject[] monsters;
                monsters = GameObject.FindGameObjectsWithTag("monster");

                for (int i = 0; i < monsters.Length; i++)
                {
                    monsters[i].gameObject.GetComponent<Monster_Status>().get_damage(damage);
                }
            }
        }
        else
        {
            //터치패드 입력 받기
            HandleInput();
        }


        if (shake_true)
        {
            if (shake > 0)
            {
                camera.transform.localPosition = originalPos + Random.insideUnitSphere * shake_amount;
                shake -= Time.deltaTime * drease;
            }
            else
            {
                shake = 0.5f;
                camera.transform.localPosition = originalPos;
                shake_true = false;
            }
        }
    }

    void FixedUpdate()
    {
        if (GameObject.Find("Player").GetComponent<use_skill>().Istrue_jump() == null)
        {
            GameObject.Find("Player").GetComponent<use_skill>().jump_true();
        }
        else if (GameObject.Find("Player").GetComponent<use_skill>().Istrue_jump() == false)
        {
            //플레이어 이동
            Move();
        }
    }

    public void HandleInput()
    {
        _moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        float h = stick.GetHorizontalValue();
        float v = stick.GetVerticalValue();

        if (this.transform.position.z > 17 && v > 0)
        {
            v = 0f;
        }
        if (this.transform.position.z < -7 && v < 0)
        {
            v = 0f;
        }

        if (this.transform.position.x > 21 && h > 0)
        {
            h = 0f;
        }
        if (this.transform.position.x < -21 && h < 0)
        {
            h = 0f;
        }


        Vector3 moveDir = new Vector3(h, 0, v).normalized;

        return moveDir;
    }

    public void Move()
    {
        _transform.Translate(_moveVector * MoveSpeed * Time.deltaTime * Time.timeScale);
        ani.SetFloat("move_x", _moveVector.x);
        ani.SetFloat("move_y", _moveVector.z);
    }
}