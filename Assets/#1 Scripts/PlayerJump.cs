using UnityEngine;


// 플레이어가 점프하는 기능을 담당하는 클래스
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigid; // 인스펙터에서 보이게 설정한 물리 컴포넌트
    public float jumpPower = 5f;              
    public bool _Jump = false;                 


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>(); // 이 게임 오브젝트에 붙은 Rigidbody2D 가져오기
    }

   
    private void Update()
    {
        Jump(); 
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_Jump)
        {
            _Jump = true; 
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse); 
        }
    }

    // 바닥에 착지했는지 확인하는 충돌 처리 함수
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Ground"))
        {
            _Jump = false; 
        }
    }
}
