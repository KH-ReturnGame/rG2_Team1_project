using UnityEngine;
using UnityEngine.UI; //UI쓴대요

public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 10f;
    private bool facingRight = true;

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

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -5.66f, 3.69f); //제한??
        transform.position = pos;

        // 좌우 반전 (필요시)
        if (moveX > 0 && !facingRight) Flip();
        else if (moveX < 0 && facingRight) Flip();
    }

    void Flip()
    {
        facingRight = !facingRight; //대입
        Vector3 scale = transform.localScale; // 냅둬그냥
        scale.x *= -1;
        transform.localScale = scale; 
    }
}
