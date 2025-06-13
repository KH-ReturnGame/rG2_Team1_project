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
using UnityEngine;


public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 10f;
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