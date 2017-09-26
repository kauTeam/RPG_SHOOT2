using UnityEngine;

public class Player_move : MonoBehaviour
{
    Animator ani;

    public joystick stick;   //조이스틱 스크립트
    public float MoveSpeed;     //플레이어 이동속도

    private Vector3 _moveVector; //플레이어 이동벡터
    private Transform _transform;

    void Start()
    {
        _transform = transform;      //Transform 캐싱
        _moveVector = Vector3.zero;  //플레이어 이동벡터 초기화

        ani = GetComponent<Animator>();
    }

    void Update()
    {
        //터치패드 입력 받기
        HandleInput();
    }

    void FixedUpdate()
    {
        //플레이어 이동
        Move();
    }

    public void HandleInput()
    {
        _moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        float h = stick.GetHorizontalValue();
        float v = stick.GetVerticalValue();

        if(this.transform.position.z>17&&v>0)
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
		_transform.Translate(_moveVector * MoveSpeed * Time.deltaTime*Time.timeScale);
        ani.SetFloat("move_x", _moveVector.x);
        ani.SetFloat("move_y", _moveVector.z);
    }
}
