/*
using UnityEngine;


public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 5f; // 외부 변수 만들기(조절 가능)

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // Horiznontal = A, D 또는 ←, →를 감지하는 Unity 전용 함수

        Vector3 move = new Vector3(moveX, 0, 0) * moveSpeed * Time.deltaTime; //Vector3 = 3D 위치 어쩌구 암튼 필요함 Time.deltaTime
        transform.Translate(move, Space.World); //transform.Translate() <- 오브젝트 움직임 / Space.World 월드 좌표계
    }
}
*/

/*
using UnityEngine;


public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 10f;
    private bool facingRight = true;
    void Update()
    {
        float moveX = 0f;


        if (Input.GetKey(KeyCode.D)) //D키 누른 동안 / 땠을때 감지 = GetKeyUp / 처음 누른 순간만 감지 = GetKeyDown
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        Vector2 move = new Vector2(moveX, 0) * moveSpeed * Time.deltaTime; 
        transform.Translate(move, Space.World);
    }
}
*/

/*
using UnityEngine;

public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool facingRight = true;

    void Update()
    {
        float moveX = 0f;

        if (Input.GetKey(KeyCode.D))
            moveX = 1f;
        else if (Input.GetKey(KeyCode.A))
            moveX = -1f;

        // 이동
        Vector3 move = new Vector3(moveX, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // 좌우 반전
        if (moveX > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveX < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight; //대입

        Vector3 scale = transform.localScale; // 냅둬그냥
        scale.x *= -1;
        transform.localScale = scale;
    }
}
*/

/*TODO
애니메이션 스프라이트 바꾸기
(아직 안 바꿔서 오류남)
+ 코드 분석하기

*/


using UnityEngine;
using UnityEngine.UI; //UI쓴대요

public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 10f;
    private bool facingRight = true;

    public Image targetImage;
    public Sprite image1;
    public Sprite[] animationFrames;
    public float frameDuration = 0.2f; //프레임 간격

    private int currentFrame = 0;
    private float timer = 0f; //Time.deltaTime이 float

    void Update()
    {
        float moveX = 0f; //0으로 초기화

        if (Input.GetKey(KeyCode.D))
            moveX = 1f;
        else if (Input.GetKey(KeyCode.A))
            moveX = -1f;

        // 이동
        Vector3 move = new Vector3(moveX, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // 좌우 반전 (필요시)
        if (moveX > 0 && !facingRight) Flip();
        else if (moveX < 0 && facingRight) Flip();

        // 이미지 애니메이션
        if (moveX != 0)
        {
            timer += Time.deltaTime;

            if (timer >= frameDuration)
            {
                timer = 0f;
                currentFrame = (currentFrame + 1) % animationFrames.Length;
                targetImage.sprite = animationFrames[currentFrame];
            }
        }
        else
        {
            targetImage.sprite = image1;
            currentFrame = 0;
            timer = 0f;
        }
    }

    void Flip()
    {
        facingRight = !facingRight; //대입
        Vector3 scale = transform.localScale; // 냅둬그냥
        scale.x *= -1;
        transform.localScale = scale; 
    }
}
